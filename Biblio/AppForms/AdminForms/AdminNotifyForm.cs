using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class AdminNotifyForm : Form
    {
        private object _notificationData;

        public AdminNotifyForm(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            //if (_notificationData is SystemNotifications systemNotification)
            //{
            //    titleLabel.Text = systemNotification.NotifyTitle;
            //    typeLabel.Text = "Системное уведомление";
            //    dateLabel.Text = systemNotification.NotifyDate.ToShortDateString();
            //}
            //else if (_notificationData is BookReports bookReport)
            //{
            //    titleLabel.Text = "Жалоба на книгу";
            //    nameLabel.Text = $"Отправил {bookReport.Users.Username}";

            //    dateLabel.Text = bookReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is ReviewReports reviewReport)
            //{
            //    nameLabel.Text = $"Отправил {reviewReport.Users.Username}";
            //    titleLabel.Text = "Жалоба на комментарий";
            //    dateLabel.Text = reviewReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is UserReports userReport)
            //{
            //    nameLabel.Text = $"Отправил {userReport.Users.Username}";
            //    titleLabel.Text = "Жалоба на пользователя";
            //    dateLabel.Text = userReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is Feedback feedback)
            //{
            //    nameLabel.Text = $"Отправил {feedback.Users.Username}";
            //    titleLabel.Text = feedback.FeedbackCategory.FeedbackCategoryName;
            //    dateLabel.Text = feedback.FeedbackDate.ToShortDateString();
            //}
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void reportLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
