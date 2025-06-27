using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Biblio.CustomControls
{
    public partial class UserProfileControl : UserControl
    {
        private Users _currentUser;
        public event EventHandler<Users> UserClicked;

        public UserProfileControl(Users User)
        {
            InitializeComponent();

            _currentUser = User;

            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            ImageLoader.LoadAvatarImageFromUserID(_currentUser.UserID, avatarPictureBox);
            nameLabel.Text = _currentUser.Username;
            registrationDateLabel.Text = _currentUser.RegistrationDate?.ToShortDateString() ?? DateTime.Now.ToString();
            statusPictureBox.FillColor = IsUserBaned() ? Color.Red : Color.FromArgb(0, 192, 0);
        }

        private bool IsUserBaned()
        {
            return Program.context.UserBans.Any(user => user.BanedUserID == _currentUser.UserID);
        }

        private void UserProfileControl_Click(object sender, EventArgs e)
        {
            UserClicked?.Invoke(this, _currentUser);
        }
    }
}
