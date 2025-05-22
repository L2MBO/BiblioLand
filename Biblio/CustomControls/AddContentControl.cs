using Biblio.AppForms;
using Biblio.Classes.Customization;
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
        public event EventHandler OpenChanged;

        public AddContentControl()
        {
            InitializeComponent();

            RoundingHelper.SetRoundedRegion(this, 15, 15);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            AddBookForm form = new AddBookForm();
            form.Show();
            this.Parent.Hide();
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            AddCardForm form = new AddCardForm();
            form.Show();
            this.Parent.Hide();
        }
    }
}
