﻿using Biblio.ValidationClasses;
using System;
using System.IO;

namespace Biblio.Classes.Pdf.OpenPdf
{
    internal class PdfLoader
    {
        private static readonly string _path = "C:\\Users\\lamki\\Documents\\BiblioLandRes\\bookPdf\\";

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
