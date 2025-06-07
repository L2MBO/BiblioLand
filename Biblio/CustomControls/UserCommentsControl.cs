using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isLiked;

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
            likesCountLabel.Text = _comment.LikesCount.ToString();

            _isLiked = Program.context.Likes.Any(like => like.UserID == _currentUserId && like.ReviewID == _comment.ReviewID);

            UpdateLikeButtonImage();
        }

        private void UpdateLikeButtonImage()
        {
            likesButton.Image = _isLiked ? Properties.Resources.redLike : Properties.Resources.whiteLike;
        }

        private int CalculateLabelHeight(string text, Font font, int width)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(text, font, new Size(width, 0), TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height);
            }
        }

        public void SetTime(string time)
        {
            timeLabel.Text = time;
        }

        private void ToggleLike()
        {
            var like = Program.context.Likes.FirstOrDefault(userLike => userLike.UserID 
            == _currentUserId && userLike.ReviewID
            == _comment.ReviewID);

            var review = Program.context.Reviews.FirstOrDefault(r => r.ReviewID == _comment.ReviewID);
            if (review == null) return;

            if (like == null)
            {
                like = new Likes
                {
                    UserID = _currentUserId,
                    ReviewID = _comment.ReviewID,
                    isLiked = 1
                };

                Program.context.Likes.Add(like);
                _isLiked = true;
                review.LikesCount++;
            }
            else
            {
                Program.context.Likes.Remove(like);
                _isLiked = false;
                review.LikesCount = Math.Max(0, (int)review.LikesCount - 1);
            }

            Program.context.SaveChanges();
            UpdateLikeButtonImage();
            likesCountLabel.Text = review.LikesCount.ToString();
        }

        private void commentLabel_TextChanged(object sender, EventArgs e)
        {
            int labelWidth = commentLabel.Width;

            int preferredHeight = CalculateLabelHeight(commentLabel.Text, commentLabel.Font, labelWidth);

            commentLabel.Height = preferredHeight;

            commentLabel.PerformLayout();
        }

        private void likesButton_Click(object sender, EventArgs e)
        {
            ToggleLike();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
