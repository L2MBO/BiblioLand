using Biblio.AppForms;
using Biblio.AppForms.AdminForms;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.Images.InstallingImages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblio.CustomControls
{
    public partial class NotifyControl : UserControl
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();

        public NotifyControl()
        {
            InitializeComponent();

            //LoadNotifyInfo();
        }

        //private void LoadNotifyInfo()
        //{
        //    nameLabel.Text = "Отправил: " + ;
        //    typeLabel.Text = ;
        //    dateLabel.Text = ??????.ReportDate?.ToShortDateString() ?? DateTime.Now.ToString();
        //}

        private void mainPanel_Click(object sender, EventArgs e)
        {
            var form = new WriteNotifyForm(/*передать те же данные что и будут передаватся в этот контрол, чтобы на форме с ними работать*/);
            _dialogService.ShowDialogWithOverlay(this.FindForm(), form);
        }
    }
}
