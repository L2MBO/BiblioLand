using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Classes.Validation;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
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

        private void ShowBookmarks(/*Books books*/)
        {
            bookmarksPanel.Controls.Clear();

            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 1).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var userBookmarksControl = new MainControl(book);
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

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);
            this.Hide();
        }

        private void ProfileForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            CheckProfileOwner();
        }
    }
}
