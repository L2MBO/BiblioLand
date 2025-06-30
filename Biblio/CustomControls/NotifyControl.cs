using Biblio.AppForms.UserForms;
using Biblio.Classes.Customization.FormCustomization;
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
        public bool IsChecked => deleteCheckBox.Checked;
        public object NotificationData => _notificationData;

        public NotifyControl(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            if (_notificationData is SystemNotifications systemNotification)
            {
                nameLabel.Text = systemNotification.NotifyTitle;
                typeLabel.Text = "Системное уведомление";
                dateLabel.Text = systemNotification.NotifyDate.ToShortDateString();
            }
            else if (_notificationData is BookReports bookReport)
            {
                nameLabel.Text = $"Отправил {bookReport.Users.Username}";
                typeLabel.Text = $"Жалоба на книгу";
                dateLabel.Text = bookReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is ReviewReports reviewReport)
            {
                nameLabel.Text = $"Отправил {reviewReport.Users.Username}";
                typeLabel.Text = $"Жалоба на комментарий";
                dateLabel.Text = reviewReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is UserReports userReport)
            {
                nameLabel.Text = $"Отправил {userReport.Users.Username}";
                typeLabel.Text = $"Жалоба на пользователя";
                dateLabel.Text = userReport.ReportDate.ToShortDateString();
            }
            else if (_notificationData is Feedback feedback)
            {
                nameLabel.Text = $"Отправил {feedback.Users.Username}";
                typeLabel.Text = feedback.FeedbackCategory.FeedbackCategoryName;
                dateLabel.Text = feedback.FeedbackDate.ToShortDateString();
            }
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
            var form = new ShowNotify(_notificationData);
            _dialogService.ShowDialogWithOverlay(this.FindForm(), form);
        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
