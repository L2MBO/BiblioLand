using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.HideClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class AddContentControl : UserControl
    {

        public AddContentControl()
        {
            InitializeComponent();

            RoundingHelper.SetRoundedRegion(this, 15, 15);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            AddCardForm form = new AddCardForm();
            VisibilityHelper.ShowNewForm(this.FindForm(), form);
            this.Parent.Hide();
        }
    }
}