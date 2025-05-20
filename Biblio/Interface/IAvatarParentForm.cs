using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.Interface
{
    internal interface IAvatarParentForm
    {
        event EventHandler WindowStateChanged;
        void OnControlOpenChanged(object sender, EventArgs e);
        FormWindowState WindowState { get; }
    }
}
