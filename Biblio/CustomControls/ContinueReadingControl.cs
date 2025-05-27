using Biblio.Classes.Customization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class ContinueReadingControl : UserControl
    {
        private readonly Books _books;
        private readonly int _userId;
        public event EventHandler<Books> BookClicked;

        public ContinueReadingControl(Books books, int userId)
        {
            InitializeComponent();

            _books = books;
            _userId = userId;

            LoadContinueReadingInfo();
        }

        private void LoadContinueReadingInfo()
        {
            nameLabel.Text = _books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(_books.ImagePath);
            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            UpdateReadingProgress();

            RoundingHelper.SetRoundedRegion(this, 30, 30);
        }

        /// <summary>
        /// Обновляет метку и прогресс-бар на основе данных о прогрессе чтения.
        /// </summary>
        private void UpdateReadingProgress()
        {
            try
            {
                int currentPage = UserBookDataHelper.GetCurrentPage(_userId, _books.BookID);

                int totalPages = UserBookDataHelper.GetTotalPages(_books.BookID);

                readingBookProgressLabel.Text = $"Страница {currentPage} из {totalPages}";

                if (totalPages > 0)
                {
                    double realProgressPercentage = (double)currentPage / totalPages * 100;

                    const double minProgressPercentage = 2.0;

                    // Если реальный прогресс меньше минимального, используем минимальный
                    double progressPercentage = Math.Max(realProgressPercentage, minProgressPercentage);

                    readingBookProgressBar.Value = (int)progressPercentage;
                }
                else
                {
                    readingBookProgressBar.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении прогресса чтения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContinueReadingControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _books);
        }
    }
}
