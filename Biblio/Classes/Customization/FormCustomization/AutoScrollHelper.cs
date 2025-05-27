using System.Windows.Forms;

namespace Biblio.Classes.Customization
{
    internal class AutoScrollHelper
    {
        public static void ConfigureScrollbars(FlowLayoutPanel panel, bool disableHorizontal, bool disableVertical)
        {
            if (disableHorizontal)
            {
                panel.HorizontalScroll.Enabled = false;
                panel.HorizontalScroll.Visible = false;
                panel.HorizontalScroll.Maximum = 0;
            }

            if (disableVertical)
            {
                panel.VerticalScroll.Enabled = false;
                panel.VerticalScroll.Visible = false;
                panel.VerticalScroll.Maximum = 0;
            }

            panel.AutoScroll = true;
        }

        public static void ConfigureScrollbars(Panel panel, bool disableHorizontal, bool disableVertical)
        {
            if (disableHorizontal)
            {
                panel.HorizontalScroll.Enabled = false;
                panel.HorizontalScroll.Visible = false;
                panel.HorizontalScroll.Maximum = 0;
            }

            if (disableVertical)
            {
                panel.VerticalScroll.Enabled = false;
                panel.VerticalScroll.Visible = false;
                panel.VerticalScroll.Maximum = 0;
            }

            panel.AutoScroll = true;
        }
    }
}
