using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
