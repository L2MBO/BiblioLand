using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class UserBanForm : Form
    {
        private int _currentUserId;

        public UserBanForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
        }
    }
}
