using Biblio.AppForms;
using Biblio.Classes.Services;
using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Windows.Forms;

namespace Biblio
{
    internal static class Program
    {
        public static Users CurrentUser { get; set; }
        public static BiblioModel context = new BiblioModel();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path
                .GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            try
            {
                using (var testContext = new BiblioModel())
                {
                    if (!testContext.Database.Exists())
                    {
                        ValidationHelper.ShowErrorMessage("База данных не найдена. Убедитесь, что файл Biblio.mdf находится в папке bin/release в зависимости от того, какой тип сборки вы используете.\nЕсли его нет соберите проект и добавьте в bin/release файл Biblio.mdf.\nЕго можно найти по пути: Biblio/Docs/БД");
                        return;
                    }
                }

                CleanupService.CleanupExpiredConfirmationCodes();
                CleanupService.CleanupExpiredBans();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к БД:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new AuthorizationForm());
        }
    }
}
