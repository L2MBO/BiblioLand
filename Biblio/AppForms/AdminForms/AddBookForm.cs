using Biblio.Classes.Images.InstallingImages;
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
        private Books _editingBook;

        public AddBookForm(Books book = null)
        {
            InitializeComponent();

            _editingBook = book;

            LoadBookInfo();
        }

        private void LoadBookInfo()
        {
            if (_editingBook != null)
            {
                // Режим редактирования
                titleLabel.Text = "Изменить книгу";
                addBookButton.Text = "Изменить книгу";

                // Заполняем поля
                nameTextBox.Text = _editingBook.Title;
                authorTextBox.Text = _editingBook.Author;
                descriptionTextBox.Text = _editingBook.Description;

                // Устанавливаем жанр и категорию
                if (_editingBook.GenreID.HasValue)
                    genreComboBox.SelectedIndex = _editingBook.GenreID.Value - 1;

                if (_editingBook.CategoryID.HasValue)
                    categoryComboBox.SelectedIndex = _editingBook.CategoryID.Value;
                else
                    categoryComboBox.SelectedIndex = 0;

                Image image = ImageLoader.LoadBookImage(_editingBook.ImageName);

                if (image != null)
                {
                    bookPictureBox.Image = image;
                }

                if (!string.IsNullOrEmpty(_editingBook.PdfName))
                {
                    _selectedPdfPath = Path.Combine(@"C:\Users\lamki\Documents\BiblioLandRes\bookPdf", _editingBook.PdfName);
                    selectPdfLabel.Text = "Выбран файл: " + _editingBook.PdfName;
                    selectPdfLabel.ForeColor = Color.White;
                }
            }
        }

        private void AddBookValidation()
        {
            var nameIsEmpty = string.IsNullOrEmpty(nameTextBox.Text);
            var authorIsEmpty = string.IsNullOrEmpty(authorTextBox.Text);
            var descriptionIsEmpty = string.IsNullOrEmpty(descriptionTextBox.Text);
            var pdfIsEmpty = string.IsNullOrEmpty(_selectedPdfPath);

            bool isEditing = _editingBook != null;
            bool hasExistingImage = isEditing && !string.IsNullOrEmpty(_editingBook.ImageName);
            bool imageIsEmpty = string.IsNullOrEmpty(_selectedImagePath) && !hasExistingImage;

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
            var message = _editingBook != null
                ? "Вы уверены, что хотите сохранить изменения?"
                : "Вы уверены, что хотите добавить эту книгу?";

            var result = MessageBox.Show(message,
                "Подтвердите действие!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SendBookToDatabase();
            }
        }

        private void SendBookToDatabase()
        {
            try
            {
                string imgDirectory = @"C:\\Users\\lamki\\OneDrive\\Документы\\BiblioLandRes\\bookImg\\bookImg";
                string pdfDirectory = @"C:\\Users\\lamki\\OneDrive\\Документы\\BiblioLandRes\\bookImg\\bookPdf";

                Directory.CreateDirectory(imgDirectory);
                Directory.CreateDirectory(pdfDirectory);

                string imgFileName = _editingBook?.ImageName; // сохраняем старое имя, если файл не менялся
                string pdfFileName = _editingBook?.PdfName;

                if (!string.IsNullOrEmpty(_selectedImagePath))
                {
                    // Проверяем, изменилось ли изображение
                    if (_editingBook == null || Path.GetFileName(_selectedImagePath) != _editingBook.ImageName)
                    {
                        imgFileName = Path.GetFileName(_selectedImagePath);
                        string destImgPath = Path.Combine(imgDirectory, imgFileName);
                        File.Copy(_selectedImagePath, destImgPath, true);
                    }
                }

                if (!string.IsNullOrEmpty(_selectedPdfPath))
                {
                    if (_editingBook == null || Path.GetFileName(_selectedPdfPath) != _editingBook.PdfName)
                    {
                        pdfFileName = Path.GetFileName(_selectedPdfPath);
                        string destPdfPath = Path.Combine(pdfDirectory, pdfFileName);
                        File.Copy(_selectedPdfPath, destPdfPath, true);
                    }
                }

                if (_editingBook == null)
                {
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
                }

                else
                {
                    _editingBook.Title = nameTextBox.Text;
                    _editingBook.Author = authorTextBox.Text;
                    _editingBook.Description = descriptionTextBox.Text;
                    _editingBook.ImageName = imgFileName;
                    _editingBook.PdfName = pdfFileName;
                    _editingBook.GenreID = genreComboBox.SelectedIndex + 1;
                    _editingBook.CategoryID = categoryComboBox.SelectedIndex == 0 ? (int?)null : categoryComboBox.SelectedIndex;
                    // Не обновляем AddedDate, OftenSearched и AverageRating при редактировании

                    Program.context.Entry(_editingBook).State = System.Data.Entity.EntityState.Modified;
                }

                Program.context.SaveChanges();

                ValidationHelper.ShowInformationMessage(_editingBook == null ? "Книга добавлена!" : "Книга обновлена!", "Успех!");

                this.Close();
            }
            catch (Exception ex)
            {
                ValidationHelper.ShowErrorMessage($"Ошибка при сохранении книги: {ex.Message}");
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
