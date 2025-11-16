using System.Windows.Forms;

namespace Biblio.AppForms.UserForms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Resize(object sender, System.EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
