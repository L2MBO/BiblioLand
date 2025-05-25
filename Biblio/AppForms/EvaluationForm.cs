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

namespace Biblio.AppForms
{
    public partial class EvaluationForm : Form
    {
        private Books _book;
        private int _currentUserId;

        public EvaluationForm(Books book, int currentUserId)
        {
            InitializeComponent();

            _book = book;
            _currentUserId = currentUserId;
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
