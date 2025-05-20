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

namespace Biblio.CustomControls
{
    public partial class MainControl : UserControl
    {
        private Books _books;
        public event EventHandler<Books> BookClicked;
        public event EventHandler OpenChanged;

        public MainControl(Books books)
        {
            InitializeComponent();

            _books = books;

            authorLabel.Text = books.Author.ToString();
            nameLabel.Text = books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(books.ImagePath);
            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            ratingLabel.Text = ((double)books.AverageRating).ToString("F1", CultureInfo.InvariantCulture);

            RoundingHelper.SetRoundedRegion(ratingPanel, 20, 20);

            this.Click += MainControl_Click;
            bookPictureBox.Click += MainControl_Click;
            authorLabel.Click += MainControl_Click;
            nameLabel.Click += MainControl_Click;
            infoPanel.Click += MainControl_Click;
            ratingLabel.Click += MainControl_Click;
            ratingPanel.Click += MainControl_Click;
            starPictureBox.Click += MainControl_Click;
            starPanel.Click += MainControl_Click;
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            BookClicked?.Invoke(this, _books);
        }
    }
}
