using Biblio.AppForms;
using Biblio.Classes.Coding;
using Biblio.Classes.Customization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Interface;
using Biblio.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class AvatarControl : UserControl
    {
        public event EventHandler OpenChanged;
        private IAvatarParentForm _parent;
        private int contentX = 460;
        int currentUserId = Program.CurrentUser.UserID;

        public AvatarControl(Form parentForm)
        {
            InitializeComponent();

            _parent = parentForm as IAvatarParentForm;

            if (_parent != null)
            {
                _parent.WindowStateChanged += Form_WindowStateChanged;
                OpenChanged += _parent.OnControlOpenChanged;
            }
            else
            {
                Debug.WriteLine("_parent имеет значение null в конструкторе AvatarControl.");
            }

            var curentUser = Program.context.Users.FirstOrDefault(user => user.UserID == currentUserId);
            userNameLabel.Text = curentUser.Username;

            coinCountLabel.Text = curentUser.CoinsNumber.ToString() + " монет";

            ImageLoader.LoadAvatarImage(userAvatarPictureBox);

            RoundingHelper.SetRoundedRegion(this, 25, 25);

            userAvatarPictureBox.Click += userNameLabel_Click;
            userInfoPanel.Click += userNameLabel_Click;
            coinPictureBox.Click += userNameLabel_Click;
            coinCountLabel.Click += userNameLabel_Click;

            this.VisibleChanged += AvatarControl_VisibleChanged;
        }

        private void Form_WindowStateChanged(object sender, EventArgs e)
        {
            if (_parent == null) return;

            contentX = (_parent.WindowState == FormWindowState.Maximized) ? 1450 : 460;

            UpdateAddContentControlPosition();
        }

        private AddContentControl addContentControl;

        private void UpdateAddContentControlPosition()
        {
            if (addContentControl != null)
            {
                int x = addContentButton.Right + contentX;
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

            if (_parent != null)
            {
                addContentControl.OpenChanged += _parent.OnControlOpenChanged;
            }

            UpdateAddContentControlPosition();

            this.Parent.Controls.Add(addContentControl);
            addContentControl.BringToFront();
            addContentControl.Visible = true;
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            ProfileForm form = new ProfileForm();
            form.Show();
            this.Hide();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            FeedbackForm form = new FeedbackForm();
            form.Show();
            this.Hide();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            StoreForm form = new StoreForm();
            form.Show();
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            SettingsForm form = new SettingsForm();
            form.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
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
