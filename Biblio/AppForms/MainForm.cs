using Biblio.Classes.Customization;
using Biblio.Classes.Validation;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class MainForm : MaterialForm
    {
        private AddContentControl addContentControl;
        #pragma warning disable CS0067
        public event EventHandler WindowStateChanged;
        #pragma warning restore CS0067
        private BookSearchControl bookSearchControl;

        public MainForm()
        {
            InitializeComponent();

            SetFormStyle();

            addContentControl = new AddContentControl();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(newBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(continueReadingPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(popularBooksPanel, disableHorizontal: true, disableVertical: false);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
            WindowStateChanged += (sender, e) => { };
            bookSearchControl = new BookSearchControl(this, new Books
            {
                Author = "",
                Title = "",
                ImagePath = ""
            });
        }

        private void ShowMainBooks()
        {
            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 1).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var bookControl = new MainControl(book);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                mainBooksPanel.Controls.Add(bookControl);
            }
        }

        private void ShowNewBooks()
        {
            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 2).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var bookControl = new MainControl(book);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                newBooksPanel.Controls.Add(bookControl);
            }
        }

        private void ShowContinueReadingBooks()
        {
            try
            {
                int currentUserId = Program.CurrentUser.UserID;

                var userBooksWithDates = Program.context.UserBookmarks
                    .Where(book => book.UserID == currentUserId && book.CurrentPage >= 1)
                    .Select(book => new
                    {
                        BookID = book.BookID,
                        LastReadDate = book.LastReadDate
                    })
                    .ToList();

                var bookIds = userBooksWithDates.Select(b => b.BookID).ToList();

                List<Books> filteredBooks = Program.context.Books
                    .Where(book => bookIds.Contains(book.BookID))
                    .AsEnumerable()
                    .OrderByDescending(book =>
                        userBooksWithDates.FirstOrDefault(ub => ub.BookID == book.BookID)?.LastReadDate)
                    .ToList();

                continueReadingPanel.Controls.Clear();

                if (filteredBooks.Count == 0)
                {
                    continueReadingLabelAndControlPanel.Visible = false;
                    return;
                }

                continueReadingLabelAndControlPanel.Visible = true;

                foreach (Books book in filteredBooks)
                {
                    var bookControl = new ContinueReadingControl(book, currentUserId);
                    bookControl.Margin = new Padding(10);
                    bookControl.BookClicked += BookControl_BookClicked;
                    continueReadingPanel.Controls.Add(bookControl);
                }
            }
            catch (Exception ex)
            {
                string logPath = "errorContinueReadingControl_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при отображении контрола, пользователь еще не читал ни одной книги: {ex.Message}\n");

                continueReadingLabelAndControlPanel.Visible = false;
            }
        }

        private void ShowPopularBooks()
        {
            List<Books> books = Program.context.Books
                .Where(category => category.CategoryID == 3)
                .OrderBy(name => name.Title)
                .ToList();
            foreach (Books book in books)
            {
                var bookControl = new MainControl(book);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                popularBooksPanel.Controls.Add(bookControl);
            }
        }

        private int _displayedBooksCount = 5;

        private void ShowLastUpdates()
        {
            DateTime now = DateTime.Now;
            var books = Program.context.Books
                .Where(addDate => addDate.AddedDate != null)
                .OrderByDescending(date => date.AddedDate)
                .ToList();
            int booksToShow = Math.Min(_displayedBooksCount, books.Count);

            while (lastUpdatesPanel.Controls.Count > booksToShow)
            {
                lastUpdatesPanel.Controls.RemoveAt(lastUpdatesPanel.Controls.Count - 1);
            }

            for (int i = lastUpdatesPanel.Controls.Count; i < booksToShow; i++)
            {
                var book = books[i];
                if (book.AddedDate == null)
                {
                    continue;
                }

                var bookControl = new LastUpdatesControl(book);
                TimeSpan timeDifference = (TimeSpan)(now - book.AddedDate);
                string timeAgo = TimeValidation.FormatTimeAgo(timeDifference);
                bookControl.SetTime(timeAgo);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                lastUpdatesPanel.Controls.Add(bookControl);
            }

            showMoreButton.Visible = (_displayedBooksCount < books.Count);
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowMainBooks();
            ShowNewBooks();
            ShowContinueReadingBooks();
            ShowPopularBooks();
            ShowLastUpdates();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            _displayedBooksCount += 5;
            ShowLastUpdates();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}