using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class ProfileForm : Form
    {
        private int _currentUserId;

        public ProfileForm(int currentUserId)
        {
            InitializeComponent();

            _currentUserId = currentUserId;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            // Заполнять данные исходя из того чей профиль открыт хранится в _currentUserId
        }

        private void ProfileForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }
    }
}
