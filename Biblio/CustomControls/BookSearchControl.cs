using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class BookSearchControl : UserControl
    {
        private Books _books;
        public event EventHandler<Books> BookClicked;

        public BookSearchControl(Form parentForm, Books books)
        {
            InitializeComponent();

            _books = books;

            LoadBookSearchInfo();
        }

        private void LoadBookSearchInfo()
        {
            authorLabel.Text = _books.Author.ToString();
            nameLabel.Text = _books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(_books.ImagePath);

            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            RoundingHelper.SetRoundedRegion(this, 10, 10);
        }

        private void BookSearchControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _books);
        }
    }
}
