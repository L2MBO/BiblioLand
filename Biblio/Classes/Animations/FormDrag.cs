using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Biblio.Classes.Animations
{
    internal class FormDrag
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void DragingForm(Form form)
        {
            ReleaseCapture();
            form.Opacity = 0.7;

            SendMessage(form.Handle, 0x112, 0xf012, 0);
            form.Opacity = 1;
        }
    }
}
