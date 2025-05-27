using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.HideClasses;
using Biblio.Interface;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class AvatarControl : UserControl
    {
        private IAvatarParentForm _parent;
        private int _contentX = 460;
        int _currentUserId = Program.CurrentUser.UserID;

        public AvatarControl(Form parentForm)
        {
            InitializeComponent();

            _parent = parentForm as IAvatarParentForm;

            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            RoundingHelper.SetRoundedRegion(this, 25, 25);

            if (_parent != null)
            {
                _parent.WindowStateChanged += Form_WindowStateChanged;
            }
            else
            {
                Debug.WriteLine("_parent имеет значение null в конструкторе AvatarControl.");
            }

            var curentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);
            userNameLabel.Text = curentUser.Username;

            coinCountLabel.Text = curentUser.CoinsNumber.ToString() + " монет";

            ImageLoader.LoadAvatarImage(userAvatarPictureBox);

            this.VisibleChanged += AvatarControl_VisibleChanged;
        }

        private void Form_WindowStateChanged(object sender, EventArgs e)
        {
            if (_parent == null) return;

            _contentX = (_parent.WindowState == FormWindowState.Maximized) ? 1450 : 460;

            UpdateAddContentControlPosition();
        }

        private AddContentControl addContentControl;

        private void UpdateAddContentControlPosition()
        {
            if (addContentControl != null)
            {
                int x = addContentButton.Right + _contentX;
                int y = addContentButton.Bottom + 20;

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
            ProfileForm form = new ProfileForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackForm form = new FeedbackForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            StoreForm form = new StoreForm();
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
            this.Parent.Hide();
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
