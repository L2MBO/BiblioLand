using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void AddCardForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
