using Biblio.Classes.Hash;
using Biblio.Classes.VisibilityOrEnabled;
using Biblio.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Biblio.Classes.ConfirmationCode
{
    /// <summary>
    /// Создание, проверка и удаление кода верификации
    /// </summary>
    internal class ConfirmationCodeHelper
    {
        /// <summary>
        /// Генерация рандомного кода
        /// </summary>
        /// <returns>Шестизначный код</returns>
        public static string GenerateConfirmationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        /// <summary>
        /// Метод для генерации и установки кода
        /// </summary>
        /// <param name="user">Пользователь, которому будет установлен код подтверждения</param>
        public static string GenerateAndSetConfirmationCode(Users user)
        {
            string confirmationCode = GenerateConfirmationCode();
            string confirmationCodeHash = HashHelper.HashData(confirmationCode);
            user.ConfirmationCodeHash = confirmationCodeHash;
            user.ConfirmationCodeExpiration = DateTime.Now.AddMinutes(5);
            Program.context.SaveChanges();
            return confirmationCode;
        }

        private static System.Windows.Forms.Timer resendTimer;
        private static int remainingSeconds = 60;
        public static event EventHandler TimerEnded;

        /// <summary>
        /// Запуск таймера для повторной отправки кода
        /// </summary>
        /// <param name="TimeInfo">Элемент управления для отображения времени ожидания</param>
        /// <param name="verificationControl">Элемент, который будет блокироваться, на пример PictureBox или Label</param>
        public static void StartResendTimer(Label TimeInfo, IComponent verificationControl)
        {
            if (resendTimer != null)
            {
                resendTimer.Stop();
                resendTimer.Dispose();
            }

            remainingSeconds = 60;

            resendTimer = new System.Windows.Forms.Timer();
            resendTimer.Interval = 1000;
            resendTimer.Tick += (sender, e) =>
            {
                if (remainingSeconds > 0)
                {
                    remainingSeconds--;
                    UpdateTimeRemaining(TimeInfo, remainingSeconds);
                    EnabledHelper.DisableVerificationControl(verificationControl);
                }
                else
                {
                    TimeInfo.Text = "";
                    EnabledHelper.EnableVerificationControl(verificationControl);
                    resendTimer.Stop();
                    TimerEnded?.Invoke(null, EventArgs.Empty);
                }
            };

            resendTimer.Start();
        }

        /// <summary>
        /// Обновление оставшегося времени на форме
        /// </summary>
        /// <param name="TimeInfo">Элемент управления для отображения времени ожидания</param>
        /// <param name="seconds">Оставшееся количество секунд</param>
        private static void UpdateTimeRemaining(Label TimeInfo, int seconds)
        {
            int remainingSeconds = seconds % 60;

            if (seconds > 0)
            {
                TimeInfo.Text = $"({remainingSeconds})";
            }
            else
            {
                TimeInfo.Text = "";
            }
        }
    }
}