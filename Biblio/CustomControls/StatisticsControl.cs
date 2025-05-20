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
using static Guna.UI2.Native.WinApi;

namespace Biblio.CustomControls
{
    public partial class StatisticsControl : UserControl
    {
        private Books _book;

        public StatisticsControl(Books books)
        {
            InitializeComponent();

            _book = books;

            var rating = _book.AverageRating;

            overageRatingLabel.Text = "Рейтинг за последнее время: " + rating;
        }
    }
}
