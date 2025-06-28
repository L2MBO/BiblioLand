using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.HideClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class AvatarControl : UserControl
    {
        private Form _parentForm;
        private int _contentX;
        private int _currentUserId = Program.CurrentUser.UserID;

        public AvatarControl(Form parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            CheckUserRole();

            RoundingHelper.SetRoundedRegion(this, 25, 25);

            _parentForm.Resize += ParentForm_Resize;

            UpdateContentXBasedOnWindowState();
            UpdateAddContentControlPosition();

            var _curentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            userNameLabel.Text = _curentUser.Username;

            ImageLoader.LoadAvatarImage(userAvatarPictureBox);

            this.VisibleChanged += AvatarControl_VisibleChanged;
        }

        private void ParentForm_Resize(object sender, EventArgs e)
        {
            UpdateContentXBasedOnWindowState();
            UpdateAddContentControlPosition();
        }

        private void UpdateContentXBasedOnWindowState()
        {
            _contentX = (_parentForm.WindowState == FormWindowState.Maximized) ? 1448 : 453;
        }

        private AddContentControl addContentControl;

        private void UpdateAddContentControlPosition()
        {
            if (addContentControl != null)
            {
                int x = addContentButton.Right + _contentX;
                int y = addContentButton.Bottom + 33;

                addContentControl.Location = new Point(x, y);
            }
        }

        private void AvatarControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible && addContentControl != null)
            {
                RemoveAddContentControl();
            }
        }

        private void RemoveAddContentControl()
        {
            if (addContentControl != null)
            {
                if (this.Parent?.Controls.Contains(addContentControl) == true)
                {
                    this.Parent.Controls.Remove(addContentControl);
                }

                addContentControl.Dispose();
                addContentControl = null;
            }
        }

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (_currentUser != null)
            {
                AddAdminFunctional();
            }
            else
            {
                this.Height = 193;
                mainPanel.Height = 192;
                avatarPanel.PerformLayout();

                Panel dividerLine = new Panel
                {
                    BackColor = Color.FromArgb(64, 64, 64),
                    Width = 160,
                    Height = 1,
                    Location = new Point(20, 191),
                };

                mainPanel.Controls.Add(dividerLine);
                dividerLine.BringToFront();
            }
        }

        private void AddAdminFunctional()
        {
            delimiter1.Visible = true;
            delimiter2.Visible = true;
            delimiter3.Visible = true;
            line1.Visible = true;
            addContentButton.Visible = true;
            adminButton.Visible = true;
        }

        private void addContentButton_Click(object sender, EventArgs e)
        {
            if (addContentControl != null && addContentControl.Visible)
            {
                RemoveAddContentControl();
                return;
            }

            addContentControl = new AddContentControl();

            UpdateAddContentControlPosition();

            this.Parent.Controls.Add(addContentControl);
            addContentControl.BringToFront();
            addContentControl.Visible = true;
        }

        private void userProfile_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(_currentUserId);
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackForm form = new FeedbackForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminPanelForm form = new AdminPanelForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Parent.Dispose();
        }

        private void UserNameLabel_MouseEnter(object sender, EventArgs e)
        {
            userNameLabel.Font = new Font(userNameLabel.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void UserNameLabel_MouseLeave(object sender, EventArgs e)
        {
            userNameLabel.Font = new Font(userNameLabel.Font, FontStyle.Bold | FontStyle.Regular);
        }
    }
}
