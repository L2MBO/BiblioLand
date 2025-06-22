using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class UserBanForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;
        private int _reportedUserId;

        public UserBanForm(int reportedUserId)
        {
            InitializeComponent();

            _reportedUserId = reportedUserId;
        }


    }
}
