using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookmarksForm : Form
    {
        public BookmarksForm()
        {
            InitializeComponent();

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void BookmarksForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
