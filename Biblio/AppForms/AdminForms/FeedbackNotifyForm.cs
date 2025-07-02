using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class FeedbackNotifyForm : Form
    {
        Feedback _feedback;

        public FeedbackNotifyForm(Feedback feedback)
        {
            InitializeComponent();

            _feedback = feedback;

            LoadNotifyInfo();
        }

        private void LoadNotifyInfo()
        {

        }
    }
}
