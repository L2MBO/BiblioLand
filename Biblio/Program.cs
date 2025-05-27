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
            if (!context.Database.Exists())
            {
                MessageBox.Show("Ошибка подключения к БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
