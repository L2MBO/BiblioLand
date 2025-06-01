using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Biblio.Classes.Coding
{
    internal class CodingOrDecoding
    {
        static string _logPath = "errorUserImages.txt";

        public static string ImageCoding(string imagePath)
        {
            try
            {
                byte[] imageBytes;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    using (var bitmap = new Bitmap(Image.FromFile(imagePath)))

                    using (var memoryStream = new MemoryStream())
                    {
                        bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = memoryStream.ToArray();
                    }
                }
                else
                {
                    // Если путь не предоставлен, используем встроенный ресурс
                    var bitmap = Properties.Resources.defaultAvatar;

                    if (bitmap == null)
                        throw new InvalidOperationException("Ресурс defaultAvatar недоступен.");

                    // Сохраняем Bitmap в MemoryStream в формате PNG
                    using (var memoryStream = new MemoryStream())
                    {
                        bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = memoryStream.ToArray();
                    }
                }

                // Преобразуем массив байтов в строку Base64
                return Convert.ToBase64String(imageBytes);
            }
            catch (IOException ex)
            {
                File.AppendAllText(_logPath, $"[{DateTime.Now}] Ошибка при чтении файла: {imagePath}\n{ex.Message}\n");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                File.AppendAllText(_logPath, $"[{DateTime.Now}] Ошибка при работе с ресурсом: {ex.Message}\n");
                throw;
            }
            catch (Exception ex)
            {
                File.AppendAllText(_logPath, $"[{DateTime.Now}] Неожиданная ошибка: {ex.Message}\n");
                throw;
            }
        }

        public static void SetImageFromBase64(PictureBox pictureBox, string base64String)
        {
            try
            {
                // Преобразуем Base64 строку в массив байтов
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Создаем MemoryStream из массива байтов
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    // Загружаем изображение из потока
                    Image image = Image.FromStream(memoryStream);

                    // Устанавливаем изображение в PictureBox
                    pictureBox.Image = image;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(_logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения:{ex.Message}\n");
            }
        }
    }
}