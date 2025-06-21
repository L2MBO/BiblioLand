using Biblio.AppForms;
using System.Windows.Forms;

namespace Biblio.Classes.Customization.FormCustomization
{
    internal class DialogWithOverlayService
    {
        private OverlayForm _overlayForm;

        public DialogResult ShowDialogWithOverlay(Form parentForm, Form dialogForm)
        {
            _overlayForm = new OverlayForm(parentForm);
            _overlayForm.Show(parentForm);

            dialogForm.StartPosition = FormStartPosition.CenterParent;
            dialogForm.FormClosed += (s, args) => _overlayForm.Close();

            return dialogForm.ShowDialog(parentForm);
        }
    }
}
