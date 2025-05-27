using System.Drawing;

namespace Biblio.Classes.Customization.ImagesCustomization
{
    internal class BackgroundImageRenderer
    {
        private Image backgroundImage; // Исходное изображение

        public void SetBackgroundImage(Image image)
        {
            backgroundImage = image;
        }

        public void DrawBackgroundImage(Graphics graphics, int panelWidth, int panelHeight, int scrollY)
        {
            if (backgroundImage == null)
                return;

            // Получаем размеры исходного изображения
            int imageWidth = backgroundImage.Width;
            int imageHeight = backgroundImage.Height;

            // Вычисляем масштабирование по ширине
            float scaleFactor = (float)panelWidth / imageWidth;
            int scaledHeight = (int)(imageHeight * scaleFactor);

            // Если новая высота больше высоты панели, обрезаем изображение
            if (scaledHeight > panelHeight)
            {
                // Определяем часть изображения, которая должна быть отображена
                int visibleImageHeight = (int)(panelHeight / scaleFactor); // Высота видимой части изображения

                // Вычисляем начальную координату Y для отображаемой части изображения
                int startImageY = (int)(scrollY / scaleFactor); // Преобразуем смещение прокрутки в координаты изображения

                // Рисуем только нужную часть изображения
                graphics.DrawImage(
                    backgroundImage,
                    new Rectangle(0, 0, panelWidth, panelHeight), // Регион на панели
                    new Rectangle(0, startImageY, imageWidth, visibleImageHeight), // Часть изображения
                    GraphicsUnit.Pixel
                );
            }
            else
            {
                // Если изображение поместится полностью, растягиваем его
                graphics.DrawImage(
                    backgroundImage,
                    new Rectangle(0, 0, panelWidth, scaledHeight)
                );
            }
        }
    }
}
