using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void StoreForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
