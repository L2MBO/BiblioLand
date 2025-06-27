using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Biblio.Classes.SaveUserSettings.SaveUserFilter;

namespace Biblio.AppForms
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(usersPanel, disableHorizontal: true, disableVertical: true);

            UpdateSortButtons();
            ApplyFiltersAndSort();
        }

        private void UpdateSortButtons()
        {
            
        }

        private void ApplyFiltersAndSort()
        {
            var state = FilterContext.CurrentFilterState;
            IQueryable<Books> query = Program.context.Books;

            // Применяем фильтр по поиску
            if (!string.IsNullOrEmpty(state.SearchQuery))
            {
                string searchLower = state.SearchQuery.ToLower();
                query = query.Where(book =>
                    book.Title.ToLower().Contains(searchLower) ||
                    book.Author.ToLower().Contains(searchLower));
            }

            // Применяем фильтр по жанру (если выбран)
            if (state.GenreIndex > 0)
            {
                query = query.Where(book => book.GenreID == state.GenreIndex);
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
                    query = state.IsDescending
                        ? query.OrderByDescending(book => Program.context.Reviews.Count(r => r.BookID == book.BookID))
                        : query.OrderBy(book => Program.context.Reviews.Count(r => r.BookID == book.BookID));
                    break;

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
            usersPanel.Controls.Clear();

            if (books.Count > 0)
            {
                foreach (Books book in books)
                {
                    var bookControl = new MainControl(book);
                    bookControl.Margin = new Padding(10);
                    bookControl.BookClicked += UserControl_UserClicked;
                    usersPanel.Controls.Add(bookControl);
                }
                usersPanel.BackgroundImage = null;
            }
            else
            {
                usersPanel.BackgroundImage = Properties.Resources.TransparentNoResults;
            }
        }

        private void AdminPanelForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                sortPanel.Width = 214;
                sortComboBox.Width = 184;
                descendingButton.Location = new Point(189, 8);
                ascendingButton.Location = new Point(189, 8);
                searchTextField.PlaceholderText = "Поиск по имени";
            }
            else
            {
                sortPanel.Width = 194;
                sortComboBox.Width = 164;
                descendingButton.Location = new Point(169, 8);
                ascendingButton.Location = new Point(169, 8);
                searchTextField.PlaceholderText = "По имени";
            }
        }

        private void AdminPanelForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void searchTextField_TextChanged(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.SearchQuery = searchTextField.Text.Trim();
            clearTextButton.Visible = !string.IsNullOrEmpty(searchTextField.Text);
            ApplyFiltersAndSort();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FilterContext.CurrentFilterState.SortIndex = sortComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void sortDescriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterContext.CurrentFilterState.GenreIndex = sortDescriptionComboBox.SelectedIndex;
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

        private void UserControl_UserClicked(object sender, Books book)
        {
            /////////
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
