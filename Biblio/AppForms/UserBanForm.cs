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
