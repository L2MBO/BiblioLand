using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.HideClasses;
using System;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class OtherControl : UserControl
    {
        public OtherControl()
        {
            InitializeComponent();

            RoundingHelper.SetRoundedRegion(this, 25, 25);
        }

        private void catalogPanel_Click(object sender, EventArgs e)
        {
            CardCatalogForm form = new CardCatalogForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void rankPanel_Click(Object sender, EventArgs e)
        {
            UserTopForm form = new UserTopForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }
    }
}
