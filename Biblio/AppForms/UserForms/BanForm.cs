using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms.UserForms
{
    public partial class BanForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;

        public BanForm()
        {
            InitializeComponent();

            FillBanFormInfo();
        }

        private void FillBanFormInfo()
        {
            var userBan = Program.context.UserBans.AsNoTracking().FirstOrDefault(user => user.BanedUserID == _currentUserId);

            reasonLabel.Text = userBan.UserBanCategory.BanCategoryName.ToString();
            banExpirationLabel.Text = userBan.BanExpiration.ToString("yyyy-MM-dd HH:mm");
            messageLabel.Text = userBan.BanMessage ?? string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
