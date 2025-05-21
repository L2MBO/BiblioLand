using Biblio.Classes.Animations;
using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Biblio.ValidationClasses;
using Biblio.Classes.Validation;
using System.IO;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Coding;
using Biblio.Classes.Images.InstallingImages;
using Org.BouncyCastle.Asn1.X509;
using Biblio.Interface;

namespace Biblio.AppForms
{
    public partial class MainForm : MaterialForm, IAvatarParentForm
    {
        private AddContentControl addContentControl;
        public event EventHandler WindowStateChanged;
        private BookSearchControl bookSearchControl;

        public MainForm()
        {
            InitializeComponent();

            AutoScrollHelper.ConfigureScrollbars(mainBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(newBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(continueReadingPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(popularBooksPanel, disableHorizontal: true, disableVertical: false);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            bookSearchControl = new BookSearchControl(this, new Books
            {
                Author = "",
                Title = "",
                ImagePath = ""
            });

            addContentControl = new AddContentControl();
        }

        
        private void ShowMainBooks()
        {
            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 1).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var bookControl = new MainControl(book);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                bookControl.OpenChanged += OnControlOpenChanged;
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
                bookControl.OpenChanged += OnControlOpenChanged;
                newBooksPanel.Controls.Add(bookControl);
            }
        }

        private void ShowContinueReadingBooks()
        {
            try
            {
                int currentUserId = Program.CurrentUser.UserID;

                var books = Program.context.UserBooks
                    .Where(category => category.UserID == currentUserId && category.CategoryID == 2)
                    .Select(category => category.BookID)
                    .ToList();

                List<Books> filteredBooks = Program.context.Books
                    .Where(book => books.Contains(book.BookID))
                    .OrderByDescending(book => book.AddedDate)
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
                    int currentPage = UserBookDataHelper.GetCurrentPage(currentUserId, book.BookID);

                    if (currentPage == 0)
                    {
                        UserBookDataHelper.SetCurrentPage(currentUserId, book.BookID, 1);
                    }

                    var bookControl = new ContinueReadingControl(book, currentUserId);
                    bookControl.Margin = new Padding(10);
                    bookControl.BookClicked += BookControl_BookClicked;
                    bookControl.OpenChanged += OnControlOpenChanged;
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
            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 3).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var bookControl = new MainControl(book);
                bookControl.Margin = new Padding(10);
                bookControl.BookClicked += BookControl_BookClicked;
                bookControl.OpenChanged += OnControlOpenChanged;
                popularBooksPanel.Controls.Add(bookControl);
            }
        }

        private int _displayedBooksCount = 5;

        private void ShowLastUpdates()
        {
            DateTime now = DateTime.Now;
            var books = Program.context.Books.Where(addDate => addDate.AddedDate != null).OrderByDescending(date => date.AddedDate).ToList();
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
                bookControl.OpenChanged += OnControlOpenChanged;
                lastUpdatesPanel.Controls.Add(bookControl);
            }

            showMoreButton.Visible = (_displayedBooksCount < books.Count);
        }

        public void OnControlOpenChanged(object sender, EventArgs e)
        {
            if (sender is Control control && control.Visible)
            {
                this.Hide();
            }
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            bookInfoForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowMainBooks();
            ShowNewBooks();
            ShowContinueReadingBooks();
            ShowPopularBooks();
            ShowLastUpdates();
            //ImageLoader.LoadAvatarImage(avatarPictureBox);
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            _displayedBooksCount += 5;
            ShowLastUpdates();
        }
    }
}