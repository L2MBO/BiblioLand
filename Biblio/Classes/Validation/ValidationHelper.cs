using Biblio.Classes.Coding;
using Biblio.Classes.ConfirmationCode;
using Biblio.Classes.Hash;
using Biblio.HideClasses;
using Biblio.Models;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.ValidationClasses
{
    public class ValidationHelper
    {
        private int _failedAttempts = 0;

        public bool ValidateLogIn(MaterialSingleLineTextField loginField, MaterialSingleLineTextField passwordField, Label loginInfo, Label timeInfo, Guna2Button loginButton)
        {
            List<Users> users = Program.context.Users.ToList();
            string login = loginField.Text;
            string password = passwordField.Text;

            Users verification = users.FirstOrDefault(user => user.Username == login || user.Email == login);

            if (verification != null)
            {
                bool isPasswordValid = HashHelper.VerifyPassword(password, verification.PasswordHash);

                if (isPasswordValid)
                {
                    Program.CurrentUser = verification;
                    _failedAttempts = 0;
                    loginField.Clear();
                    passwordField.Clear();
                    return true;
                }
            }

            _failedAttempts++;

            if (_failedAttempts >= 5)
            {
                VisibilityHelper.ShowLogInLabel(loginInfo, timeInfo);
                ConfirmationCodeHelper.StartResendTimer(timeInfo, loginButton);

                ConfirmationCodeHelper.TimerEnded += (sender, e) =>
                {
                    loginInfo.Visible = false;
                };

                ShowCustomTitleErrorMessage("Вы использовали слишком много попыток, пожалуйста попробуйте позже.", "Вход временно заблокирован.");
                _failedAttempts = 0;
                return false;
            }
            else
            {
                ShowErrorMessage("Имя пользователя или пароль введены неверно");
                return false;
            }
        }

        private static readonly Regex _onlyEnglishChars = new Regex(@"^[A-Za-z\d\W_]+$");

        public static bool ValidationRegistration(MaterialSingleLineTextField LoginField, MaterialSingleLineTextField MailField, MaterialSingleLineTextField PasswordField, MaterialSingleLineTextField ConfirmPasswordField)
        {
            string newUsername = LoginField.Text;
            string newMail = MailField.Text;
            string newPassword = PasswordField.Text;

            if (_onlyEnglishChars.IsMatch(newUsername))
            {
                if (!IsUsernameOrMailTaken(LoginField, MailField))
                {
                    string passwordHash = HashHelper.HashPassword(newPassword);
                    string base64Avatar = CodingOrDecoding.ImageCoding(null);

                    Users newUser = new Users
                    {
                        Username = newUsername,
                        CoinsNumber = 0,
                        Email = newMail,
                        PasswordHash = passwordHash,
                        UserRoleID = 1,
                        RegistrationDate = DateTime.Now,
                        AvatarPath = base64Avatar
                    };

                    LoginField.Clear();
                    MailField.Clear();
                    PasswordField.Clear();
                    ConfirmPasswordField.Clear();

                    Program.context.Users.Add(newUser);
                    Program.context.SaveChanges();
                    ShowInformationMessage("Приветствуем в наших рядах читателей!", "Вы успешно зарегестрировались");

                    return true;
                }
                ShowErrorMessage("Имя пользователя или почта уже существуют.");
            }
            ShowErrorMessage("Имя пользователя должно содержать только английские буквы.");
            return false;
        }

        public static bool _isCodeSent = false;

        public async Task<(bool success, string email)> ValidationForgetPassword(MaterialSingleLineTextField MailField, Label VerificationCodeInfo, MaterialSingleLineTextField VerificationCodeField, Label ResendVerificationCode, Label TimeInfo)
        {
            List<Users> users = Program.context.Users.ToList();
            string email = MailField.Text;

            Users user = users.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                ShowErrorMessage("Данная почта не числится в системе");
                return (false, null);
            }

            if (!_isCodeSent)
            {
                if (user.ConfirmationCode == null || user.ConfirmationCodeExpiration == null || user.ConfirmationCodeExpiration < DateTime.Now)
                {
                    ConfirmationCodeHelper.GenerateAndSetConfirmationCode(user);

                    //string confirmationCode = user.ConfirmationCode;

                    //var sendMessageCode = new SendMessageCode();
                    //PostResult result = await sendMessageCode.SendPostRequest(email, confirmationCode);
                }

                //if (result.IsSuccess)
                //{
                VisibilityHelper.ShowVerificationCode(VerificationCodeInfo, VerificationCodeField, ResendVerificationCode, TimeInfo);
                ConfirmationCodeHelper.StartResendTimer(TimeInfo, ResendVerificationCode);
                _isCodeSent = true;
                //}
                //else
                //{
                //    ShowErrorMessage("Не удалось отправить код подтверждения.");
                //    user.ConfirmationCode = null;
                //    user.ConfirmationCodeExpiration = null;
                return (false, user.Email);
                //}
                //return false;
            }

            else
            {
                if (VerificationCodeField.Text == user.ConfirmationCode)
                {
                    user.ConfirmationCode = null;
                    user.ConfirmationCodeExpiration = null;
                    Program.context.SaveChanges();

                    ShowInformationMessage("Пожалуйста введите новый пароль", "Код верификации введен успешно");
                    return (true, user.Email);
                }
                else
                {
                    ShowCustomTitleErrorMessage("Попробуйте ввести код заново или нажмите 'Отправить еще раз'", "Неверный код подтверждения");
                    return (false, null);
                }
            }
        }

        public static bool ValidationPasswordFields(Users user, string PasswordField)
        {
            string passwordHash = HashHelper.HashPassword(PasswordField);

            bool isPasswordValid = HashHelper.VerifyPassword(PasswordField, user.PasswordHash);

            if (isPasswordValid)
            {
                ShowErrorMessage("Новый пароль должен отличаться от старого");
                return false;
            }
            else if (user != null)
            {
                user.PasswordHash = passwordHash;
                Program.context.SaveChanges();
                return true;
            }
            else
            {
                ShowErrorMessage("Пользователь не найден");
                return false;
            }
        }

        public bool ValidationPasswordRecovery(string email, MaterialSingleLineTextField PasswordField, MaterialSingleLineTextField ConfirmPasswordField)
        {
            string newPassword = PasswordField.Text;

            Users user = Program.context.Users.FirstOrDefault(u => u.Email == email);

            if (ValidationPasswordFields(user, newPassword))
            {
                PasswordField.Clear();
                ConfirmPasswordField.Clear();
                ShowInformationMessage("Пожалуйста войдите в систему", "Вы успешно сменили пароль");
                return true;
            }

            return false;
        }

        public static void ValidationResetPassword(Guna2TextBox OldPasswordField, Guna2TextBox PasswordField, Guna2TextBox ConfirmPasswordField)
        {
            string newPassword = PasswordField.Text;
            string oldPassword = OldPasswordField.Text;

            int currentUserId = Program.CurrentUser.UserID;

            Users currentUser = Program.context.Users.FirstOrDefault(u => u.UserID == currentUserId);

            if (ValidationOldPassword(currentUser, oldPassword))
            {
                if (ValidationPasswordFields(currentUser, newPassword))
                {
                    OldPasswordField.Clear();
                    PasswordField.Clear();
                    ConfirmPasswordField.Clear();
                    ShowInformationMessage("Смена пароля прошла успешно", "Данные обновлены");
                }
            }
        }

        public static bool ValidationOldPassword(Users user, string OldPasswordField)
        {
            string passwordHash = HashHelper.HashPassword(OldPasswordField);

            bool isPasswordCorrect = HashHelper.VerifyPassword(OldPasswordField, user.PasswordHash);

            if (isPasswordCorrect)
            {
                return true;
            }
            else
            {
                ShowErrorMessage("Неверный пароль");
                return false;
            }
        }

        public static async Task ResendConfirmationCode(MaterialSingleLineTextField MailField, Label TimeInfo, Label ResendVerificationCode)
        {
            string email = MailField.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowErrorMessage("Введите электронную почту");
                return;
            }

            Users user = Program.context.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                ConfirmationCodeHelper.GenerateAndSetConfirmationCode(user);

                //string confirmationCode = user.ConfirmationCode;

                //var sendMessageCode = new SendMessageCode();
                //PostResult result = await sendMessageCode.SendPostRequest(email, confirmationCode);

                //if (result.IsSuccess)
                //{
                ConfirmationCodeHelper.StartResendTimer(TimeInfo, ResendVerificationCode);
                ShowInformationMessage("Новый код подтверждения отправлен на вашу электронную почту.", "Проверьте почту");
                //}
                //else
                //{
                //    ShowErrorMessage("Не удалось отправить код подтверждения.");
                //}
            }
            else
            {
                ShowErrorMessage("Данная почта не числится в системе");
            }
        }

        public static async Task<bool> ValidateFieldIsEmpty(MaterialSingleLineTextField[] fields)
        {
            Color errorColor = ColorTranslator.FromHtml("#b71c1c");
            bool allFieldsFilled = true;

            var tasks = fields.Select(async field =>
            {
                Color originalColor = field.BackColor;

                if (field.Text == "")
                {
                    field.BackColor = errorColor;
                    await Task.Delay(500);
                    field.BackColor = originalColor;
                    allFieldsFilled = false;
                }
            });

            await Task.WhenAll(tasks);
            return allFieldsFilled;
        }

        public static bool IsUsernameOrMailTaken(MaterialSingleLineTextField LoginField, MaterialSingleLineTextField MailField)
        {
            List<Users> users = Program.context.Users.ToList();
            string login = LoginField.Text;
            string mail = MailField.Text;
            return users.Any(name => name.Username == login || name.Email == mail);
        }

        public static bool ValidateMailField(string mail)
        {
            try
            {
                if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    ShowErrorMessage("Неверный формат email. Пример: example@domain.com");
                    return false;
                }

                return true;
            }
            catch (ArgumentException)
            {
                ShowErrorMessage("Некорректный email.");
                return false;
            }
            catch (RegexMatchTimeoutException)
            {
                ShowErrorMessage("Слишком сложный email. Попробуйте ещё раз.");
                return false;
            }
        }

        public static void ValidateNewMail(Guna2TextBox newMail)
        {
            string mail = newMail.Text?.Trim();
            int currentUserId = Program.CurrentUser.UserID;

            Users currentUser = Program.context.Users.FirstOrDefault(u => u.UserID == currentUserId);

            if (mail != currentUser.Email)
            {
                currentUser.Email = mail;
                Program.context.SaveChanges();
                newMail.Clear();
                ShowInformationMessage("Смена почты прошла успешно", "Данные обновлены");
            }
            else
            {
                ShowErrorMessage("Новая почта должна отличаться от старой");
            }
        }

        private static readonly Regex _hasUpperChar = new Regex(@"[A-Z]");
        private static readonly Regex _hasLowerChar = new Regex(@"[a-z]");
        private static readonly Regex _hasDigit = new Regex(@"\d");
        private static readonly Regex _hasSpecialChar = new Regex(@"[\W_]");

        public static bool ValidatePasswords(string password, string confirmPassword)
        {
            if (!_onlyEnglishChars.IsMatch(password))
            {
                ShowErrorMessage("Пароль должен содержать только английские буквы.");
                return false;
            }

            if (password.Contains(" "))
            {
                ShowErrorMessage("Пароль не должен содержать пробелов.");
                return false;
            }

            if (!_hasUpperChar.IsMatch(password))
            {
                ShowErrorMessage("Пароль должен содержать хотя бы одну заглавную букву.");
                return false;
            }

            if (!_hasLowerChar.IsMatch(password))
            {
                ShowErrorMessage("Пароль должен содержать хотя бы одну строчную букву.");
                return false;
            }

            if (!_hasDigit.IsMatch(password))
            {
                ShowErrorMessage("Пароль должен содержать хотя бы одну цифру.");
                return false;
            }

            if (!_hasSpecialChar.IsMatch(password))
            {
                ShowErrorMessage("Пароль должен содержать хотя бы один специальный символ.");
                return false;
            }

            if (password.Length < 8)
            {
                ShowErrorMessage("Пароль должен содержать минимум 8 символов.");
                return false;
            }

            if (password.Length > 64)
            {
                ShowErrorMessage("Пароль не должен превышать 64 символа.");
                return false;
            }

            if (password != confirmPassword)
            {
                ShowErrorMessage("Пароли не совпадают.");
                return false;
            }
            return true;
        }



        public static bool ValidationPasswordField(MaterialSingleLineTextField passwordField, MaterialSingleLineTextField confirmPasswordField)
        {
            return ValidatePasswords(passwordField.Text, confirmPasswordField.Text);
        }

        public static bool ValidationPasswordField(Guna2TextBox passwordField, Guna2TextBox confirmPasswordField)
        {
            return ValidatePasswords(passwordField.Text, confirmPasswordField.Text);
        }

        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowCustomTitleErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformationMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
