using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblio.AppForms.UserForms
{
    public partial class ShowNotify : Form
    {
        private object _notificationData;

        public ShowNotify(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            //if (_notificationData is SystemNotifications systemNotification)
            //{
            //    nameLabel.Text = systemNotification.NotifyTitle;
            //    typeLabel.Text = "Системное уведомление";
            //    dateLabel.Text = systemNotification.NotifyDate.ToShortDateString();
            //}
            //else if (_notificationData is BookReports bookReport)
            //{
            //    nameLabel.Text = $"Отправил {bookReport.Users.Username}";
            //    typeLabel.Text = $"Жалоба на книгу";
            //    dateLabel.Text = bookReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is ReviewReports reviewReport)
            //{
            //    nameLabel.Text = $"Отправил {reviewReport.Users.Username}";
            //    typeLabel.Text = $"Жалоба на комментарий";
            //    dateLabel.Text = reviewReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is UserReports userReport)
            //{
            //    nameLabel.Text = $"Отправил {userReport.Users.Username}";
            //    typeLabel.Text = $"Жалоба на пользователя";
            //    dateLabel.Text = userReport.ReportDate.ToShortDateString();
            //}
            //else if (_notificationData is Feedback feedback)
            //{
            //    nameLabel.Text = $"Отправил {feedback.Users.Username}";
            //    typeLabel.Text = feedback.FeedbackCategory.FeedbackCategoryName;
            //    dateLabel.Text = feedback.FeedbackDate.ToShortDateString();
            //}
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
