using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Biblio.Classes.Customization
{
    public static class WhiteLevelReducer
    {
        public static Bitmap ReduceWhiteLevel(Bitmap image, float reductionFactor = 0.7f)
        {
            // Проверка и корректировка коэффициента
            reductionFactor = Math.Max(0.1f, Math.Min(1.0f, reductionFactor));

            // Создаем копию изображения для работы
            var resultImage = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

            // Блокируем биты изображения для быстрого доступа
            var sourceData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            var destData = resultImage.LockBits(
                new Rectangle(0, 0, resultImage.Width, resultImage.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                // Получаем размеры изображения
                int width = image.Width;
                int height = image.Height;

                // Параллельно обрабатываем изображение
                Parallel.For(0, height, y =>
                {
                    unsafe
                    {
                        byte* srcRow = (byte*)sourceData.Scan0 + y * sourceData.Stride;
                        byte* dstRow = (byte*)destData.Scan0 + y * destData.Stride;

                        for (int x = 0; x < width; x++)
                        {
                            byte* srcPixel = srcRow + x * 4;
                            byte* dstPixel = dstRow + x * 4;

                            // Получаем цветовые компоненты
                            int b = srcPixel[0];
                            int g = srcPixel[1];
                            int r = srcPixel[2];
                            int a = srcPixel[3];

                            // Вычисляем яркость пикселя (0-255)
                            float brightness = (r + g + b) / 3.0f;

                            // Коэффициент затемнения (чем ярче пиксель, тем сильнее затемняем)
                            float darkenFactor = 1.0f - (brightness / 255.0f * (1.0f - reductionFactor));

                            // Применяем затемнение
                            dstPixel[0] = (byte)(b * darkenFactor);
                            dstPixel[1] = (byte)(g * darkenFactor);
                            dstPixel[2] = (byte)(r * darkenFactor);
                            dstPixel[3] = (byte)a; // Альфа-канал оставляем без изменений
                        }
                    }
                });
            }
            finally
            {
                image.UnlockBits(sourceData);
                resultImage.UnlockBits(destData);
            }

            return resultImage;
        }

        public static Bitmap PrepareBackground(Bitmap image, int blurRadius = 5, float whiteReduction = 0.6f)
        {
            // Сначала применяем размытие
            var blurred = BlurImage.ApplyGaussianBlur(image, blurRadius);

            // Затем уменьшаем уровень белого
            return ReduceWhiteLevel(blurred, whiteReduction);
        }
    }
}