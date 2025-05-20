using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Biblio.Classes.Customization
{
    public static class BlurImage
    {
        public static Bitmap ApplyGaussianBlur(Bitmap image, int radius)
        {
            // Ограничиваем радиус размытия
            radius = Math.Max(1, Math.Min(radius, 20));

            // Создаем гауссово ядро заранее
            float[] kernel = CreateGaussianKernel(radius);
            int kernelSize = radius * 2 + 1;
            int radiusPixels = radius;

            // Создаем копию изображения для работы
            var blurredImage = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

            // Блокируем биты изображения для быстрого доступа
            var sourceData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            var destData = blurredImage.LockBits(
                new Rectangle(0, 0, blurredImage.Width, blurredImage.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                // Получаем размеры изображения
                int width = image.Width;
                int height = image.Height;

                // Вычисляем размытие по горизонтали
                Parallel.For(0, height, y =>
                {
                    unsafe
                    {
                        byte* srcRow = (byte*)sourceData.Scan0 + y * sourceData.Stride;
                        byte* dstRow = (byte*)destData.Scan0 + y * destData.Stride;

                        for (int x = 0; x < width; x++)
                        {
                            float r = 0, g = 0, b = 0, a = 0;
                            float weightSum = 0;

                            for (int i = 0; i < kernelSize; i++)
                            {
                                int offsetX = x + i - radiusPixels;
                                offsetX = Math.Max(0, Math.Min(width - 1, offsetX));

                                byte* pixel = srcRow + offsetX * 4;
                                float weight = kernel[i * kernelSize + radiusPixels];

                                b += pixel[0] * weight;
                                g += pixel[1] * weight;
                                r += pixel[2] * weight;
                                a += pixel[3] * weight;
                                weightSum += weight;
                            }

                            byte* destPixel = dstRow + x * 4;
                            destPixel[0] = (byte)(b / weightSum);
                            destPixel[1] = (byte)(g / weightSum);
                            destPixel[2] = (byte)(r / weightSum);
                            destPixel[3] = (byte)(a / weightSum);
                        }
                    }
                });

                // Теперь размываем по вертикали
                var tempImage = (Bitmap)blurredImage.Clone();
                var tempData = tempImage.LockBits(
                    new Rectangle(0, 0, tempImage.Width, tempImage.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);

                try
                {
                    Parallel.For(0, width, x =>
                    {
                        unsafe
                        {
                            for (int y = 0; y < height; y++)
                            {
                                float r = 0, g = 0, b = 0, a = 0;
                                float weightSum = 0;

                                for (int i = 0; i < kernelSize; i++)
                                {
                                    int offsetY = y + i - radiusPixels;
                                    offsetY = Math.Max(0, Math.Min(height - 1, offsetY));

                                    byte* pixel = (byte*)tempData.Scan0 + offsetY * tempData.Stride + x * 4;
                                    float weight = kernel[radiusPixels * kernelSize + i];

                                    b += pixel[0] * weight;
                                    g += pixel[1] * weight;
                                    r += pixel[2] * weight;
                                    a += pixel[3] * weight;
                                    weightSum += weight;
                                }

                                byte* destPixel = (byte*)destData.Scan0 + y * destData.Stride + x * 4;
                                destPixel[0] = (byte)(b / weightSum);
                                destPixel[1] = (byte)(g / weightSum);
                                destPixel[2] = (byte)(r / weightSum);
                                destPixel[3] = (byte)(a / weightSum);
                            }
                        }
                    });
                }
                finally
                {
                    tempImage.UnlockBits(tempData);
                }
            }
            finally
            {
                image.UnlockBits(sourceData);
                blurredImage.UnlockBits(destData);
            }

            return blurredImage;
        }

        private static float[] CreateGaussianKernel(int radius)
        {
            int size = radius * 2 + 1;
            float[] kernel = new float[size * size];
            float sigma = radius / 2f;
            float sum = 0;

            // Вычисляем ядро Гаусса
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    float value = (float)Math.Exp(-(x * x + y * y) / (2 * sigma * sigma));
                    kernel[(y + radius) * size + (x + radius)] = value;
                    sum += value;
                }
            }

            // Нормализуем ядро
            for (int i = 0; i < kernel.Length; i++)
                kernel[i] /= sum;

            return kernel;
        }
    }
}