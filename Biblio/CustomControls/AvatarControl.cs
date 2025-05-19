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
        private int contentX = 450;
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

            addContentPictureBox.Click += addContentLabel_Click;

            userAvatarPictureBox.Click += userNameLabel_Click;
            userInfoPanel.Click += userNameLabel_Click;
            coinPictureBox.Click += userNameLabel_Click;
            coinCountLabel.Click += userNameLabel_Click;

            feedbackPictureBox.Click += feedbackLabel_Click;

            storePictureBox.Click += storeLabel_Click;

            settingsPictureBox.Click += settingsLabel_Click;

            exitPictureBox.Click += exitLabel_Click;

            this.VisibleChanged += AvatarControl_VisibleChanged;
        }

        private void MainForm_WindowStateChanged(object sender, EventArgs e)
        {
            if (mainForm.WindowState == FormWindowState.Maximized)
            {
                contentX = 1475;
            }
            else
            {
                contentX = 450;
            }

            UpdateAddContentControlPosition();
        }

        private void UpdateAddContentControlPosition()
        {
            if (addContentControl != null)
            {
                int x = addContentLabel.Right + contentX;
                int y = addContentLabel.Bottom + 130;

                addContentControl.Location = new Point(x, y);
            }
        }

        private AddContentControl addContentControl;

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

        private void addContentLabel_Click(object sender, EventArgs e)
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

        private void feedbackLabel_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            FeedbackForm form = new FeedbackForm();
            form.Show();
            this.Hide();
        }

        private void storeLabel_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            StoreForm form = new StoreForm();
            form.Show();
            this.Hide();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            SettingsForm form = new SettingsForm();
            form.Show();
            this.Hide();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }
    }
}
