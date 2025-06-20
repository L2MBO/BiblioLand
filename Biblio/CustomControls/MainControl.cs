using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class MainControl : UserControl
    {
        private Books _book;
        private int _currentUserId = Program.CurrentUser.UserID;
        public event EventHandler<Books> BookClicked;

        public MainControl(Books books, bool checkBookmarks = true)
        {
            InitializeComponent();

            _book = books;

            LoadMainInfo();

            if (checkBookmarks)
            {
                CheckBookmarks();
            }
        }

        private void LoadMainInfo()
        {
            authorLabel.Text = _book.Author.ToString();
            nameLabel.Text = _book.Title.ToString();

            Image image = ImageLoader.LoadBookImage(_book.ImagePath);

            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            _book = Program.context.Books.AsNoTracking().FirstOrDefault(b => b.BookID == _book.BookID);

            ratingLabel.Text = ((double)_book.AverageRating).ToString("F1", CultureInfo.InvariantCulture);

            RoundingHelper.SetRoundedRegion(ratingPanel, 20, 20);
        }

        private void CheckBookmarks()
        {
            var bookmark = Program.context.UserBookmarks
                .Where(user => user.UserID == _currentUserId && user.BookID == _book.BookID)
                .FirstOrDefault();

            if (bookmark != null)
            {
                var categoryName = Program.context.UserCategories
                    .Where(category => category.CategoryID == bookmark.CategoryID)
                    .Select(category => category.CategoryName)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(categoryName))
                {
                    statusPanel.Visible = true;
                    userBookmarkStatusLabel.Text = categoryName;
                    RoundingHelper.SetRoundedRegion(statusPanel, 15, 15);
                }
            }
            else
            {
                statusPanel.Visible = false;
            }
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _book);
        }
    }
}
