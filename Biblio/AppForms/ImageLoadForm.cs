using Biblio.Classes.Coding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class ImageLoadForm : Form
    {
        private int _currentUserId;
        public string Base64Avatar { get; private set; }

        public ImageLoadForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png";
                openFileDialog.Title = "Выберите изображение";

                string screenshotsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    "Screenshots");

                if (Directory.Exists(screenshotsPath))
                {
                    openFileDialog.InitialDirectory = screenshotsPath;
                }
                else
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Base64Avatar = CodingOrDecoding.ImageCoding(filePath);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
