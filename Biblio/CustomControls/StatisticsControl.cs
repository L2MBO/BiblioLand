﻿using Biblio.Models;
using Guna.UI2.WinForms;
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

            this.DoubleBuffered = true;

            _book = books;

            var rating = _book.AverageRating;

            overageRatingLabel.Text = "Рейтинг за последнее время: " + rating;

            LoadRatings();
            LoadBookmarks();
        }

        private void LoadRatings()
        {
            int bookId = _book.BookID;

            var ratings = Program.context.Rating.Where(r => r.BookID == bookId).ToList();

            int[] ratingCounts = new int[11];

            foreach (var rating in ratings)
            {
                ratingCounts[(int)rating.Rating1]++;
            }

            int totalRatings = ratings.Count;

            for (int i = 1; i <= 10; i++)
            {
                var progressControl = this.Controls.Find($"ratingProgress{i}", true).FirstOrDefault() as Guna2ProgressBar;
                var labelControl = this.Controls.Find($"ratingCount{i}", true).FirstOrDefault() as Label;

                if (progressControl != null && labelControl != null)
                {
                    int count = ratingCounts[i];
                    double percentage = totalRatings > 0 ? (double)count / totalRatings * 100 : 0;

                    progressControl.Value = (int)percentage;
                    labelControl.Text = count.ToString();
                }
            }
        }

        private void LoadBookmarks()
        {
            int bookId = _book.BookID;

            var bookmarks = Program.context.UserBooks.Where(b => b.BookID == bookId).ToList();

            Dictionary<int, int> bookmarkCounts = new Dictionary<int, int>();

            foreach (var bookmark in bookmarks)
            {
                int categoryId = (int)bookmark.CategoryID;

                if (bookmarkCounts.ContainsKey(categoryId))
                {
                    bookmarkCounts[categoryId]++;
                }
                else
                {
                    bookmarkCounts[categoryId] = 1;
                }
            }

            for (int i = 1; i <= 6; i++)
            {
                var progressControl = this.Controls.Find($"categoryProgress{i}", true).FirstOrDefault() as Guna2ProgressBar;
                var labelControl = this.Controls.Find($"categoryCount{i}", true).FirstOrDefault() as Label;

                if (progressControl != null && labelControl != null)
                {
                    int count = bookmarkCounts.ContainsKey(i) ? bookmarkCounts[i] : 0;
                    double totalBookmarks = bookmarks.Count;

                    double percentage = totalBookmarks > 0 ? (double)count / totalBookmarks * 100 : 0;

                    progressControl.Value = (int)percentage;
                    labelControl.Text = count.ToString();
                }
            }
        }
    }
}
