using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
