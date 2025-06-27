using Biblio.AppForms.AdminForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using Biblio.ValidationClasses;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Biblio.AppForms
{
    public partial class ProfileForm : Form
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private int _currentUserId;
        private bool _needArrow;
        private Form _backForm;
        private Users _currentUser;
        private int _sendReportUserId = Program.CurrentUser.UserID;
        private string _currentSortMode = "reading";

        public ProfileForm(int currentUserId, bool needArrow = false, Form backForm = null)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _needArrow = needArrow;
            _backForm = backForm;
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

            SetStatistics();
            SetActiveButton(readingButton);
            ShowBookmarks();
            ChangeSettingsButtonImage();
            CheckUserRole();
            CheckUserPrivacy();
            ShowBackArrow();
        }

        private void ShowBackArrow()
        {
            if (_needArrow)
            {
                arrowPanel.Visible = true;
            }
        }

        private void SetStatistics()
        {
            var likesCount = Program.context.Likes.Where(user => user.UserID == _currentUserId).Count();
            var commentsCount = Program.context.Reviews.Where(user => user.UserID == _currentUserId).Count();
            var registrationDate = _currentUser.RegistrationDate;
            var description = _currentUser.Description;

            likesCountLabel.Text = likesCount.ToString();
            commentsCountLabel.Text = commentsCount.ToString();
            registrationDateLabel.Text = registrationDate?.ToShortDateString() ?? DateTime.Now.ToString();
            descriptionPanel.Visible = description != null;
            descriptionLabel.Text = description;
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
                anotherLockPanel.Width = 511;
                arrowButton.Width = 124;
                arrowButton.Location = new Point(18, 0);
                arrowButton.Text = "Вернуться назад";
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
                anotherLockPanel.Width = 266;
                arrowButton.Width = 90;
                arrowButton.Location = new Point(3, 0);
                arrowButton.Text = "Вернуться";
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
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == Program.CurrentUser.UserID && user.UserRoleID != 1);

            if (currentUser != null && _currentUserId != Program.CurrentUser.UserID)
            {
                settingsButton.Visible = false;
                ShowBanButtons();
            }
        }

        private void CheckUserPrivacy()
        {
            if (_currentUser.PrivateProfile == 1 && _currentUser.UserID != Program.CurrentUser.UserID)
            {
                bookmarksButtonPanel.Visible = false;
                bookmarksPanel.Visible = false;
                lockPanel.Visible = true;
                lockPanel.BringToFront();
                anotherLockPanel.Visible = true;
                anotherLockPanel.BringToFront();
            }
            else
            {
                bookmarksButtonPanel.Visible = true;
                bookmarksPanel.Visible = true;
                lockPanel.Visible = false;
                anotherLockPanel.Visible = false;
            }
        }

        private void CheckProfileOwner()
        {
            if (_currentUserId != Program.CurrentUser.UserID)
            {
                var form = new ReportForm(null, 0, _currentUserId, _sendReportUserId, "User");
                _dialogService.ShowDialogWithOverlay(this, form);
            }
            else
            {
                SettingsForm form = new SettingsForm();
                VisibilityHelper.ShowNewForm(this, form);
                this.Hide();
            }
        }

        private void ShowBanExpiration()
        {
            var userBan = Program.context.UserBans.FirstOrDefault(user => user.BanedUserID == _currentUserId);
            var banDate = userBan.BanExpiration;
            banExpirationLabel.Text = banDate.ToString("Забанен до: " + "dd.MM.yyyy HH:mm");
        }

        private void ShowBanButtons()
        {
            banButton.Visible = true;

            if (IsUserBaned())
            {
                changeBanPanel.Visible = true;
                banExpirationLabel.Visible = true;
                ShowBanExpiration();
            }
            else
            {
                changeBanPanel.Visible = false;
                banExpirationLabel.Visible = false;
            }
        }

        private bool IsUserBaned()
        {
            return Program.context.UserBans.Any(user => user.BanedUserID == _currentUserId);
        }

        private void UnBanUser()
        {
            try
            {
                var userBan = Program.context.UserBans
                    .FirstOrDefault(user => user.BanedUserID == _currentUserId);

                if (userBan == null)
                {
                    MessageBox.Show("Пользователь не забанен!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.context.UserBans.Remove(userBan);
                Program.context.SaveChanges();

                ShowBanButtons();

                ValidationHelper.ShowInformationMessage("Бан успешно снят!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при снятии бана: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void arrrowButton_Click(object sender, EventArgs e)
        {
            if (_backForm != null)
            {
                _backForm.StartPosition = FormStartPosition.Manual;
                _backForm.Location = this.Location;
                _backForm.WindowState = this.WindowState;
                _backForm.Show();
                this.Close();
            }
            else
            {
                MainForm form = new MainForm();
                VisibilityHelper.ShowNewForm(this.FindForm(), form);
                this.Hide();
            }
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            var form = new UserBanForm(_currentUserId);
            form.BanChanged += ShowBanButtons;
            _dialogService.ShowDialogWithOverlay(this, form);
        }

        private void unBanButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите снять бан у этого пользователя?", 
                "Подтвердите действие!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                UnBanUser();
            }
        }

        private void extendBanButton_Click(object sender, EventArgs e)
        {
            var form = new ExtendBanForm(_currentUserId);
            form.DateChanged += ShowBanExpiration;
            _dialogService.ShowDialogWithOverlay(this, form);
        }
    }
}
