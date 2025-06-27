using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            statusPictureBox.FillColor = IsUserBaned() ? Color.Red : Color.FromArgb(0, 192, 0);
            nameLabel.Text = _currentUser.Username;
            roleLabel.Text = _currentUser.UserRoles.RoleName;
            roleLabel.ForeColor = _currentUser.UserRoleID == 1 ? Color.White
                                : _currentUser.UserRoleID == 2 ? Color.Red
                                : Color.FromArgb(60, 132, 246);
            registrationDateLabel.Text = _currentUser.RegistrationDate?.ToShortDateString() ?? DateTime.Now.ToString();
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
