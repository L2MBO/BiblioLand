using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
