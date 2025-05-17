using Biblio.AppForms;
using Biblio.Classes.Customization;
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

namespace Biblio.CustomControls
{
    public partial class SearchControl : UserControl
    {
        private MainForm _mainForm;

        public SearchControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            CustomizationHelper.SetRoundedRegion(this, 41, 41);

        }

        private void ShowSearchBooks()
        {
            List<Books> books = Program.context.Books.Where(book => book.OftenSearched == 1).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var bookControl = new BookSearchControl(_mainForm, book);
                bookControl.Margin = new Padding(5);
                bookControl.BookClicked += BookControl_BookClicked;
                booksPanel.Controls.Add(bookControl);
            }
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            bookInfoForm.ShowDialog();
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            ShowSearchBooks();
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            searchTextField.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
