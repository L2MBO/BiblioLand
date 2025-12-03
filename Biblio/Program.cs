using Biblio.AppForms;
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
            if (!context.Database.Exists())
            {
                ValidationHelper.ShowErrorMessage("Ошибка подключения к БД");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
