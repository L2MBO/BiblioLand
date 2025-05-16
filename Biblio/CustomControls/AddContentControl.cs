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

            CustomizationHelper.SetRoundedRegion(this, 15, 15);
        }


        private bool _isOpen = false;

        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                _isOpen = value;
                OpenChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.Show();
            this.Hide();
            IsOpen = true;
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            AddCardForm form = new AddCardForm();
            form.Show();
            this.Hide();
            IsOpen = true;
        }
    }
}
