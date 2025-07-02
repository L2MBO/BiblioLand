using Biblio.AppForms;
using Biblio.AppForms.AdminForms;
using Biblio.AppForms.UserForms;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class NotifyControl : UserControl
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        public event EventHandler CheckChanged;
        private object _notificationData;
        private int _currentUser;
        Form _form;
        public bool IsChecked => deleteCheckBox.Checked;
        public object NotificationData => _notificationData;

        public NotifyControl(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void DefaultStyle()
        {
            nameLabel.Visible = true;
            titleLabel.Text = "Отправил:";
            titleLabel.Width = 85;
        }

        private void NewStyle()
        {
            nameLabel.Visible = false;
            titleLabel.Width = 194;
        }

        private void LoadNotifyInfo()
        {
            DefaultStyle();

            if (_notificationData is SystemNotifications systemNotification)
            {
                NewStyle();
                titleLabel.Text = systemNotification.NotifyTitle;
                typeLabel.Text = "Системное уведомление";
                dateLabel.Text = systemNotification.NotifyDate.ToShortDateString();
                _form = new UserNotifyForm(systemNotification);
                return;
            }
            else if (_notificationData is BookReports bookReport)
            {
                _currentUser = bookReport.Users.UserID;
                nameLabel.Text = bookReport.Users.Username;
                typeLabel.Text = "Жалоба на книгу";
                dateLabel.Text = bookReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is ReviewReports reviewReport)
            {
                _currentUser = reviewReport.Users.UserID;
                nameLabel.Text = reviewReport.Users.Username;
                typeLabel.Text = "Жалоба на комментарий";
                dateLabel.Text = reviewReport.ReportDate.ToShortDateString();
                _form = new CommentNotifyForm(reviewReport);
                return;
            }
            else if (_notificationData is UserReports userReport)
            {
                _currentUser = userReport.Users.UserID;
                nameLabel.Text = userReport.Users.Username;
                typeLabel.Text = "Жалоба на пользователя";
                dateLabel.Text = userReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is Feedback feedback)
            {
                _currentUser = feedback.Users.UserID;
                nameLabel.Text = feedback.Users.Username;
                typeLabel.Text = feedback.FeedbackCategory.FeedbackCategoryName;
                dateLabel.Text = feedback.FeedbackDate.ToShortDateString();
                _form = new FeedbackNotifyForm(feedback);
                return;
            }

            _form = new AdminNotifyForm(_notificationData);
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
            if (_form is CommentNotifyForm commentForm)
            {
                commentForm.CommentDeleted += () =>
                {
                    if (this.FindForm() is NotifyForm notifyForm)
                    {
                        notifyForm.RefreshNotifications();
                    }
                };
            }

            _dialogService.ShowDialogWithOverlay(this.FindForm(), _form);
            deleteCheckBox.Checked = true;
        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged?.Invoke(this, EventArgs.Empty);
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(_currentUser, true, this.FindForm());
            VisibilityHelper.ShowNewForm(this.FindForm(), profileForm);
            this.FindForm().Hide();
        }
    }
}
