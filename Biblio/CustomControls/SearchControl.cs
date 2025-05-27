using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.HideClasses;
using Biblio.Interface;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class SearchControl : UserControl
    {
        private IAvatarParentForm _parent;

        public SearchControl(Form parentForm)
        {
            InitializeComponent();

            _parent = parentForm as IAvatarParentForm;

            RoundingHelper.SetRoundedRegion(this, 41, 41);
        }

        private void ShowOftenSearchBooks()
        {
            booksPanel.Controls.Clear();

            List<Books> books = Program.context.Books
                .Where(book => book.OftenSearched == 1)
                .OrderBy(name => name.Title)
                .ToList();

            foreach (Books book in books)
            {
                var bookControl = new BookSearchControl((Form)_parent, book);
                bookControl.Margin = new Padding(5);
                bookControl.BookClicked += BookControl_BookClicked;
                booksPanel.Controls.Add(bookControl);
            }
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this.FindForm(), bookInfoForm);
            this.Parent.Hide();
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            ShowOftenSearchBooks();
        }

        private void searchTextField_TextChanged(object sender, EventArgs e)
        {
            string result = searchTextField.Text.Trim().ToLower();

            if (result == "")
            {
                oftenSearchedLabel.Visible = true;
                ShowOftenSearchBooks();
            }
            else
            {
                List<Books> filteredBooks = Program.context.Books
                    .Where(book => book.Title.ToLower()
                    .Contains(result) || book.Author.ToLower().Contains(result))
                    .OrderBy(book => book.Title)
                    .ToList();

                if (filteredBooks.Count > 0)
                {
                    ShowFilteredBooks(filteredBooks);
                    oftenSearchedLabel.Visible = false;
                    noResultPanel.Visible = false;
                }
                else
                {
                    booksPanel.Controls.Clear();
                    noResultPanel.Visible = true;
                }
            }

            if (searchTextField.Text != "")
            {
                clearTextButton.Visible = true;
            }
            else
            {
                clearTextButton.Visible = false;
            }
        }

        private void ShowFilteredBooks(List<Books> books)
        {
            booksPanel.Controls.Clear();

            foreach (Books book in books)
            {
                var bookControl = new BookSearchControl((Form)_parent, book);
                bookControl.Margin = new Padding(5);
                bookControl.BookClicked += BookControl_BookClicked;
                booksPanel.Controls.Add(bookControl);
            }

            noResultPanel.Visible = false;
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            searchTextField.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
