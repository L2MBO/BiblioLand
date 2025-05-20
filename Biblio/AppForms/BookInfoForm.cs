using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.CustomControls;
using Biblio.Models;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;
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
    public partial class BookInfoForm : MaterialForm
    {
        private Books _book;

        public BookInfoForm(Books book)
        {
            InitializeComponent();

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(panel1, disableHorizontal: false, disableVertical: true);

            _book = book;
            
            descriptionLabel.TextChanged += DescriptionLabel_TextChanged;

            LoadBookInfo();
        }

        private void LoadBookInfo()
        {
            nameLabel.Text = _book.Title;
            authorLabel.Text = _book.Author;

            var genreID = _book.GenreID;

            var genreName = Program.context.Genres.FirstOrDefault(genre => genre.GenreID == genreID);

            genreLabel.Text = genreName.GenreName;

            var rating = _book.AverageRating;

            ratingLabel.Text = ((double)rating).ToString("F1", CultureInfo.InvariantCulture);

            //число голосов

            Image image = ImageLoader.LoadBookImage(_book.ImagePath);

            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            descriptionLabel.Text = _book.Description;

            ShowStatisticsBooks();

            //overageRatingLabel.Text = "Рейтинг за последнее время: " + rating;
        }

        private void ShowStatisticsBooks()
        {
            var statisticsControl = new StatisticsControl(_book);

            statisticsPanel.Controls.Add(statisticsControl);
        }

        private void DescriptionLabel_TextChanged(object sender, EventArgs e)
        {
            int labelWidth = descriptionLabel.Width;

            int preferredHeight = CalculateLabelHeight(descriptionLabel.Text, descriptionLabel.Font, labelWidth);

            descriptionLabel.Height = preferredHeight;

            descriptionPanel.PerformLayout();
        }

        private int CalculateLabelHeight(string text, Font font, int width)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(text, font, new Size(width, 0), TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
