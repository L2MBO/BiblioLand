using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class ChangeRoleForm : Form
    {
        private int _currentUserId;
        private Users _currentUser;

        public ChangeRoleForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            SetChangeRoleFormStyle();
        }

        private void SetChangeRoleFormStyle()
        {
            roleComboBox.SelectedIndex = _currentUser.UserRoleID - 1;
        }

        private void UserBanValidation()
        {
            if (roleComboBox.SelectedIndex + 1 != _currentUser.UserRoleID)
            {
                ProcessChangeRole();
            }
            else
            {
                ValidationHelper.ShowErrorMessage("Вы не можете установить ту же роль, которая была!");
            }
        }

        private void ProcessChangeRole()
        {
            var result = MessageBox.Show("Вы уверены?",
                "Подтвердите действие!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateRole();
                this.Close();
            }
        }

        private void UpdateRole()
        {
            _currentUser.UserRoleID = roleComboBox.SelectedIndex + 1;

            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Роль пользователя обновлена!", "Успех!");
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex + 1 != _currentUser.UserRoleID)
            {
                pastRoleLabel.Visible = false;
            }
            else
            {
                pastRoleLabel.Visible = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeRoleButton_Click(object sender, EventArgs e)
        {
            UserBanValidation();
        }
    }
}
