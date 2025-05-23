﻿using Biblio.AppForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Interface;
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
        private Books _books;
        public event EventHandler<Books> BookClicked;
        public event EventHandler OpenChanged;
        private IAvatarParentForm _parent;

        public BookSearchControl(Form parentForm, Books books)
        {
            InitializeComponent();

            _parent = parentForm as IAvatarParentForm;

            if (_parent != null)
            {
                OpenChanged += _parent.OnControlOpenChanged;
            }

            _books = books;

            authorLabel.Text = books.Author.ToString();
            nameLabel.Text = books.Title.ToString();

            Image image = ImageLoader.LoadBookImage(books.ImagePath);
            if (image != null)
            {
                bookPictureBox.Image = image;
            }

            RoundingHelper.SetRoundedRegion(this, 10, 10);

            this.Click += MainControl_Click;
            mainPanel.Click += MainControl_Click;
            bookPanel.Click += MainControl_Click;
            bookPictureBox.Click += MainControl_Click;
            authorLabel.Click += MainControl_Click;
            nameLabel.Click += MainControl_Click;
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            OpenChanged?.Invoke(this, EventArgs.Empty);
            BookClicked?.Invoke(this, _books);
        }
    }
}
