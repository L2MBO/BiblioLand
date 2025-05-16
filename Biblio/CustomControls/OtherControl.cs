using Biblio.AppForms;
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
using System.Xml;

namespace Biblio.CustomControls
{
    public partial class OtherControl : UserControl
    {
        public event EventHandler OpenChanged;

        public OtherControl()
        {
            InitializeComponent();

            CustomizationHelper.SetRoundedRegion(this, 25, 25);

            catalogPanel.Click += catalogPanel_Click;
            catalogLabel.Click += catalogPanel_Click;
            catalogInfoLabel.Click += catalogPanel_Click;
            cardsPictureBox.Click += catalogPanel_Click;
            catalogRightArrowPictureBox.Click += catalogPanel_Click;

            rankPanel.Click += rankPanel_Click;
            rankLabel.Click += rankPanel_Click;
            rankInfoLabel.Click += rankPanel_Click;
            rankPictureBox.Click += rankPanel_Click;
            rankRightArrowPictureBox.Click += rankPanel_Click;
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

        private void catalogPanel_Click(object sender, EventArgs e)
        {
            CardCatalogForm form = new CardCatalogForm();
            form.Show();
            this.Hide();
            IsOpen = true;
        }

        private void rankPanel_Click(Object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
            IsOpen = true;
        }
    }
}
