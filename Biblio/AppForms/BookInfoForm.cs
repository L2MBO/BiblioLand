using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Biblio.AppForms
{
    public partial class BookInfoForm : MaterialForm
    {
        private Books _book;

        public BookInfoForm(Books book)
        {
            InitializeComponent();
            //AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: false, disableVertical: true);
            _book = book;
            
            descriptionLabel.TextChanged += DescriptionLabel_TextChanged;

            LoadBookInfo();
             
        }

        private void LoadBookInfo()
        {
            nameLabel.Text = _book.Title;
            authorLabel.Text = _book.Author;
            descriptionLabel.Text = _book.Description;

            //raitingLabel.Text = ((double)_book.AverageRating).ToString("F1", CultureInfo.InvariantCulture);

            //Image image = ImageLoader.LoadBookImage(_book.ImagePath);
            //if (image != null)
            //{
            //    //bookPictureBox.Image = image;
            //}
        }

        private void DescriptionLabel_TextChanged(object sender, EventArgs e)
        {
            // Получаем ширину Label
            int labelWidth = descriptionLabel.Width;

            // Рассчитываем высоту текста с учетом ширины Label
            int preferredHeight = CalculateLabelHeight(descriptionLabel.Text, descriptionLabel.Font, labelWidth);

            // Устанавливаем высоту Label
            descriptionLabel.Height = preferredHeight;

            // Обновляем размеры панели
            descriptionPanel.PerformLayout();
        }

        private int CalculateLabelHeight(string text, Font font, int width)
        {
            // Создаем Graphics для текущего контекста
            using (Graphics graphics = this.CreateGraphics())
            {
                // Рассчитываем размеры текста с учетом ширины Label
                SizeF textSize = TextRenderer.MeasureText(text, font, new Size(width, 0), TextFormatFlags.WordBreak);

                // Возвращаем общую высоту текста
                return (int)Math.Ceiling(textSize.Height);
            }
        }
    }
}
