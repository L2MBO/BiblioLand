using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using System;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class AddContentControl : UserControl
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();

        public AddContentControl()
        {
            InitializeComponent();

            RoundingHelper.SetRoundedRegion(this, 15, 15);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            var form = new CreateOrUpdateBookForm();
            _dialogService.ShowDialogWithOverlay(this.FindForm(), form);
        }
    }
}