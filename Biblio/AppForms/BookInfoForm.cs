using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Customization.ImagesCustomization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Classes.Pdf.OpenPdf;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Biblio.AppForms
{
    public partial class BookInfoForm : Form
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private Books _book;
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isUserAdmin = false;
        private int _bookmarkX;
        private BackgroundImageRenderer backgroundImageRenderer;

        public BookInfoForm(Books book)
        {
            InitializeComponent();

            _book = book;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            descriptionLabel.TextChanged += DescriptionLabel_TextChanged;

            backgroundImageRenderer = new BackgroundImageRenderer();

            LoadBookInfo();

            CheckUserRole();

            UpdateBookmarksControlPosition();

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

            Image bookimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (bookimage != null)
            {
                bookPictureBox.Image = bookimage;
            }

            Image backimage = ImageLoader.LoadBookImage(_book.ImagePath);

            if (backimage != null)
            {
                var bitmap = backimage as Bitmap ?? new Bitmap(backimage);
                Image preparedBackground = WhiteLevelReducer.PrepareBackground(bitmap, 15, 0.6f);
                backgroundImageRenderer.SetBackgroundImage(preparedBackground);
            }

            descriptionLabel.Text = _book.Description;

            ShowStatisticsBooks();
            UpdateBookmarkButtonText();
            UpdateContinueReadingButtonText();
            UpdateEvaluateButtonText();
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
            _book = Program.context.Books.AsNoTracking().FirstOrDefault(b => b.BookID == _book.BookID);

            var rating = (double)_book.AverageRating;

            ratingLabel.Text = (rating).ToString("F1", CultureInfo.InvariantCulture);

            var ratingCount = Program.context.Rating.Count(r => r.BookID == _book.BookID).ToString();

            ratingCountLabel.Text = ratingCount + " голосов";

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

        private void UpdateReadingStatus()
        {
            var currentBook = Program.context.UserBookmarks.FirstOrDefault(book => book.UserID == _currentUserId && book.BookID == _book.BookID);

            if (currentBook.IsReading != 1)
            {
                currentBook.IsReading = 1;
                Program.context.SaveChanges();
            }
        }

        private void UpdateContinueReadingButtonText()
        {
            var currentBook = Program.context.UserBookmarks.FirstOrDefault(book => book.UserID == _currentUserId && book.BookID == _book.BookID);

            if (currentBook != null && currentBook.IsReading == 1)
            {
                continueReadingButton.Text = "Продолжить\nчтение";
            }
        }

        private void UpdateEvaluateButtonText()
        {
            var existingRating = Program.context.Rating.FirstOrDefault(r =>
                r.UserID == _currentUserId && r.BookID == _book.BookID);

            if (existingRating != null)
            {
                evaluateButton.Text = $"Оценка: {existingRating.Rating1}";
            }
            else
            {
                evaluateButton.Text = "Оценить";
            }
        }

        private void UpdateEvaluationForm()
        {
            var statsControl = statisticsPanel.Controls.OfType<StatisticsControl>().FirstOrDefault();
            statsControl?.RefreshStatistics();
        }

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            if (_currentUser != null)
            {
                reportButton.Image = null;
                reportButton.Text = "Удалить";
                _isUserAdmin = true;
            }
        }

        private void DeleteBook()
        {
            var bookToRemove = Program.context.Books.Find(_book.BookID);

            if (bookToRemove != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту книгу?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Program.context.Books.Remove(bookToRemove);
                        Program.context.SaveChanges();

                        ValidationHelper.ShowInformationMessage("Книга успешно удалена", "Успех");

                        var mainform = new MainForm();
                        VisibilityHelper.ShowNewForm(this, mainform);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        ValidationHelper.ShowErrorMessage("Произошла ошибка при удалении книги: " + ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                ValidationHelper.ShowErrorMessage("Книга не найдена в базе данных.");
            }
        }

        private void BookInfoForm_Shown(object sender, EventArgs e)
        {
            BookInfoForm_SizeChanged(sender, e);
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

        private void mainPanel_Scroll(object sender, ScrollEventArgs e)
        {
            mainPanel.Invalidate();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (backgroundImageRenderer != null)
            {
                int scrollY = -mainPanel.AutoScrollPosition.Y;

                backgroundImageRenderer.DrawBackgroundImage(e.Graphics, mainPanel.Width, mainPanel.Height, scrollY);
            }
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
            UpdateReadingStatus();
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

            UpdateEvaluationForm();
        }

        private void BookmarksControl_BookmarkRemoved(object sender, EventArgs e)
        {
            continueReadingButton.Text = "Читать";

            newBookmarkButton.Text = "В закладки";

            UpdateEvaluationForm();
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            var form = new EvaluationForm(_book, _currentUserId, evaluateButton);
            _dialogService.ShowDialogWithOverlay(this, form);

            ShowRating();

            UpdateEvaluationForm();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (_isUserAdmin)
            {
                DeleteBook();
            }
            else
            {
                var form = new BookReportForm(_book, _currentUserId);
                _dialogService.ShowDialogWithOverlay(this, form);
            }
        }
    }
}