using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class LastUpdatesControl : UserControl
    {
        private Books _books;
        public event EventHandler<Books> BookClicked;

        public LastUpdatesControl(Books books)
        {
            InitializeComponent();

            _books = books;

            LoadLastUpdatesInfo();
        }

        private void LoadLastUpdatesInfo()
        {
            authorLabel.Text = _books.Author.ToString();
            nameLabel.Text = _books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(_books.ImagePath);

            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            RoundingHelper.SetRoundedRegion(this, 30, 30);

            timeLabel.Font = new Font(timeLabel.Font.FontFamily, 8, FontStyle.Regular);
        }

        public void SetTime(string time)
        {
            timeLabel.Text = time;
        }

        private void LastUpdatesControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _books);
        }
    }
}
