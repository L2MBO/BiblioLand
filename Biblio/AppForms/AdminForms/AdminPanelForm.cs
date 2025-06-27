using Biblio.Classes.Customization;
using Biblio.CustomControls;
using Biblio.HideClasses;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Biblio.Classes.SaveUserSettings.SaveAdminFilter;

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
            IQueryable<Users> query = Program.context.Users;

            // Применяем фильтр по поиску
            if (!string.IsNullOrEmpty(state.SearchQuery))
            {
                string searchLower = state.SearchQuery.ToLower();
                query = query.Where(user =>
                    user.Username.ToLower().Contains(searchLower));
            }

            // Применяем фильтр по описанию (если выбран)
            if (state.DescriptionIndex > 0)
            {
                switch (state.DescriptionIndex)
                {
                    case 1: // Есть описание
                        query = query.Where(user => user.Description != null);
                        break;

                    case 2: // Нет описания
                        query = query.Where(user => user.Description == null);
                        break;
                }
            }

            // Применяем сортировку
            switch (state.SortIndex)
            {
                case 0: // По имени
                    query = state.IsDescending
                        ? query.OrderByDescending(user => user.Username)
                        : query.OrderBy(user => user.Username);
                    break;

                case 1: // По дате регистрации
                    query = state.IsDescending
                        ? query.OrderByDescending(user => user.RegistrationDate)
                        : query.OrderBy(user => user.RegistrationDate);
                    break;

                case 2: // По длине описания
                    query = state.IsDescending
                        ? query.OrderByDescending(user => user.Description)
                        : query.OrderBy(user => user.Description);
                    break;

                case 3: // По роли
                    query = state.IsDescending
                        ? query.OrderByDescending(user => user.UserRoleID)
                        : query.OrderBy(user => user.UserRoleID);
                    break;

                default:
                    query = state.IsDescending
                        ? query.OrderByDescending(user => user.Username)
                        : query.OrderBy(user => user.Username);
                    break;
            }

            UpdateUsersList(query.ToList());
        }

        private void UpdateUsersList(List<Users> users)
        {
            usersPanel.Controls.Clear();

            if (users.Count > 0)
            {
                foreach (Users user in users)
                {
                    var userControl = new UserProfileControl(user);
                    userControl.Margin = new Padding(10);
                    userControl.UserClicked += UserControl_UserClicked;
                    usersPanel.Controls.Add(userControl);
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
            FilterContext.CurrentFilterState.DescriptionIndex = sortDescriptionComboBox.SelectedIndex;
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

        private void UserControl_UserClicked(object sender, Users user)
        {
            var profileForm = new ProfileForm(user.UserID, true, this);
            VisibilityHelper.ShowNewForm(this, profileForm);
            this.Hide();
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            searchTextField.Clear();
        }
    }
}
