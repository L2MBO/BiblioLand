using Biblio.AppForms;
using Biblio.Models;
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

            AppDomain.CurrentDomain.SetData("DataDirectory",System.IO.Path
                .GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            try
            {
                using (var testContext = new BiblioModel())
                {
                    if (!testContext.Database.Exists())
                    {
                        MessageBox.Show("База данных не найдена. Убедитесь, что файл Biblio.mdf находится рядом с приложением.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
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
