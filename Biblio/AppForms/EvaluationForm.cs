using Biblio.Classes.Customization;
using Biblio.Models;
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

namespace Biblio.AppForms
{
    public partial class EvaluationForm : Form
    {
        private Books _book;
        private int _currentUserId;
        private Rating _existingRating;
        private Guna2Button _evaluateButton;

        public EvaluationForm(Books book, int currentUserId, Guna2Button evaluateButton)
        {
            InitializeComponent();

            _book = book;
            _currentUserId = currentUserId;
            _evaluateButton = evaluateButton;

            LoadExistingRating();
            UpdateButtonColors();
            UpdateEvaluateButtonText();
        }

        private void LoadExistingRating()
        {
            _existingRating = Program.context.Rating.FirstOrDefault(r =>
                r.UserID == _currentUserId && r.BookID == _book.BookID);
        }

        private void UpdateButtonColors()
        {
            int selectedRating = _existingRating?.Rating1 ?? 0;

            for (int i = 1; i <= 10; i++)
            {
                var button = this.Controls.Find($"ratingButton{i}", true).FirstOrDefault() as Guna2CircleButton;

                if (button != null)
                {
                    if (i <= selectedRating)
                    {
                        button.FillColor = Color.FromArgb(60, 132, 246);
                    }
                    else
                    {
                        button.FillColor = Color.FromArgb(30, 31, 34);
                    }
                }
            }
        }

        public void UpdateEvaluateButtonText()
        {
            if (_evaluateButton != null)
            {
                if (_existingRating != null)
                {
                    _evaluateButton.Text = $"Оценка: " + _existingRating.Rating1;
                }
                else
                {
                    _evaluateButton.Text = "Оценить";
                }
            }
        }

        private void SaveOrUpdateRating(int rating)
        {
            var existingRating = Program.context.Rating.FirstOrDefault(r =>
                r.UserID == _currentUserId && r.BookID == _book.BookID);

            if (existingRating != null)
            {
                // Если оценка существует и пользователь нажал ту же кнопку
                if (existingRating.Rating1 == rating)
                {
                    Program.context.Rating.Remove(existingRating);
                    Program.context.SaveChanges();
                }
                else
                {
                    existingRating.Rating1 = rating;
                    Program.context.SaveChanges();
                }
            }
            else
            {
                var newRating = new Rating
                {
                    UserID = _currentUserId,
                    BookID = _book.BookID,
                    Rating1 = rating
                };
                Program.context.Rating.Add(newRating);
                Program.context.SaveChanges();
            }

            LoadExistingRating();
            UpdateButtonColors();
            UpdateEvaluateButtonText();
        }

        private void HandleRatingButtonClick(object sender, EventArgs e)
        {
            var button = (Guna2CircleButton)sender;
            int rating = int.Parse(button.Name.Replace("ratingButton", ""));

            SaveOrUpdateRating(rating);

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
