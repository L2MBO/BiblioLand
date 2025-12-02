using Biblio.AppForms;
using Biblio.AppForms.AdminForms;
using Biblio.AppForms.UserForms;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Linq;
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
                var newBookReport = Program.context.SystemNotifications.AsNoTracking()
                    .FirstOrDefault(n => n.NotifyID == systemNotification.NotifyID);
                titleLabel.Text = systemNotification.NotifyTitle;
                typeLabel.Text = "Системное уведомление";
                dateLabel.Text = systemNotification.NotifyDate.ToShortDateString();
                _form = new UserNotifyForm(systemNotification);
                return;
            }
            else if (_notificationData is BookReports bookReport)
            {
                var newBookReport = Program.context.BookReports.AsNoTracking().FirstOrDefault(b => b.BookReportID == bookReport.BookReportID);
                _currentUser = newBookReport.Users.UserID;
                nameLabel.Text = newBookReport.Users.Username;
                typeLabel.Text = "Жалоба на книгу";
                dateLabel.Text = newBookReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is ReviewReports reviewReport)
            {
                var newReviewReport = Program.context.ReviewReports.AsNoTracking().FirstOrDefault(r => r.ReviewReportID == reviewReport.ReviewReportID);
                _currentUser = newReviewReport.Users.UserID;
                nameLabel.Text = newReviewReport.Users.Username;
                typeLabel.Text = "Жалоба на комментарий";
                dateLabel.Text = newReviewReport.ReportDate.ToShortDateString();
                _form = new CommentNotifyForm(newReviewReport);
                return;
            }
            else if (_notificationData is UserReports userReport)
            {
                var newUserReport = Program.context.UserReports.AsNoTracking().FirstOrDefault(u => u.UserReportID == userReport.UserReportID);
                _currentUser = newUserReport.Users.UserID;
                nameLabel.Text = newUserReport.Users.Username;
                typeLabel.Text = "Жалоба на пользователя";
                dateLabel.Text = newUserReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is Feedback feedback)
            {
                var newFeedback = Program.context.Feedback.AsNoTracking().FirstOrDefault(f => f.FeedbackID == feedback.FeedbackID);
                _currentUser = newFeedback.Users.UserID;
                nameLabel.Text = newFeedback.Users.Username;
                typeLabel.Text = newFeedback.FeedbackCategory.FeedbackCategoryName;
                dateLabel.Text = newFeedback.FeedbackDate.ToShortDateString();
                _form = new FeedbackNotifyForm(newFeedback);
                return;
            }

            _form = new ReportNotifyForm(_notificationData);
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
