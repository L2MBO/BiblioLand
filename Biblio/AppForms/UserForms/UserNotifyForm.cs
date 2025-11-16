using Biblio.Models;
using System;
using System.Windows.Forms;

namespace Biblio.AppForms.UserForms
{
    public partial class UserNotifyForm : Form
    {
        private SystemNotifications _systemNotification;

        public UserNotifyForm(SystemNotifications systemNotification)
        {
            InitializeComponent();

            _systemNotification = systemNotification;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            titleLabel.Text = _systemNotification.NotifyTitle;
            descriptionTextBox.Text = _systemNotification.NotifyMessage;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
