using Biblio.Classes.Customization;
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
            var userBan = Program.context.UserBans.FirstOrDefault(user => user.BanedUserID == _currentUserId);

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
