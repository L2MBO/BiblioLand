using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Biblio.Classes.SaveUserSettings.SaveUserFilter;

namespace Biblio.AppForms
{
    public partial class BookСatalogForm : Form
    {
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

            // Инициализация UI из сохраненного состояния
            sortComboBox.SelectedIndex = FilterContext.CurrentFilterState.SortIndex;
            searchTextField.Text = FilterContext.CurrentFilterState.SearchQuery;
            UpdateSortButtons();

            // Первоначальная загрузка данных
            ApplyFiltersAndSort();
        }

        private void UpdateSortButtons()
        {
            ascendingButton.Visible = !FilterContext.CurrentFilterState.IsDescending;
            descendingButton.Visible = FilterContext.CurrentFilterState.IsDescending;
        }

        private void ApplyFiltersAndSort()
        {
            var state = FilterContext.CurrentFilterState;
            IQueryable<Books> query = Program.context.Books;

            // Применяем поиск
            if (!string.IsNullOrEmpty(state.SearchQuery))
            {
                string searchLower = state.SearchQuery.ToLower();
                query = query.Where(book =>
                    book.Title.ToLower().Contains(searchLower) ||
                    book.Author.ToLower().Contains(searchLower));
            }

            // Применяем сортировку
            switch (state.SortIndex)
            {
                case 0: // По новизне
                    query = state.IsDescending
                        ? query.OrderByDescending(book => book.AddedDate)
                        : query.OrderBy(book => book.AddedDate);
                    break;

                case 1: // По количеству оценок
                    query = state.IsDescending
                        ? query.OrderByDescending(book => Program.context.Rating.Count(r => r.BookID == book.BookID))
                        : query.OrderBy(book => Program.context.Rating.Count(r => r.BookID == book.BookID));
                    break;

                case 2: // По популярности
                case 3: // По оценке
                    query = state.IsDescending
                        ? query.OrderByDescending(book => book.AverageRating)
                        : query.OrderBy(book => book.AverageRating);
                    break;

                default:
                    query = state.IsDescending
                        ? query.OrderByDescending(book => book.AverageRating)
                        : query.OrderBy(book => book.AverageRating);
                    break;
            }

            UpdateBooksList(query.ToList());
        }

        private void UpdateBooksList(List<Books> books)
        {
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
                booksPanel.BackgroundImage = Properties.Resources.TransparentNoResults;
            }
        }

        private void BookСatalogForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void searchTextField_TextChanged(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.SearchQuery = searchTextField.Text.Trim();
            clearTextButton.Visible = !string.IsNullOrEmpty(searchTextField.Text);
            ApplyFiltersAndSort();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.SortIndex = sortComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void descendingButton_Click(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.IsDescending = false;
            UpdateSortButtons();
            ApplyFiltersAndSort();
        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.IsDescending = true;
            UpdateSortButtons();
            ApplyFiltersAndSort();
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