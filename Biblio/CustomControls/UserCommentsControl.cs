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
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace Biblio.CustomControls
{
    public partial class UserCommentsControl : UserControl
    {
        private Reviews _comment;

        public UserCommentsControl(Reviews reviews)
        {
            InitializeComponent();

            _comment = reviews;

            LoadCommentInfo();
        }

        private void LoadCommentInfo()
        {
            int user = (int)_comment.UserID;

            ImageLoader.LoadAvatarImageFromUserID(user, profileButton);

            nameLabel.Text = _comment.Users.Username;
            commentLabel.Text = _comment.Comment;
        }
    }
}
