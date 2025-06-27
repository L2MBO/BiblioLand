using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class ExtendBanForm : Form
    {
        private int _banedUserId;

        public ExtendBanForm(int reportedUserId)
        {
            InitializeComponent();

            _banedUserId = reportedUserId;

            SetUserBanFormStyle();
        }

        private void SetUserBanFormStyle()
        {
            banCalendar.MinDate = DateTime.Now;
        }
    }
}
