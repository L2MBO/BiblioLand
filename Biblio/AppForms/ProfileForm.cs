using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void ProfileForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
