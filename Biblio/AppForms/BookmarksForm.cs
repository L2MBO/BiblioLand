using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookmarksForm : Form
    {
        private static int _currentUserId = Program.CurrentUser.UserID;
        //private Users _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

        public BookmarksForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            ShowBookmarks();
        }

        private void ShowBookmarks(/*Books books*/)
        {
            bookmarksPanel.Controls.Clear();

            List<Books> books = Program.context.Books.Where(category => category.CategoryID == 1).OrderBy(name => name.Title).ToList();
            foreach (Books book in books)
            {
                var userBookmarksControl = new MainControl(book);
                userBookmarksControl.Margin = new Padding(10);
                userBookmarksControl.BookClicked += BookControl_BookClicked;
                bookmarksPanel.Controls.Add(userBookmarksControl);
            }
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);
            this.Hide();
        }

        private void BookmarksForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
