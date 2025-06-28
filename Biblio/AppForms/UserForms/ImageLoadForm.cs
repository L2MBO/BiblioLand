using Biblio.Classes.Coding;
using Biblio.ValidationClasses;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class ImageLoadForm : Form
    {
        public string Base64Avatar { get; private set; }

        public ImageLoadForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Выберите изображение";

                string screenshotsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    "Screenshots");

                openFileDialog.InitialDirectory = Directory.Exists(screenshotsPath)
                    ? screenshotsPath
                    : Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string validationError = ValidateImageFile(filePath, maxSizeMB: 5);

                    if (!string.IsNullOrEmpty(validationError))
                    {
                        ValidationHelper.ShowErrorMessage(validationError);
                        return;
                    }

                    Base64Avatar = CodingOrDecoding.ImageCoding(filePath);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Проверяет, подходит ли файл по формату и размеру.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="maxSizeMB">Максимальный размер в мегабайтах (по умолчанию 5 МБ).</param>
        /// <returns>Сообщение об ошибке или null, если файл корректен.</returns>
        private string ValidateImageFile(string filePath, int maxSizeMB = 5)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png" };
            string extension = Path.GetExtension(filePath).ToLower();

            if (!allowedExtensions.Contains(extension))
            {
                return "Недопустимый формат файла. Разрешены только JPG, JPEG и PNG.";
            }

            long maxSizeBytes = maxSizeMB * 1024 * 1024;
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Length > maxSizeBytes)
            {
                return $"Размер файла не должен превышать {maxSizeMB} МБ.";
            }

            return null; // Файл прошел проверку
        }
    }
}
