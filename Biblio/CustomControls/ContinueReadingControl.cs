using Biblio.Classes.Customization;
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
        public event EventHandler<Books> BookClicked;

        public ContinueReadingControl(Books books)
        {
            InitializeComponent();

            _books = books;

            LoadContinueReadingInfo();
        }

        private void LoadContinueReadingInfo()
        {
            nameLabel.Text = _books.Title.ToString();
            authorLabel.Text = _books.Author.ToString();

            Image image = ImageLoader.LoadBookImage(_books.ImagePath);

            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            RoundingHelper.SetRoundedRegion(this, 30, 30);
        }

        private void ContinueReadingControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _books);
        }
    }
}
