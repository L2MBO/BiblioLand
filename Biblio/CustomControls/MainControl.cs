using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Biblio.CustomControls
{
    public partial class MainControl : UserControl
    {
        private Books _book;
        public event EventHandler<Books> BookClicked;

        public MainControl(Books books)
        {
            InitializeComponent();

            _book = books;

            LoadMainInfo();
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

        private void MainControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _book);
        }
    }
}
