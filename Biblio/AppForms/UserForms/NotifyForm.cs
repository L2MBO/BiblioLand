using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            buttonsPanel.Visible = false;
            writeNotifyButton.Visible = false;
            typeComboBox.Visible = false;
        }

        private void UserNotifyForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
