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

namespace Biblio.AppForms
{
    public partial class BookInfoForm : Form
    {
        private Books _book;

        public BookInfoForm(Books book)
        {
            InitializeComponent();
            //AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);
            _book = book;
            LoadBookInfo();
        }

        private void LoadBookInfo()
        {
            //titleLabel.Text = _book.Title;
            //authorLabel.Text = _book.Author;
            //descriptionTextBox.Text = _book.Description;
            //raitingLabel.Text = ((double)_book.AverageRating).ToString("F1", CultureInfo.InvariantCulture);

            Image image = ImageLoader.LoadBookImage(_book.ImagePath);
            if (image != null)
            {
                //bookPictureBox.Image = image;
            }
        }
    }
}
