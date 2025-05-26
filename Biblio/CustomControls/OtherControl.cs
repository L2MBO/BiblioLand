using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
