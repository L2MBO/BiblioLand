using System;
using System.IO;
using System.Linq;
using System.Drawing;

namespace Biblio.Classes.Coding
{
    internal class Coding
    {
        public static byte[] ImageCoding(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    return File.ReadAllBytes(imagePath);
                }
                catch (Exception ex)
                {
                    throw new IOException($"Ошибка при чтении файла: {imagePath}", ex);
                }
            }

            // Если путь не предоставлен, используем встроенный ресурс
            var bitmap = Properties.Resources.defaultAvatar;

            if (bitmap == null)
            {
                throw new InvalidOperationException("Ресурс defaultAvatar недоступен.");
            }

            using (var memoryStream = new MemoryStream())
            {
                // Сохраняем Bitmap в MemoryStream в формате PNG
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                // Получаем байты из MemoryStream
                return memoryStream.ToArray();
            }
        }
    }
}