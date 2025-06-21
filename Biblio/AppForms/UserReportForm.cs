using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class UserReportForm : Form
    {
        private int _currentUserId;

        public UserReportForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
        }
    }
}
