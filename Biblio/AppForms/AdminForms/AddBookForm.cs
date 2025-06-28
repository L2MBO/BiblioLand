using Biblio.Classes.Coding;
using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookValidation()
        {
            var nameIsEmpty = nameTextBox.Text == string.IsNullOrEmpty(nameTextBox.Text);
            var authorIsEmpty = authorTextBox.Text == string.IsNullOrEmpty(authorTextBox.Text);
            var descriptionIsEmpty = descriptionTextBox.Text == string.IsNullOrEmpty(descriptionTextBox.Text);
            var imageIsEmpty = // если изображение не было предоставлено.
            var pdfIsEmpty = // если pdf файл не был предоставлен.

            nameLabel.ForeColor = nameIsEmpty == true ? Color.Red : Color.White;
            authorLabel.ForeColor = authorIsEmpty == true ? Color.Red : Color.White;
            descriptionLabel.ForeColor = descriptionIsEmpty == true ? Color.Red : Color.White;
            selectPdfButton.ForeColor = pdfIsEmpty == true ? Color.Red : Color.White;

            if (imageIsEmpty)
            {
                ValidationHelper.ShowErrorMessage("Пожалуйста установите изображение!");
                return;
            }

            if (!nameIsEmpty && !authorIsEmpty && !descriptionIsEmpty && !imageIsEmpty && !pdfIsEmpty)
            {
                ProcessReportSubmission();
            }
        }

        private void ProcessReportSubmission()
        {
            var result = MessageBox.Show("Вы уверены, что хотите добавить эту книгу?",
                "Подтвердите действие!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SendBanToDatabase();
                // нужно перенести выбранное пользователем изображение в папку: "C:\Users\lamki\Documents\BiblioLandRes\bookImg"
                // А pdf файл в папку "C:\Users\lamki\Documents\BiblioLandRes\bookPdf"
            }
        }

        private void SendBanToDatabase()
        {
            var newBook = new Books
            {
                Title = nameTextBox.Text,
                Author = authorTextBox.Text,
                Description = descriptionTextBox.Text,
                ImageName = // только название файла
                PdfName = // только название pdf
                GenreID = genreComboBox.SelectedIndex + 1,
                CategoryID = categoryComboBox.SelectedIndex == 0 ? null : categoryComboBox.SelectedIndex,
                OftenSearched = null,
                AddedDate = DateTime.Now
            };

            Program.context.Books.Add(newBook);
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Книга добавлена!", "Успех!");

            this.Close();
        }

        private string ValidateFiles(string filePath, string[] allowedExtensions, int maxSizeMB)
        {
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

        private void bookPictureBox_Click(object sender, EventArgs e)
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

                    string[] allowedExtensions = {".jpg", ".jpeg", ".png"};

                    string validationError = ValidateFiles(filePath, allowedExtensions, 5);

                    if (!string.IsNullOrEmpty(validationError))
                    {
                        ValidationHelper.ShowErrorMessage(validationError);
                        return;
                    }

                    // уведомить о успешном выборе фото книги
                }
            }
        }

        private void selectPdfButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "|*.pdf";
                openFileDialog.Title = "Выберите файл";

                string screenshotsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.downloads),
                    "Downloads");

                openFileDialog.InitialDirectory = Directory.Exists(screenshotsPath)
                    ? screenshotsPath
                    : Environment.GetFolderPath(Environment.SpecialFolder.downloads);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string[] allowedExtensions = { ".pdf" };

                    string validationError = ValidateFiles(filePath, allowedExtensions, 5);

                    if (!string.IsNullOrEmpty(validationError))
                    {
                        ValidationHelper.ShowErrorMessage(validationError);
                        return;
                    }

                    // уведомить о успешном выборе pdf файла
                }
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookValidation();
            if (/*если фото книги выбрано*/)
            {
                // нужно перенести выбранное пользователем изображение в папку: "C:\Users\lamki\Documents\BiblioLandRes\bookImg"
            }

            else if (DialogResult == DialogResult.Cancel)
            {
                // перенести выбранный пользователем pdf файл в папку "C:\Users\lamki\Documents\BiblioLandRes\bookPdf"
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
