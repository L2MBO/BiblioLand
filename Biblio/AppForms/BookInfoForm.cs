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
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
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

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);

            _book = book;

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

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

            Image bookimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (bookimage != null)
            {
                bookPictureBox.Image = bookimage;
            }

            Image backimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (backimage != null)
            {
                var bitmap = backimage as Bitmap ?? new Bitmap(backimage);
                Image preparedBackground = WhiteLevelReducer.PrepareBackground(bitmap, 10, 0.6f);
                mainPanel.BackgroundImage = preparedBackground;
            }

            descriptionLabel.Text = _book.Description;

            ShowStatisticsBooks();
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

        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void BookInfoForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
