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
        private string _selectedImagePath;
        private string _selectedPdfPath;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookValidation()
        {
            var nameIsEmpty = string.IsNullOrEmpty(nameTextBox.Text);
            var authorIsEmpty = string.IsNullOrEmpty(authorTextBox.Text);
            var descriptionIsEmpty = string.IsNullOrEmpty(descriptionTextBox.Text);
            var imageIsEmpty = string.IsNullOrEmpty(_selectedImagePath);
            var pdfIsEmpty = string.IsNullOrEmpty(_selectedPdfPath);

            nameLabel.ForeColor = nameIsEmpty == true ? Color.Red : Color.White;
            authorLabel.ForeColor = authorIsEmpty == true ? Color.Red : Color.White;
            descriptionLabel.ForeColor = descriptionIsEmpty == true ? Color.Red : Color.White;
            selectPdfLabel.ForeColor = pdfIsEmpty == true ? Color.Red : Color.White;

            if (!nameIsEmpty && !authorIsEmpty && !descriptionIsEmpty && !pdfIsEmpty)
            {
                if (imageIsEmpty)
                {
                    ValidationHelper.ShowErrorMessage("Пожалуйста установите изображение!");
                    return;
                }

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
            }
        }

        private void SendBanToDatabase()
        {
            try
            {
                string imgDirectory = @"C:\Users\lamki\Documents\BiblioLandRes\bookImg";
                string pdfDirectory = @"C:\Users\lamki\Documents\BiblioLandRes\bookPdf";

                string imgFileName = Path.GetFileName(_selectedImagePath);
                string pdfFileName = Path.GetFileName(_selectedPdfPath);

                string destImgPath = Path.Combine(imgDirectory, imgFileName);
                string destPdfPath = Path.Combine(pdfDirectory, pdfFileName);

                // Создаем директории, если их нет
                Directory.CreateDirectory(imgDirectory);
                Directory.CreateDirectory(pdfDirectory);

                // Копируем файлы
                File.Copy(_selectedImagePath, destImgPath, true);
                File.Copy(_selectedPdfPath, destPdfPath, true);

                var newBook = new Books
                {
                    Title = nameTextBox.Text,
                    Author = authorTextBox.Text,
                    Description = descriptionTextBox.Text,
                    ImageName = imgFileName,
                    PdfName = pdfFileName,
                    GenreID = genreComboBox.SelectedIndex + 1,
                    CategoryID = categoryComboBox.SelectedIndex == 0 ? (int?)null : categoryComboBox.SelectedIndex,
                    OftenSearched = null,
                    AverageRating = (decimal?)0.00,
                    AddedDate = DateTime.Now
                };

                Program.context.Books.Add(newBook);
                Program.context.SaveChanges();

                ValidationHelper.ShowInformationMessage("Книга добавлена!", "Успех!");

                this.Close();
            }
            catch (Exception ex)
            {
                ValidationHelper.ShowErrorMessage($"Ошибка при добавлении книги: {ex.Message}");
            }
        }

        private string ValidateFiles(string filePath, string[] allowedExtensions, int maxSizeMB)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (!allowedExtensions.Contains(extension))
            {
                return $"Недопустимый формат файла. Разрешены только {string.Join(", ", allowedExtensions)}.";
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

                    string[] allowedExtensions = { ".jpg", ".jpeg", ".png" };

                    string validationError = ValidateFiles(filePath, allowedExtensions, 5);

                    if (!string.IsNullOrEmpty(validationError))
                    {
                        ValidationHelper.ShowErrorMessage(validationError);
                        return;
                    }

                    _selectedImagePath = filePath;
                    bookPictureBox.Image = Image.FromFile(filePath);
                }
            }
        }

        private void selectPdfButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf";
                openFileDialog.Title = "Выберите PDF файл";

                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                openFileDialog.InitialDirectory = Directory.Exists(downloadsPath)
                    ? downloadsPath
                    : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string[] allowedExtensions = { ".pdf" };

                    string validationError = ValidateFiles(filePath, allowedExtensions, 200);

                    if (!string.IsNullOrEmpty(validationError))
                    {
                        ValidationHelper.ShowErrorMessage(validationError);
                        return;
                    }

                    _selectedPdfPath = filePath;
                    selectPdfLabel.ForeColor = Color.White;
                    selectPdfLabel.Text = "Выбран файл: " + Path.GetFileName(filePath);
                }
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookValidation();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameLabel.ForeColor == Color.Red)
            {
                nameLabel.ForeColor = Color.White;
            }
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (authorLabel.ForeColor == Color.Red)
            {
                authorLabel.ForeColor = Color.White;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descriptionLabel.ForeColor == Color.Red)
            {
                descriptionLabel.ForeColor = Color.White;
            }
        }
    }
}
