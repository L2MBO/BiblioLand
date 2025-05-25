using Biblio.Classes.Coding;
using Biblio.Classes.DataAccess;
using Biblio.ValidationClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.Classes.Images.InstallingImages
{
    internal class ImageLoader
    {
        private static readonly string _path = "C:\\Users\\lamki\\Documents\\BiblioLandRes\\bookImg\\";

        public static Image LoadBookImage(string imagePath)
        {
            string fullImagePath = _path + imagePath;

            if (string.IsNullOrEmpty(fullImagePath) || !File.Exists(fullImagePath))
            {
                return Properties.Resources.defaultBookImage;
            }

            try
            {
                return Image.FromFile(fullImagePath);
            }
            catch (Exception ex)
            {
                string logPath = "errorBookImages_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения: {ex.Message}\n");
                return Properties.Resources.defaultBookImage;
            }
        }

        public static void LoadAvatarImage(PictureBox avatarImage)
        {
            int currentUserId = Program.CurrentUser.UserID;

            try
            {
                string base64Image = UserAvatarDataHelper.GetBase64ImageFromDatabase(currentUserId);

                CodingOrDecoding.SetImageFromBase64(avatarImage, base64Image);
            }
            catch (Exception ex)
            {
                string logPath = "errorUserImages.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения из базы данных:{ex.Message}\n");
            }
        }
    }
}
