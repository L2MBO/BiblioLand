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
                ValidationHelper.ShowErrorMessage("Не удалось найти обложки для книг.\nУбедитесь, что папка BiblioLandRes находится в папке bin/release в зависимости от того, какой тип вы используете и содержит обложки книг и pdf файлы в папках bookImg и bookPdf соответственно.\nЕсли ее нет соберите проект и добавте в bin/release папку BiblioLandRes.\nЕе можно найти по пути: Biblio/Docs");
                string logPath = "errorPdf_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при открытии PDF файла: {ex.Message}\n");
                throw;
            }
        }
    }
}
