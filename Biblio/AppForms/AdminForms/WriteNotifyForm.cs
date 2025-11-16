using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class WriteNotifyForm : Form
    {
        public WriteNotifyForm()
        {
            InitializeComponent();
        }

        private void NotifyValidation()
        {
            bool titleIsEmpty = string.IsNullOrEmpty(titleTextBox.Text);
            bool descriptionIsEmpty = string.IsNullOrEmpty(descriptionTextBox.Text);

            titleLabel.ForeColor = titleIsEmpty == true ? Color.Red : Color.White;
            descriptionLabel.ForeColor = descriptionIsEmpty == true ? Color.Red : Color.White;

            if (!titleIsEmpty && !descriptionIsEmpty)
            {
                ProcessNotifySubmission();
            }
        }

        private void ProcessNotifySubmission()
        {
            var result = MessageBox.Show("Вы уверены, что хотите отправить это сообщение?",
                "Подтвердите действие!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SendNotifyToDatabase();
            }
        }

        private void SendNotifyToDatabase()
        {
            var userBan = new SystemNotifications
            {
                UserID = Program.CurrentUser.UserID,
                NotifyTitle = titleTextBox.Text.Trim(),
                NotifyMessage = descriptionTextBox.Text.Trim(),
                NotifyDate = DateTime.Now
            };

            Program.context.SystemNotifications.Add(userBan);
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Сообщение отправлено!", "Успех!");

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendNotifyButton_Click(object sender, EventArgs e)
        {
            NotifyValidation();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleLabel.ForeColor == Color.Red)
            {
                titleLabel.ForeColor = Color.White;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descriptionLabel.ForeColor == Color.Red)
            {
                descriptionLabel.ForeColor = Color.White;
            }
        }
    }
}
