using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
