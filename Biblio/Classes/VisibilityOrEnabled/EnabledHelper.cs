using System.ComponentModel;
using System.Windows.Forms;

namespace Biblio.Classes.VisibilityOrEnabled
{
    internal class EnabledHelper
    {
        /// <summary>
        /// Отключает компонент, на пример кнопку
        /// </summary>
        /// <param name="control"></param>
        public static void DisableVerificationControl(IComponent control)
        {
            if (control is Control c)
            {
                c.Enabled = false;
            }
        }

        /// <summary>
        /// Включает компонент, на пример кнопку
        /// </summary>
        /// <param name="control"></param>
        public static void EnableVerificationControl(IComponent control)
        {
            if (control is Control c)
            {
                c.Enabled = true;
            }
        }
    }
}
