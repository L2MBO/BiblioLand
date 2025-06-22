using Biblio.AppForms;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.HideClasses;
using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class UserCommentsControl : UserControl
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private readonly Form _parentForm;
        private Reviews _comment;
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isUserAdmin = false;
        private bool _isLiked;

        public UserCommentsControl(Form parentForm, Reviews reviews)
        {
            InitializeComponent();

            _parentForm = parentForm;
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
            CheckUserRole();
            UpdateReportImage();
        }

        private void UpdateLikeButtonImage()
        {
            likesButton.Image = _isLiked ? Properties.Resources.redLike : Properties.Resources.whiteLike;
        }

        private void UpdateReportImage()
        {
            if (_comment.UserID == _currentUserId || _isUserAdmin)
            {
                reportButton.Image = Properties.Resources.trash;
            }
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

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (_currentUser != null)
            {
                _isUserAdmin = true;
            }
        }

        private void CheckCommentOwner()
        {
            if (_comment.UserID == _currentUserId || _isUserAdmin)
            {
                reportButton.Image = Properties.Resources.trash;
                DeleteComment();
            }
            else
            {
                var form = new ReportForm(null, _comment.ReviewID, 0, _currentUserId, "Comment");
                _dialogService.ShowDialogWithOverlay(_parentForm, form);
            }
        }

        private void DeleteComment()
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить этот комментарий?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var likesToDelete = Program.context.Likes.Where(like => like.ReviewID == _comment.ReviewID);
                    Program.context.Likes.RemoveRange(likesToDelete);

                    var reportsToDelete = Program.context.ReviewReports.Where(report => report.ReviewID == _comment.ReviewID);
                    Program.context.ReviewReports.RemoveRange(reportsToDelete);

                    Program.context.Reviews.Remove(_comment);

                    Program.context.SaveChanges();

                    this.Parent?.Controls.Remove(this);

                    ValidationHelper.ShowInformationMessage("Комментарий успешно удален.", "Успех");
                }
                catch (Exception)
                {
                    ValidationHelper.ShowErrorMessage("Ошибка при удалении комментария.");
                }
            }
        }

        private void SetUserId()
        {
            if (_comment.UserID != _currentUserId)
            {
                ProfileForm form = new ProfileForm((int)_comment.UserID);
                VisibilityHelper.ShowNewForm(this.FindForm(), form);
                this.Parent.Parent.Parent.Hide();
            }
            else
            {
                ProfileForm form = new ProfileForm(_currentUserId);
                VisibilityHelper.ShowNewForm(this.FindForm(), form);
                this.Parent.Parent.Parent.Hide();
            }
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
            CheckCommentOwner();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetUserId();
        }
    }
}
