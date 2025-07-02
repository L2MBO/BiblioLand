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
