using Biblio.Classes.Customization;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Biblio.AppForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(profilePage, disableHorizontal: false, disableVertical: true);
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);

            if (this.WindowState == FormWindowState.Maximized)
            {
                avatarPictureBox.Width = 200;
                avatarPictureBox.Height = 200;
                avatarPictureBox.BorderRadius = 15;
                avatarPanel.Height = 226;
            }
            else
            {
                avatarPictureBox.Width = 44;
                avatarPictureBox.Height = 44;
                avatarPictureBox.BorderRadius = 7;
                avatarPanel.Height = 70;
            }
        }
    }
}
