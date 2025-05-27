using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookTopForm : Form
    {
        public BookTopForm()
        {
            InitializeComponent();

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void BookTopForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
