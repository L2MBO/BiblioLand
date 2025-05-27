using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
        }

        private void RankForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
