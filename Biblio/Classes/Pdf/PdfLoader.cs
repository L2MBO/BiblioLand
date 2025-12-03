using Biblio.ValidationClasses;
using System;
using System.IO;

namespace Biblio.Classes.Pdf.OpenPdf
{
    internal class PdfLoader
    {
        private static readonly string _baseResourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BiblioLandRes");
        private static readonly string _path = Path.Combine(_baseResourcePath, "bookPdf");

        public static void OpenPdfFile(string pdfFileName)
        {
            string fullPdfPath = Path.Combine(_path, pdfFileName);

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
                ValidationHelper.ShowErrorMessage($"Не удалось найти pdf файл: {pdfFileName}.\nУбедитесь, что папка BiblioLandRes находится рядом с приложением и содержит нужный pdf файл в папке bookPdf");
                string logPath = "errorPdf_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при открытии PDF файла: {ex.Message}\n");
                throw;
            }
        }
    }
}
