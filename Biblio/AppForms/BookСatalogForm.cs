using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Profile;
using System.Windows.Forms;
using static Biblio.Classes.SaveUserSettings.SaveUserFilter;

namespace Biblio.AppForms
{
    public partial class BookСatalogForm : Form
    {
        private int _currentSortIndex = 2;

        public BookСatalogForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(booksPanel, disableHorizontal: true, disableVertical: true);

            sortComboBox.SelectedIndex = _currentSortIndex;

            RestoreFilterState();
        }

        private void BookСatalogForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void SortBooks(bool applyFilters = true)
        {
            string searchQuery = FilterContext.CurrentFilterState.SearchQuery;
            int sortIndex = FilterContext.CurrentFilterState.SortIndex;
            bool descending = FilterContext.CurrentFilterState.IsDescending;

            IQueryable<Books> query = Program.context.Books;

            if (!string.IsNullOrEmpty(searchQuery) && applyFilters)
            {
                query = query.Where(book => book.Title.ToLower().Contains(searchQuery) || book.Author.ToLower().Contains(searchQuery));
            }

            switch (sortIndex)
            {
                case 0: // По новизне
                    query = descending
                        ? query.OrderByDescending(book => book.AddedDate)
                        : query.OrderBy(book => book.AddedDate);
                    break;

                case 1: // По количеству страниц
                    query = descending
                        ? query.OrderByDescending(book => book.TotalPages)
                        : query.OrderBy(book => book.TotalPages);
                    break;

                case 2: // По популярности (заглушка, аналогично сортировке по оценке)
                    query = descending
                        ? query.OrderByDescending(book => book.AverageRating)
                        : query.OrderBy(book => book.AverageRating);
                    break;

                case 3: // По оценке
                    query = descending
                        ? query.OrderByDescending(book => book.AverageRating)
                        : query.OrderBy(book => book.AverageRating);
                    break;

                case 4: // По количеству оценок
                    query = descending
                        ? query.OrderByDescending(book => Program.context.Rating.Count(r => r.BookID == book.BookID))
                        : query.OrderBy(book => Program.context.Rating.Count(r => r.BookID == book.BookID));
                    break;

                default:
                    query = descending
                        ? query.OrderByDescending(book => book.AverageRating)
                        : query.OrderBy(book => book.AverageRating);
                    break;
            }

            List<Books> books = query.ToList();

            booksPanel.Controls.Clear();

            if (books.Count > 0)
            {
                foreach (Books book in books)
                {
                    var bookControl = new MainControl(book);
                    bookControl.Margin = new Padding(9);
                    bookControl.BookClicked += BookControl_BookClicked;
                    booksPanel.Controls.Add(bookControl);
                }

                booksPanel.BackgroundImage = null;
            }
            else
            {
                booksPanel.Controls.Clear();
                booksPanel.BackgroundImage = Properties.Resources.TransparentNoResults;
            }
        }

        private void RestoreFilterState()
        {
            int sortIndex = FilterContext.CurrentFilterState.SortIndex;
            bool isDescending = FilterContext.CurrentFilterState.IsDescending;
            string searchQuery = FilterContext.CurrentFilterState.SearchQuery;

            sortComboBox.SelectedIndex = sortIndex;

            ascendingButton.Visible = !isDescending;
            descendingButton.Visible = isDescending;

            searchTextField.Text = searchQuery;

            SortBooks();
        }

        private void searchTextField_TextChanged(object sender, EventArgs e)
        {
            string result = searchTextField.Text.Trim().ToLower();

            FilterContext.CurrentFilterState.SearchQuery = result;
            FilterContext.CurrentFilterState.IsDescending = !ascendingButton.Visible;

            SortBooks();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.SortIndex = sortComboBox.SelectedIndex;
            FilterContext.CurrentFilterState.IsDescending = !ascendingButton.Visible;

            SortBooks();
        }

        private void descendingButton_Click(object sender, EventArgs e)
        {
            ascendingButton.Visible = true;
            descendingButton.Visible = false;

            FilterContext.CurrentFilterState.IsDescending = false;

            SortBooks();
        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            ascendingButton.Visible = false;
            descendingButton.Visible = true;

            FilterContext.CurrentFilterState.IsDescending = true;

            SortBooks();
        }

        private void BookControl_BookClicked(object sender, Books book)
        {
            var bookInfoForm = new BookInfoForm(book);
            VisibilityHelper.ShowNewForm(this, bookInfoForm);
            this.Hide();
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            searchTextField.Clear();
        }
    }
}