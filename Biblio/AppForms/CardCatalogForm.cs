using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class CardCatalogForm : Form
    {
        public CardCatalogForm()
        {
            InitializeComponent();
        }

        private void CardCatalogForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
