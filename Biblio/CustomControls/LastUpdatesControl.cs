using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class LastUpdatesControl : UserControl
    {
        private Books _books;
        public event EventHandler<Books> BookClicked;
        public event EventHandler OpenChanged;

        public LastUpdatesControl(Books books)
        {
            InitializeComponent();

            //this.Width = 800;

            MainForm.IsMaximizeChanged += MainForm_IsMaximizeChanged;

            _books = books;

            authorLabel.Text = books.Author.ToString();
            nameLabel.Text = books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(books.ImagePath);
            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            RoundingHelper.SetRoundedRegion(this, 30, 30);
            RoundingHelper.SetRoundedRegion(bookPictureBox, 20, 20);

            timeLabel.Font = new Font(timeLabel.Font.FontFamily, 8, FontStyle.Regular);

            this.Click += MainControl_Click;
            
            middlePanel.Click += MainControl_Click;
            authorLabel.Click += MainControl_Click;
            nameLabel.Click += MainControl_Click;
            infoPanel.Click += MainControl_Click;
            bookPictureBox.Click += MainControl_Click;
            rightPanel.Click += MainControl_Click;
            timeLabel.Click += MainControl_Click;
            timePanel.Click += MainControl_Click;
        }

        private void MainForm_IsMaximizeChanged(object sender, EventArgs e)
        {
            ChangeWidth();
        }

        public void ChangeWidth()
        {
            if (MainForm.isMaximize)
            {
                this.Width = 800;
                this.BackColor = Color.Red;
            }
            else
            {
                this.Width = 465;
                this.BackColor = Color.White;
            }
            
            this.Refresh();
        }

        public void SetTime(string time)
        {
            timeLabel.Text = time;
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            BookClicked?.Invoke(this, _books);
        }
    }
}
