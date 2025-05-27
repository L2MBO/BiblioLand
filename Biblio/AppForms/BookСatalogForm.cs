using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookСatalogForm : Form
    {
        public BookСatalogForm()
        {
            InitializeComponent();

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void BookСatalogForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
