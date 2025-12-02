using Biblio.CustomControls;
using Biblio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class ReportNotifyForm : Form
    {
        private object _notificationData;
        private int _nameProfile;

        public ReportNotifyForm(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            if (_notificationData is BookReports bookReport)
            {
                _nameProfile = bookReport.Users.UserID;
                reportLabel.AutoSize = false;
                titleLabel.Text = "Жалоба на книгу";
                nameLabel.Text = bookReport.Users.Username;
                reportInfoLabel.Text = "Репорт на книгу:";
                reportLabel.Text = bookReport.Books.Title;
                reasoneLabel.Text = bookReport.BookReportCategory.ReportCategoryName;
                descriptionTextBox.Text = bookReport.ReportMessage;
            }
            else if (_notificationData is UserReports userReport)
            {
                var newUserReport = Program.context.UserReports.AsNoTracking().FirstOrDefault(u => u.UserReportID == userReport.UserReportID);
                _nameProfile = newUserReport.Users.UserID;
                reportLabel.AutoSize = true;
                titleLabel.Text = "Жалоба на пользователя";
                nameLabel.Text = newUserReport.Users.Username;
                reportInfoLabel.Text = "Репорт на пользователя:";
                reportLabel.Text = newUserReport.Users1.Username;
                reasoneLabel.Text = newUserReport.UserReportCategory.ReportCategoryName;
                descriptionTextBox.Text = newUserReport.ReportMessage;
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            NavigationControl.IsHide = true;
            var profileForm = new ProfileForm(_nameProfile);
            profileForm.ShowDialog();
            NavigationControl.IsHide = false;
        }

        private void reportLabel_Click(object sender, EventArgs e)
        {
            if (_notificationData is BookReports bookReport)
            {
                NavigationControl.IsHide = true;
                var bookInfoForm = new BookInfoForm(bookReport.Books);
                bookInfoForm.ShowDialog();
                NavigationControl.IsHide = false;
            }
            else if (_notificationData is UserReports userReport)
            {
                NavigationControl.IsHide = true;
                var profileForm = new ProfileForm(_nameProfile);
                profileForm.ShowDialog();
                NavigationControl.IsHide = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
