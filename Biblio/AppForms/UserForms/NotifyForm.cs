using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void UserNotifyForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
