using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using Biblio.ValidationClasses;
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
    public partial class CommentNotifyForm : Form
    {
        public event Action CommentDeleted;
        ReviewReports _reviewReport;

        public CommentNotifyForm(ReviewReports reviewReport)
        {
            InitializeComponent();

            _reviewReport = reviewReport;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {
            titleLabel.Text = "Жалоба на комментарий";
            nameLabel.Text = _reviewReport.Users.Username;
            commentTextBox.Text = _reviewReport.Reviews.Comment;
            reasonLabel.Text = _reviewReport.ReviewReportCategory.ReportCategoryName;
            commentOwnerNameLabel.Text = _reviewReport.Reviews.Users.Username;
            descriptionTextBox.Text = _reviewReport.ReportMessage;
        }

        private void ProcessCommentDeletion()
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот комментарий?",
                        "Подтвердите действие!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteComment();
            }
        }

        private void DeleteComment()
        {
            var commentToDelete = _reviewReport.Reviews;
            Program.context.ReviewReports.Remove(_reviewReport);
            Program.context.Reviews.Remove(commentToDelete);
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Комментарий удален!", "Успех");

            CommentDeleted?.Invoke();

            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            NavigationControl.IsHide = true;
            var profileForm = new ProfileForm(_reviewReport.Users.UserID);
            profileForm.ShowDialog();
            NavigationControl.IsHide = false;
        }

        private void commentOwnerNameLabel_Click(object sender, EventArgs e)
        {
            NavigationControl.IsHide = true;
            var profileForm = new ProfileForm(_reviewReport.Reviews.Users.UserID);
            profileForm.ShowDialog();
            NavigationControl.IsHide = false;
        }

        private void deleteCommentButton_Click(object sender, EventArgs e)
        {
            ProcessCommentDeletion();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
