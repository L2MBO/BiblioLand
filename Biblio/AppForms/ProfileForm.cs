using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Classes.Validation;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace Biblio.AppForms
{
    public partial class ProfileForm : Form
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private int _currentUserId;
        private Users _currentUser;
        private string _currentSortMode = "reading";
        private bool _isUserAdmin = false;

        public ProfileForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            ImageLoader.LoadAvatarImageFromUserID(_currentUserId, avatarPictureBox);

            userNameLabel.Text = _currentUser.Username;

            SetStatisticsCount();
            SetActiveButton(readingButton);
            ShowBookmarks();
            ChangeSettingsButtonImage();
            CheckUserRole();
        }

        private void SetStatisticsCount()
        {
            var likesCount = Program.context.Likes.Where(user => user.UserID == _currentUserId).Count();
            var commentsCount = Program.context.Reviews.Where(user => user.UserID == _currentUserId).Count();
            var registrationDate = _currentUser.RegistrationDate;

            likesCountLabel.Text = likesCount.ToString();
            commentsCountLabel.Text = commentsCount.ToString();
            registrationDateLabel.Text = registrationDate?.ToShortDateString() ?? DateTime.Now.ToString();
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

        private void CheckWindowState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                buttonPanel.Width = 505;
                UpdateButtonsCount();
            }
            else
            {
                buttonPanel.Width = 260;
                readingButton.Text = "";
                readingButton.Image = Properties.Resources.reading;
                willReadingButton.Text = "";
                willReadingButton.Image = Properties.Resources.willReading;
                wasReadButton.Text = "";
                wasReadButton.Image = Properties.Resources.wasRead;
                abandonedButton.Text = "";
                abandonedButton.Image = Properties.Resources.abandoned;
                postponedButton.Text = "";
                postponedButton.Image = Properties.Resources.postponed;
            }
        }

        private void UpdateButtonsCount()
        {
            var counts = GetBookCountsByCategory();

            counts.TryGetValue(2, out int readingCount);
            counts.TryGetValue(3, out int willReadingCount);
            counts.TryGetValue(1, out int wasReadCount);
            counts.TryGetValue(5, out int abandonedCount);
            counts.TryGetValue(4, out int postponedCount);

            readingButton.Image = null;
            readingButton.Text = $"Читаю {readingCount}";
            willReadingButton.Image = null;
            willReadingButton.Text = $"Буду читать {willReadingCount}";
            wasReadButton.Image = null;
            wasReadButton.Text = $"Прочитано {wasReadCount}";
            abandonedButton.Image = null;
            abandonedButton.Text = $"Брошено {abandonedCount}";
            postponedButton.Image = null;
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

        private void ChangeSettingsButtonImage()
        {
            if (_currentUserId != Program.CurrentUser.UserID)
            {
                settingsButton.Image = Properties.Resources.report;
            }
            else
            {
                settingsButton.Image = Properties.Resources.gear;
            }
        }

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == Program.CurrentUser.UserID && user.UserRoleID == 2);

            if (_currentUser != null)
            {
                _isUserAdmin = true;
            }
        }

        private void CheckProfileOwner()
        {
            if (_currentUserId != Program.CurrentUser.UserID)
            {
                if (_isUserAdmin)
                {
                    var form = new UserBanForm(_currentUserId);
                    _dialogService.ShowDialogWithOverlay(this, form);
                }
                else
                {
                    var form = new UserReportForm(_currentUserId);
                    _dialogService.ShowDialogWithOverlay(this, form);
                }
            }
            else
            {
                SettingsForm form = new SettingsForm();
                VisibilityHelper.ShowNewForm(this, form);
                this.Hide();
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
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);
            this.Hide();
        }

        private void ProfileForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
            CheckWindowState();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            CheckProfileOwner();
        }
    }
}
