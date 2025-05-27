using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Biblio.Classes.Animations
{
    internal class FormAnimationHelper
    {
        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        // Флаги анимации
        private enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x0001,  // Слева направо
            AW_HOR_NEGATIVE = 0x0002,  // Справа налево
            AW_VER_POSITIVE = 0x0004,  // Сверху вниз
            AW_VER_NEGATIVE = 0x0008,  // Снизу вверх
            AW_CENTER = 0x0010,        // Появление из центра
            AW_HIDE = 0x10000,         // Скрытие окна
            AW_ACTIVATE = 0x20000,     // Активация окна
            AW_SLIDE = 0x40000,        // Скользящая анимация
            AW_BLEND = 0x80000         // Плавное появление/исчезновение
        }

        // Метод для анимации изменения размера
        public static void AnimateResize(Form form, int durationMs)
        {
            // Плавное появление/изменение (можно менять флаги)
            AnimateWindow(form.Handle, durationMs, AnimateWindowFlags.AW_BLEND);
        }
    }
}
