using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblio.CustomControls
{
    public partial class BookSearchControl : UserControl
    {
        private MainForm _mainForm;
        private Books _books;
        public event EventHandler<Books> BookClicked;
        public event EventHandler OpenChanged;

        public BookSearchControl(MainForm mainForm, Books books)
        {
            InitializeComponent();

            _mainForm = mainForm;

            this.OpenChanged += _mainForm.BookSearchControl_OpenChanged;

            _books = books;

            authorLabel.Text = books.Author.ToString();
            nameLabel.Text = books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(books.ImagePath);
            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            CustomizationHelper.SetRoundedRegion(this, 10, 10);

            this.Click += MainControl_Click;
            mainPanel.Click += MainControl_Click;
            bookPanel.Click += MainControl_Click;
            bookPictureBox.Click += MainControl_Click;
            authorLabel.Click += MainControl_Click;
            nameLabel.Click += MainControl_Click;
        }

        private bool _isOpen = false;

        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                _isOpen = value;
                OpenChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            IsOpen = true;
            BookClicked?.Invoke(this, _books);
        }
    }
}
