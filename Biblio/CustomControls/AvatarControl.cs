using Biblio.AppForms;
using Biblio.Classes.Coding;
using Biblio.Classes.Customization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private MainForm mainForm;
        private int contentX = 460;
        int currentUserId = Program.CurrentUser.UserID;

        public AvatarControl(MainForm mainForm)
        {
            InitializeComponent();

            var curentUser = Program.context.Users.FirstOrDefault(user => user.UserID == currentUserId);
            userNameLabel.Text = curentUser.Username;

            coinCountLabel.Text = curentUser.CoinsNumber.ToString() + " монет";

            ImageLoader.LoadAvatarImage(userAvatarPictureBox);

            CustomizationHelper.SetRoundedRegion(this, 25, 25);

            this.mainForm = mainForm;
            mainForm.WindowStateChanged += MainForm_WindowStateChanged;

            userAvatarPictureBox.Click += userNameLabel_Click;
            userInfoPanel.Click += userNameLabel_Click;
            coinPictureBox.Click += userNameLabel_Click;
            coinCountLabel.Click += userNameLabel_Click;

            this.VisibleChanged += AvatarControl_VisibleChanged;
        }

        private void MainForm_WindowStateChanged(object sender, EventArgs e)
        {
            if (mainForm.WindowState == FormWindowState.Maximized)
            {
                contentX = 1450;
            }
            else
            {
                contentX = 460;
            }

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

            addContentControl.OpenChanged += mainForm.OnControlOpenChanged;

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
