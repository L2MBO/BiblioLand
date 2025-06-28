using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Classes.Validation;
using Biblio.Models;
using System;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class LastUpdatesControl : UserControl
    {
        private Form _parentForm;
        private Panel _parentPanel;
        private Books _book;
        public event EventHandler<Books> BookClicked;

        public LastUpdatesControl(Form parentForm, Panel parentPanel, Books books)
        {
            InitializeComponent();

            InitializeControl(parentForm, parentPanel, books);
        }

        private void InitializeControl(Form parentForm, Panel parentPanel, Books book)
        {
            _parentForm = parentForm;
            _book = book;
            _parentPanel = parentPanel;

            this.Width = _parentForm.WindowState == FormWindowState.Maximized ? 1300 : 460;

            authorLabel.Text = _book.Author;
            nameLabel.Text = _book.Title;
            bookPictureBox.Image = ImageLoader.LoadBookImage(_book.ImageName);
            RoundingHelper.SetRoundedRegion(this, 30, 30);

            _parentForm.Resize += ParentForm_Resize;
        }

        private void ParentForm_Resize(object sender, EventArgs e)
        {
            // Отписываемся от события перед пересозданием
            _parentForm.Resize -= ParentForm_Resize;

            // Получаем текущую позицию и данные
            int index = _parentPanel.Controls.IndexOf(this);
            DateTime now = DateTime.Now;

            // Удаляем текущий контрол
            _parentPanel.Controls.Remove(this);
            this.Dispose();

            // Создаем новый экземпляр
            var newControl = new LastUpdatesControl(_parentForm, _parentPanel, _book);
            TimeSpan timeDifference = (TimeSpan)(now - _book.AddedDate);
            string timeAgo = TimeValidation.FormatTimeAgo(timeDifference);
            newControl.SetTime(timeAgo);
            newControl.Margin = new Padding(10);

            // Восстанавливаем позицию
            _parentPanel.Controls.Add(newControl);
            _parentPanel.Controls.SetChildIndex(newControl, index);
        }

        public void SetTime(string time)
        {
            timeLabel.Text = time;
        }

        private void LastUpdatesControl_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, _book);
        }
    }
}
