using Biblio.Classes.Customization;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class OverlayForm : Form
    {
        public OverlayForm(Form parentForm)
        {
            InitializeComponent();

            SetFormStyle(parentForm);
        }

        private void SetFormStyle(Form parentForm)
        {
            this.Opacity = 0.7;
            this.ShowInTaskbar = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = parentForm.Location;
            this.Size = parentForm.Size;

            UpdateRadius(parentForm);

            parentForm.LocationChanged += (s, e) => this.Location = parentForm.Location;
            parentForm.SizeChanged += (s, e) =>
            {
                this.Size = parentForm.Size;
                UpdateRadius(parentForm);
            };
        }

        private void UpdateRadius(Form parentForm)
        {
            int radius = parentForm.WindowState == FormWindowState.Maximized ? 0 : 11;
            RoundingHelper.SetRoundedRegion(this, radius, radius);
        }
    }
}
