using Biblio.Classes.Customization;
using Biblio.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class BookmarksControl : UserControl
    {
        private Books _book;
        private int _currentUserId;
        private bool _isBookmarked;

        public event EventHandler<CategorySelectedEventArgs> CategorySelected;
        public event EventHandler BookmarkRemoved;

        public BookmarksControl(Books book, int currentUserId)
        {
            InitializeComponent();

            _book = book;
            _currentUserId = currentUserId;

            RoundingHelper.SetRoundedRegion(this, 36, 36);

            InitializeUI();
        }

        private void InitializeUI()
        {
            // Загрузка текущего состояния закладки
            LoadBookmarkStatus();

            removeBookmarkButton.Visible = _isBookmarked;
        }

        public void LoadBookmarkStatus()
        {
            var bookmark = Program.context.UserBookmarks.FirstOrDefault(
                    b => b.UserID == _currentUserId && b.BookID == _book.BookID);

            if (bookmark != null)
            {
                _isBookmarked = true;

                // Выбрать текущую категорию
                switch (bookmark.CategoryID)
                {
                    case 1:
                        categoryButton3.FillColor = Color.FromArgb(60, 132, 246);
                        OnCategorySelected(new CategorySelectedEventArgs("Прочитано"));
                        break;
                    case 2:
                        categoryButton1.FillColor = Color.FromArgb(60, 132, 246);
                        OnCategorySelected(new CategorySelectedEventArgs("Читаю"));
                        break;
                    case 3:
                        categoryButton2.FillColor = Color.FromArgb(60, 132, 246);
                        OnCategorySelected(new CategorySelectedEventArgs("Буду читать"));
                        break;
                    case 4:
                        categoryButton5.FillColor = Color.FromArgb(60, 132, 246);
                        OnCategorySelected(new CategorySelectedEventArgs("Отложено"));
                        break;
                    case 5:
                        categoryButton4.FillColor = Color.FromArgb(60, 132, 246);
                        OnCategorySelected(new CategorySelectedEventArgs("Брошено"));
                        break;
                }
            }
            else
            {
                _isBookmarked = false;
                ResetCategorySelection();
                OnBookmarkRemoved(EventArgs.Empty);
            }

            Console.WriteLine($"LoadBookmarkStatus: IsBookmarked = {_isBookmarked}");
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            if (button == null) return;

            var bookmark = Program.context.UserBookmarks.FirstOrDefault(
                    b => b.UserID == _currentUserId && b.BookID == _book.BookID);

            if (bookmark == null)
            {
                // Добавляем новую закладку
                bookmark = new UserBookmarks
                {
                    UserID = _currentUserId,
                    BookID = _book.BookID,
                    LastReadDate = DateTime.Now,
                    CategoryID = GetCategoryID(button.Text)
                };

                Program.context.UserBookmarks.Add(bookmark);
            }
            else
            {
                // Обновляем существующую закладку
                bookmark.CategoryID = GetCategoryID(button.Text);
            }

            Program.context.SaveChanges();

            // Обновляем выделение
            ResetCategorySelection();
            this.Hide();

            OnCategorySelected(new CategorySelectedEventArgs(button.Text));

            Console.WriteLine($"CategoryButton_Click: Category = {button.Text}");
        }

        private void RemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            var bookmark = Program.context.UserBookmarks.FirstOrDefault(
                    b => b.UserID == _currentUserId && b.BookID == _book.BookID);

            if (bookmark != null)
            {
                Program.context.UserBookmarks.Remove(bookmark);
                Program.context.SaveChanges();
            }

            // Обновляем UI
            _isBookmarked = false;
            ResetCategorySelection();
            this.Hide();

            OnBookmarkRemoved(EventArgs.Empty);
        }

        private int GetCategoryID(string categoryName)
        {
            switch (categoryName)
            {
                case "Прочитано": return 1;
                case "Читаю": return 2;
                case "Буду читать": return 3;
                case "Отложено": return 4;
                case "Брошено": return 5;
                default: return 0;
            }
        }

        private void ResetCategorySelection()
        {
            categoryButton1.FillColor = Color.FromArgb(26, 27, 30);
            categoryButton2.FillColor = Color.FromArgb(26, 27, 30);
            categoryButton3.FillColor = Color.FromArgb(26, 27, 30);
            categoryButton4.FillColor = Color.FromArgb(26, 27, 30);
            categoryButton5.FillColor = Color.FromArgb(26, 27, 30);
        }

        protected virtual void OnCategorySelected(CategorySelectedEventArgs e)
        {
            CategorySelected?.Invoke(this, e);
        }

        protected virtual void OnBookmarkRemoved(EventArgs e)
        {
            BookmarkRemoved?.Invoke(this, e);
        }
    }

    public class CategorySelectedEventArgs : EventArgs
    {
        public string CategoryName { get; }

        public CategorySelectedEventArgs(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
