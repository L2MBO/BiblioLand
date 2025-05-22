using Biblio.ValidationClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Classes.Pdf.OpenPdf
{
    internal class PdfLoader
    {
        private static readonly string _path = "C:\\Users\\lamki\\Documents\\BiblioLand\\bookPdf\\";

        public static void OpenPdfFile(string pdfFileName)
        {
            string fullPdfPath = _path + pdfFileName;

            if (string.IsNullOrEmpty(fullPdfPath) || !File.Exists(fullPdfPath))
            {
                ValidationHelper.ShowErrorMessage("Не удалось найти книгу");
            }

            try
            {
                System.Diagnostics.Process.Start(fullPdfPath);
            }
            catch (Exception ex)
            {
                string logPath = "errorPdf_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при открытии PDF файла: {ex.Message}\n");
                throw;
            }
        }
    }
}
