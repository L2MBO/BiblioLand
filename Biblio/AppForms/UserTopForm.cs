using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class UserTopForm : Form
    {
        public UserTopForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void UserTopForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
