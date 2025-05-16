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

namespace Biblio.AppForms
{
    public partial class MainForm : MaterialForm
    {
        private AddContentControl addContentControl;
        public event EventHandler WindowStateChanged;

        public MainForm()
        {
            InitializeComponent();

            AutoScrollHelper.ConfigureScrollbars(mainBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(newBooksPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(continueReadingPanel, disableHorizontal: true, disableVertical: false);
            AutoScrollHelper.ConfigureScrollbars(popularBooksPanel, disableHorizontal: true, disableVertical: false);

            navigationPanel.MouseDown += Form_MouseDown;
            topLeftPanel.MouseDown += Form_MouseDown;
            topRightPanel.MouseDown += Form_MouseDown;
            topNavigationPanel.MouseDown += Form_MouseDown;
            bottomNavigationPanel.MouseDown += Form_MouseDown;
            this.Resize += MainForm_Resize;

            this.Shown += MainForm_Shown;

            showMoreButton.Click += showMoreButton_Click;
            glasPanel.Click += searchPanel_Click;
            searchLabel.Click += searchPanel_Click;
            glasPictureBox.Click += searchPanel_Click;
            bookmarksPanel.Click += bookmarksPictureBox_Click;
            notifyPanel.Click += notifyPictureBox_Click;

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
                lastUpdatesPanel.Controls.Add(bookControl);
            }

            showMoreButton.Visible = (_displayedBooksCount < books.Count);
        }

        private int otherX;

        private OtherControl otherControl;

        private void otherButton_Click(object sender, EventArgs e)
        {
            if (otherControl != null && otherControl.Visible)
            {
                otherControl.Visible = false;
                otherControl.Dispose();
                otherControl = null;
                return;
            }

            otherControl = new OtherControl();

            otherControl.OpenChanged += OtherControl_OpenChanged;

            int x = otherButton.Left + otherX;
            int y = otherButton.Bottom + 10;

            otherControl.Location = new Point(x, y);

            this.Controls.Add(otherControl);
            otherControl.BringToFront();
            otherControl.Visible = true;
        }

        private SearchControl searchControl;

        private void searchPanel_Click(object sender, EventArgs e)
        {
            if (searchControl != null && searchControl.Visible)
            {
                searchControl.Visible = false;
                searchControl.Dispose();
                searchControl = null;
                return;
            }

            searchControl = new SearchControl();

            searchControl.OpenChanged += SearchControl_OpenChanged;

            int centerX = this.ClientSize.Width / 2;
            int controlWidth = searchControl.Width;

            int x = centerX - controlWidth / 2;
            int y = searchPanel.Bottom + 10;

            searchControl.Location = new Point(x, y);

            this.Controls.Add(searchControl);
            searchControl.BringToFront();
            searchControl.Visible = true;

            searchControl.BeginInvoke(new Action(() => SetSearchControlPosition()));
        }

        private int avatarX;

        private AvatarControl avatarControl;

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            if (avatarControl != null && avatarControl.Visible)
            {
                avatarControl.Visible = false;
                avatarControl.Dispose();
                avatarControl = null;
                return;
            }

            avatarControl = new AvatarControl(this);

            avatarControl.OpenChanged += AvatarControl_OpenChanged;

            this.Controls.Add(avatarControl);
            avatarControl.BringToFront();
            avatarControl.Visible = true;

            SetSearchControlPosition();
        }

        private void OtherControl_OpenChanged(object sender, EventArgs e)
        {
            if (otherControl.IsOpen)
            {
                this.Hide();
            }
        }

        private void SearchControl_OpenChanged(object sender, EventArgs e)
        {
            if (searchControl.IsOpen)
            {
                this.Hide();
            }
        }

        private void AvatarControl_OpenChanged(object sender, EventArgs e)
        {
            if (avatarControl.IsOpen)
            {
                this.Hide();
            }
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            bookInfoForm.ShowDialog();
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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            foreach (Control control in lastUpdatesPanel.Controls)
            {
                if (control is LastUpdatesControl lastUpdatesControl)
                {
                    lastUpdatesControl.ChangeWidth();
                }
            }
        }

        private static bool _isMaximize = false;

        public static event EventHandler IsMaximizeChanged;

        public static bool isMaximize
        {
            get { return _isMaximize; }
            set
            {
                if (_isMaximize != value)
                {
                    _isMaximize = value;
                    OnIsMaximizeChanged();
                }
            }
        }

        protected static void OnIsMaximizeChanged()
        {
            IsMaximizeChanged?.Invoke(null, EventArgs.Empty);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                OnWindowStateChanged();
            }
            else
            {
                OnWindowStateChanged();
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                CustomizationHelper.SetRoundedRegion(this, 0, 0);
                maximizeButton.Visible = false;
                restoreButton.Visible = true;
                leftPanel.Width = 300;
                rightPanel.Width = 300;
                topLeftPanel.Width = 300;
                panel2.Width = 300;
                searchPanel.Width = 300;
                searchLabel.Text = "Что ищем, читатель?";
                otherX = 300;
                avatarX = 1015;
                isMaximize = true;
            }
            else
            {
                CustomizationHelper.SetRoundedRegion(this, 11, 11);
                maximizeButton.Visible = true;
                restoreButton.Visible = false;
                leftPanel.Width = 100;
                rightPanel.Width = 100;
                topLeftPanel.Width = 100;
                panel2.Width = 100;
                searchPanel.Width = 130;
                searchLabel.Text = "Что ищем?";
                otherX = 100;
                avatarX = 160;
                isMaximize = false;
            }

            if (otherControl != null && otherControl.Visible)
            {
                int x = otherButton.Left + otherX;
                int y = otherButton.Bottom + 10;
                otherControl.Location = new Point(x, y);
            }

            if (searchControl != null && searchControl.Visible)
            {
                SetSearchControlPosition();
            }

            if (avatarControl != null && avatarControl.Visible)
            {
                int x = avatarPictureBox.Right + avatarX;
                int y = avatarPictureBox.Bottom + 10;
                avatarControl.Location = new Point(x, y);
            }
        }

        private void SetSearchControlPosition()
        {
            if (searchControl == null || !searchControl.Visible) return;

            int centerX = this.ClientSize.Width / 2;
            int controlWidth = searchControl.Width;

            int x = (centerX - controlWidth / 2) + 3;
            int y = searchPanel.Bottom + 10;

            searchControl.Location = new Point(x, y);
        }

        private void bookmarksPictureBox_Click(object sender, EventArgs e)
        {
            BookmarksForm form = new BookmarksForm();
            form.ShowDialog();
            //BookmarksForm form = new BookmarksForm();
            //form.Owner = this;
            //this.Hide();
            //form.Show();
        }

        private void notifyPictureBox_Click(object sender, EventArgs e)
        {
            UserNotifyForm form = new UserNotifyForm();
            form.ShowDialog();
            //UserNotifyForm form = new UserNotifyForm();
            //form.Owner = this;
            //this.Hide();
            //form.Show();
        }

        protected virtual void OnWindowStateChanged()
        {
            WindowStateChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            _displayedBooksCount += 5;
            ShowLastUpdates();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            BookСatalogForm form = new BookСatalogForm();
            form.ShowDialog();
            //BookСatalogForm form = new BookСatalogForm();
            //form.Owner = this;
            //this.Hide();
            //form.Show();
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            TopForm form = new TopForm();
            form.ShowDialog();
            //TopForm form = new TopForm();
            //form.Owner = this;
            //this.Hide();
            //form.Show();
        }
    }
}