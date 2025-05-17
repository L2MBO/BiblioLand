using Biblio.Classes.Customization;
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

namespace Biblio.CustomControls
{
    public partial class SearchControl : UserControl
    {
        public event EventHandler OpenChanged;

        public SearchControl()
        {
            InitializeComponent();

            CustomizationHelper.SetRoundedRegion(this, 35, 35);


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

        

        private void SearchControl_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
