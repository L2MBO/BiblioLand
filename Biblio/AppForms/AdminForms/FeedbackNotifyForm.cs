using Biblio.CustomControls;
using Biblio.Models;
using System;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class FeedbackNotifyForm : Form
    {
        Feedback _feedback;

        public FeedbackNotifyForm(Feedback feedback)
        {
            InitializeComponent();

            _feedback = feedback;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            titleLabel.Text = _feedback.FeedbackTitle;
            nameLabel.Text = _feedback.Users.Username;
            categoryLabel.Text = _feedback.FeedbackCategory.FeedbackCategoryName;
            descriptionTextBox.Text = _feedback.FeedbackMessage;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            NavigationControl.IsHide = true;
            var profileForm = new ProfileForm(_feedback.Users.UserID);
            profileForm.ShowDialog();
            NavigationControl.IsHide = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
