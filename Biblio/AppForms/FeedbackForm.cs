using Biblio.Classes.Customization;
using Biblio.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class FeedbackForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;
        private int _selectedCategory = 0;

        public FeedbackForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);
        }

        private void SelectButtonLogic(Guna2Button selectedButton, int category)
        {
            var buttons = new List<Guna2Button> { likeButton, bugButton, hateButton, ideaButton };

            // Если нажали на уже выбранную кнопку - снимаем выделение и скрываем панель
            if (selectedButton.Checked)
            {
                selectedButton.Checked = false;
                feedbackPanel.Visible = false;
                _selectedCategory = 0;
                return;
            }

            // Выделяем новую кнопку и настраиваем интерфейс
            foreach (var button in buttons)
            {
                button.Checked = (button == selectedButton);
            }

            feedbackPanel.Visible = true;

            switch (category)
            {
                case 1: // Like
                    titleTextField.PlaceholderText = "Что вам больше всего нравится?";
                    descriptionTextField.PlaceholderText = "Расскажите, почему вам это нравится или как мы можем сделать приложение еще лучше!";
                    break;
                case 2: // Hate
                    titleTextField.PlaceholderText = "Что вам не нравится?";
                    descriptionTextField.PlaceholderText = "Расскажите что вам не нравится и почему.";
                    break;
                case 3: // Bug
                    titleTextField.PlaceholderText = "С какой ошибкой вы столкнулись?";
                    descriptionTextField.PlaceholderText = "Расскажите, когда и при каких условиях возникает ошибка.";
                    break;
                case 4: // Idea
                    titleTextField.PlaceholderText = "Как вкратце можно описать идею?";
                    descriptionTextField.PlaceholderText = "Опишите, что должна делать функция, как ее получить и как она должна выглядеть.";
                    break;
            }

            _selectedCategory = category;
        }

        private bool IsFieldsEmpty()
        {
            bool isTitleEmpty = string.IsNullOrWhiteSpace(titleTextField.Text);
            bool isDescriptionEmpty = string.IsNullOrWhiteSpace(descriptionTextField.Text);
            bool isEmpty = isTitleEmpty || isDescriptionEmpty;

            if (isEmpty)
            {
                titleTextField.BorderColor = isTitleEmpty ? Color.Red : Color.FromArgb(64, 64, 64);
                descriptionTextField.BorderColor = isDescriptionEmpty ? Color.Red : Color.FromArgb(64, 64, 64);

                // Таймер для сброса подсветки через 1 секунду
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (sender, e) =>
                {
                    titleTextField.BorderColor = Color.FromArgb(64, 64, 64);
                    descriptionTextField.BorderColor = Color.FromArgb(64, 64, 64);
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }

            return isEmpty;
        }

        private void FeedbackValidation()
        {
            if (IsFieldsEmpty())
            {
                return;
            }

            int category = _selectedCategory;
            string title = titleTextField.Text;
            string description = descriptionTextField.Text;

            try
            {
                SaveFeedbackToDatabase(category, title, description);

                titleTextField.Text = "";
                descriptionTextField.Text = "";
                feedbackPanel.Visible = false;

                var buttons = new List<Guna2Button> { likeButton, bugButton, hateButton, ideaButton };
                foreach (var button in buttons)
                {
                    button.Checked = false;
                }

                _selectedCategory = 0;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка при сохранении");
            }
        }

        private void SaveFeedbackToDatabase(int category, string title, string description)
        {
            var feedback = new Feedback
            {
                UserID = _currentUserId,
                FeedbackCategoryID = category,
                FeedbackTitle = title,
                FeedbackMessage = description,
                FeedbackDate = DateTime.Now
            };

            Program.context.Feedback.Add(feedback);
            Program.context.SaveChanges();

            MessageBox.Show("Спасибо за ваш отзыв!");
        }

        private int CalculateTextBoxHeight(string text, Font font, int width)
        {
            string adjustedText = text.Length > 0 ? Environment.NewLine + Environment.NewLine + text : text;

            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(adjustedText, font, new Size(width, 0),
                    TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height) + descriptionTextField.Margin.Vertical + descriptionTextField.Padding.Vertical;
            }
        }

        private void FeedbackForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);

            if (this.WindowState == FormWindowState.Maximized)
            {
                leftPanel.Width = 500;
                rightPanel.Width = 500;
                leftButtonPanel.Width = 460;
                atentionLabel.Text = "Мы стараемся отвечать на все ваши сообщения, поэтому, пожалуйста, удостоверьтесь, что у вас привязана актуальная почта.";
            }
            else
            {
                leftPanel.Width = 100;
                rightPanel.Width = 100;
                leftButtonPanel.Width = 263;
                atentionLabel.Text = "Пожалуйста, удостоверьтесь, что у вас привязана актуальная почта.";
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int textBoxWidth = descriptionTextField.Width;

            int preferredHeight = CalculateTextBoxHeight(descriptionTextField.Text, descriptionTextField.Font, textBoxWidth);

            descriptionTextField.Height = preferredHeight;

            feedbackPanel.PerformLayout();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            SelectButtonLogic(likeButton, 1);
        }

        private void hateButton_Click(object sender, EventArgs e)
        {
            SelectButtonLogic(hateButton, 2);
        }

        private void bugButton_Click(object sender, EventArgs e)
        {
            SelectButtonLogic(bugButton, 3);
        }

        private void ideaButton_Click(object sender, EventArgs e)
        {
            SelectButtonLogic(ideaButton, 4);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            FeedbackValidation();
        }
    }
}
