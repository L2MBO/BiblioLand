using Biblio.AppForms.UserForms;
using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookmarksForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;
        private string _currentSortMode = "reading";

        public BookmarksForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            UpdateButtonsCount();
            SetActiveButton(readingButton);
            ShowBookmarks();
        }

        private Dictionary<int, int> GetBookCountsByCategory()
        {
            return Program.context.UserBookmarks
                .Where(user => user.UserID == _currentUserId)
                .GroupBy(b => b.CategoryID)
                .ToDictionary(
                    g => g.Key ?? 0,
                    g => g.Count()
                );
        }

        private void UpdateButtonsCount()
        {
            var counts = GetBookCountsByCategory();

            counts.TryGetValue(2, out int readingCount);
            counts.TryGetValue(3, out int willReadingCount);
            counts.TryGetValue(1, out int wasReadCount);
            counts.TryGetValue(5, out int abandonedCount);
            counts.TryGetValue(4, out int postponedCount);

            readingButton.Text = $"Читаю {readingCount}";
            willReadingButton.Text = $"Буду читать {willReadingCount}";
            wasReadButton.Text = $"Прочитано {wasReadCount}";
            abandonedButton.Text = $"Брошено {abandonedCount}";
            postponedButton.Text = $"Отложено {postponedCount}";
        }

        private void SetActiveButton(Guna2Button activeButton)
        {
            foreach (var control in buttonPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    if (button == activeButton)
                    {
                        button.FillColor = Color.FromArgb(60, 132, 246);
                        button.PressedColor = Color.FromArgb(56, 120, 224);
                    }
                    else
                    {
                        button.FillColor = Color.FromArgb(26, 27, 30);
                        button.PressedColor = Color.FromArgb(38, 39, 43);
                    }
                }
            }
        }

        private void ShowBookmarks(Func<IQueryable<UserBookmarks>, IQueryable<int?>> filterFunction = null)
        {
            bookmarksPanel.Controls.Clear();

            var userBookmarksQuery = Program.context.UserBookmarks.Where(user => user.UserID == _currentUserId);

            IQueryable<int?> bookIdsQuery = filterFunction != null ? filterFunction(userBookmarksQuery) : userBookmarksQuery
                .Where(b => b.CategoryID == 2)
                .Select(b => b.BookID);

            List<Books> books = Program.context.Books.Where(book => bookIdsQuery.Contains(book.BookID)).ToList();

            foreach (Books book in books)
            {
                var userBookmarksControl = new MainControl(book, checkBookmarks: false);
                userBookmarksControl.Margin = new Padding(10);
                userBookmarksControl.BookClicked += BookControl_BookClicked;
                bookmarksPanel.Controls.Add(userBookmarksControl);
            }
        }

        private void ShowReadingBookmarks()
        {
            ShowBookmarks(query => query.Where(b => b.CategoryID == 2).Select(b => b.BookID));
        }

        private void ShowWillReadingBookmarks()
        {
            ShowBookmarks(query => query.Where(b => b.CategoryID == 3).Select(b => b.BookID));
        }

        private void ShowWasReadBookmarks()
        {
            ShowBookmarks(query => query.Where(b => b.CategoryID == 1).Select(b => b.BookID));
        }

        private void ShowAbandonedBookmarks()
        {
            ShowBookmarks(query => query.Where(b => b.CategoryID == 5).Select(b => b.BookID));
        }

        private void ShowPostponedBookmarks()
        {
            ShowBookmarks(query => query.Where(b => b.CategoryID == 4).Select(b => b.BookID));
        }

        private void readingButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "reading") return;
            SetActiveButton(readingButton);
            _currentSortMode = "reading";
            ShowReadingBookmarks();
        }

        private void willReadingButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "willReading") return;
            SetActiveButton(willReadingButton);
            _currentSortMode = "willReading";
            ShowWillReadingBookmarks();
        }

        private void wasReadButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "wasRead") return;
            SetActiveButton(wasReadButton);
            _currentSortMode = "wasRead";
            ShowWasReadBookmarks();
        }

        private void abandonedButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "abandoned") return;
            SetActiveButton(abandonedButton);
            _currentSortMode = "abandoned";
            ShowAbandonedBookmarks();
        }

        private void postponedButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "postponed") return;
            SetActiveButton(postponedButton);
            _currentSortMode = "postponed";
            ShowPostponedBookmarks();
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            this.Hide();

            var loadingForm = new LoadingForm();
            loadingForm.TopMost = true;
            VisibilityHelper.ShowNewForm(this, loadingForm);

            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            while (stopwatch.ElapsedMilliseconds < 1000)
            {
                Application.DoEvents(); // даёт форме рендериться
                System.Threading.Thread.Sleep(10); // снижаем нагрузку
            }
            stopwatch.Stop();

            loadingForm.Close();
            loadingForm.Dispose();
        }

        private void BookmarksForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
