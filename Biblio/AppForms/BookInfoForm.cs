using Biblio.Classes.Customization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Classes.Pdf.OpenPdf;
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
    public partial class BookInfoForm : MaterialForm
    {
        private Books _book;
        private int _currentUserId = Program.CurrentUser.UserID;
        private int _bookmarkX;

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

            mainPanel.Scroll += (sender, e) => UpdateBookmarksControlPosition();
        }

        private void LoadBookInfo()
        {
            nameLabel.Text = _book.Title;
            authorLabel.Text = _book.Author;

            var genreID = _book.GenreID;

            var genreName = Program.context.Genres.FirstOrDefault(genre => genre.GenreID == genreID);

            genreLabel.Text = genreName.GenreName;

            ShowRating();

            ratingCountLabel.Text = Program.context.Rating.Where(book => book.BookID == _book.BookID).Count().ToString();

            Image bookimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (bookimage != null)
            {
                bookPictureBox.Image = bookimage;
            }

            Image backimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (backimage != null)
            {
                var bitmap = backimage as Bitmap ?? new Bitmap(backimage);
                Image preparedBackground = WhiteLevelReducer.PrepareBackground(bitmap, 20, 0.6f);
                mainPanel.BackgroundImage = preparedBackground;
            }

            descriptionLabel.Text = _book.Description;

            ShowStatisticsBooks();
            UpdateBookmarkButtonText();
            UpdateContinueReadingButtonText();
        }

        private void UpdateBookmarkButtonText()
        {
            var bookmark = Program.context.UserBookmarks.FirstOrDefault(
                b => b.UserID == _currentUserId && b.BookID == _book.BookID);

            if (bookmark != null)
            {
                var bookmarkName = Program.context.UserCategories.FirstOrDefault(category => category.CategoryID == bookmark.CategoryID);

                newBookmarkButton.Text = bookmarkName.CategoryName;
            }

            else
            {
                newBookmarkButton.Text = "В закладки";
            }
        }

        private void ShowRating()
        {
            var rating = (double)_book.AverageRating;

            ratingLabel.Text = (rating).ToString("F1", CultureInfo.InvariantCulture);

            if (rating <= 5.0)
            {
                ratingLabel.ForeColor = Color.Red;
            }

            else if (rating <= 8.0)
            {
                ratingLabel.ForeColor = Color.Yellow;
            }

            else
            {
                ratingLabel.ForeColor = Color.Green;
            }
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

        private BookmarksControl bookmarksControl;

        private void UpdateBookmarksControlPosition()
        {
            if (bookmarksControl != null && newBookmarkButton != null && newBookmarkButton.Parent != null)
            {
                int scrollY = -mainPanel.AutoScrollPosition.Y;

                int x = newBookmarkButton.Left + newBookmarkButton.Width - _bookmarkX;
                int y = newBookmarkButton.Bottom + 20 - scrollY;

                bookmarksControl.Location = new Point(x, y);
            }
        }

        private void RemoveBookmarksControl()
        {
            if (bookmarksControl != null)
            {
                if (mainPanel.Controls.Contains(bookmarksControl))
                {
                    mainPanel.Controls.Remove(bookmarksControl);
                }
                bookmarksControl.Dispose();
                bookmarksControl = null;
            }
        }

        private void UpdateBookmarkStatus()
        {
            var bookmark = Program.context.UserBookmarks.FirstOrDefault(
                    b => b.UserID == _currentUserId && b.BookID == _book.BookID);

            if (bookmark == null)
            {
                bookmark = new UserBookmarks
                {
                    UserID = _currentUserId,
                    BookID = _book.BookID,
                    CategoryID = 2,
                    LastReadDate = DateTime.Now
                };

                Program.context.UserBookmarks.Add(bookmark);
                Program.context.SaveChanges();

                UpdateBookmarkButtonText();

                var statsControl = statisticsPanel.Controls.OfType<StatisticsControl>().FirstOrDefault();
                statsControl?.RefreshStatistics();
            }
            else
            {
                bookmark.LastReadDate = DateTime.Now;
                Program.context.SaveChanges();
            }
        }

        private void UpdateCurrentPage()
        {
            int currentPage = UserBookDataHelper.GetCurrentPage(_currentUserId, _book.BookID);

            if (currentPage == 0)
            {
                UserBookDataHelper.SetCurrentPage(_currentUserId, _book.BookID, 1);
            }
        }

        private void UpdateContinueReadingButtonText()
        {
            int currentPage = UserBookDataHelper.GetCurrentPage(_currentUserId, _book.BookID);

            if (currentPage > 0)
            {
                continueReadingButton.Text = "Продолжить\nСтраница " + currentPage.ToString();
            }
        }

        private void BookInfoForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                navigationControl.LeftPanelWidth = 500;
                navigationControl.RightPanelWidth = 500;
                bookPanel.Width = 219;
                bookPictureBox.Height = 324;
                _bookmarkX = -310;
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
                bookPanel.Width = 146;
                bookPictureBox.Height = 216;
                _bookmarkX = 54;
            }

            navigationControl.UpdatePanelsWidth();
            DescriptionLabel_TextChanged(descriptionLabel, EventArgs.Empty);
            UpdateBookmarksControlPosition();
        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void BookInfoForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
            UpdateBookmarksControlPosition();
        }

        private void continueRadingButton_Click(object sender, EventArgs e)
        {
            PdfLoader.OpenPdfFile(_book.PdfPath);
            UpdateBookmarkStatus();
            UpdateCurrentPage();
            UpdateContinueReadingButtonText();
        }

        private void newBookmarkButton_Click(object sender, EventArgs e)
        {
            if (bookmarksControl != null && bookmarksControl.Visible)
            {
                RemoveBookmarksControl();
                return;
            }

            bookmarksControl = new BookmarksControl(_book, _currentUserId);
            bookmarksControl.CategorySelected += BookmarksControl_CategorySelected;
            bookmarksControl.BookmarkRemoved += BookmarksControl_BookmarkRemoved;
            UpdateBookmarksControlPosition();

            mainPanel.Controls.Add(bookmarksControl);
            bookmarksControl.BringToFront();
            bookmarksControl.Visible = true;

            bookmarksControl.LoadBookmarkStatus();
        }

        private void BookmarksControl_CategorySelected(object sender, CategorySelectedEventArgs e)
        {
            newBookmarkButton.Text = e.CategoryName;

            var statsControl = statisticsPanel.Controls.OfType<StatisticsControl>().FirstOrDefault();
            statsControl?.RefreshStatistics();
        }

        private void BookmarksControl_BookmarkRemoved(object sender, EventArgs e)
        {
            continueReadingButton.Text = "Читать";

            newBookmarkButton.Text = "В закладки";

            var statsControl = statisticsPanel.Controls.OfType<StatisticsControl>().FirstOrDefault();
            statsControl?.RefreshStatistics();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EvaluationForm form = new EvaluationForm(_book, _currentUserId);
            form.ShowDialog();
        }
    }
}