using Biblio.Classes.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class BookmarksControl : UserControl
    {
        public BookmarksControl()
        {
            InitializeComponent();

            RoundingHelper.SetRoundedRegion(this, 36, 36);
        }


    }
}
