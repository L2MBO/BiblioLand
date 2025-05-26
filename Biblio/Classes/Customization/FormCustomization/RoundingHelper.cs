using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Biblio.Classes.Customization
{
    public static class RoundingHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public static void SetRoundedRegion(Form form, int widthEllipse, int heightEllipse)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, form.Width, form.Height, widthEllipse, heightEllipse);
            if (region != IntPtr.Zero)
            {
                form.Region = System.Drawing.Region.FromHrgn(region);
            }
        }

        public static void SetRoundedRegion(UserControl userControl, int widthEllipse, int heightEllipse)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, userControl.Width, userControl.Height, widthEllipse, heightEllipse);
            if (region != IntPtr.Zero)
            {
                userControl.Region = System.Drawing.Region.FromHrgn(region);
            }
        }

        public static void SetRoundedRegion(Panel panel, int widthEllipse, int heightEllipse)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, panel.Width, panel.Height, widthEllipse, heightEllipse);
            if (region != IntPtr.Zero)
            {
                panel.Region = System.Drawing.Region.FromHrgn(region);
            }
        }
    }
}