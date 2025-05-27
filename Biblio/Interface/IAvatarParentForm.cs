using System;
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
