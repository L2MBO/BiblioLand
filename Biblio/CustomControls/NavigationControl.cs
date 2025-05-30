using Biblio.AppForms;
using Biblio.Classes.Animations;
using Biblio.Classes.Images.InstallingImages;
using Biblio.HideClasses;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Biblio.CustomControls
{
    public partial class NavigationControl : UserControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Контролы
        private SearchControl searchControl;
        private OtherControl otherControl;
        private AvatarControl avatarControl;

        // Координаты для выпадающих элементов
        private int _otherX;
        private int _avatarX;

        // Дефолтный размер панелей
        private int _leftPanelDefaultWidth = 100;
        private int _rightPanelDefaultWidth = 100;

        public NavigationControl()
        {
            InitializeComponent();

            // подгрузка аватара пользователя
            this.Load += NavigationControl_Load;

            // Привязка событий кнопок
            closeButton.Click += (s, e) => Application.Exit();
            minimizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Minimized;
            maximizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Maximized;
            restoreButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Normal;

            // Навигация по формам
            mainButton.Click += (s, e) => OpenForm<MainForm>();
            catalogButton.Click += (s, e) => OpenForm<BookСatalogForm>();
            topButton.Click += (s, e) => OpenForm<BookTopForm>();
            bookmarksButton.Click += (s, e) => OpenForm<BookmarksForm>();
            notificationsButton.Click += (s, e) => OpenForm<UserNotifyForm>();
        }

        private void NavigationControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ImageLoader.LoadAvatarImage(avatarPictureBox);
            }
        }

        private void OpenForm<T>() where T : Form, new()
        {
            var parentForm = this.FindForm();
            var newForm = new T();

            if (parentForm != null)
            {
                newForm.Owner = parentForm;
                parentForm.Hide();
            }

            VisibilityHelper.ShowNewForm(parentForm, newForm);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchControl != null && searchControl.Visible)
            {
                searchControl.Visible = false;
                searchControl.Dispose();
                searchControl = null;
                return;
            }

            searchControl = new SearchControl(FindForm());
            FindForm().Controls.Add(searchControl);
            searchControl.BringToFront();
            searchControl.Visible = true;
            SetSearchControlPosition();
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            if (otherControl != null && otherControl.Visible)
            {
                otherControl.Visible = false;
                otherControl.Dispose();
                otherControl = null;
                return;
            }

            otherControl = new OtherControl();
            otherControl.Location = new Point(otherButton.Left + _otherX, otherButton.Bottom + 10);
            FindForm().Controls.Add(otherControl);
            otherControl.BringToFront();
            otherControl.Visible = true;
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            if (avatarControl != null && avatarControl.Visible)
            {
                avatarControl.Visible = false;
                avatarControl.Dispose();
                avatarControl = null;
                return;
            }

            avatarControl = new AvatarControl(FindForm());
            avatarControl.Location = new Point(avatarPictureBox.Right + _avatarX, avatarPictureBox.Bottom + 10);
            FindForm().Controls.Add(avatarControl);
            avatarControl.BringToFront();
            avatarControl.Visible = true;
        }

        public void SetSearchControlPosition()
        {
            if (searchControl == null || !searchControl.Visible) return;

            int centerX = FindForm().ClientSize.Width / 2;
            int controlWidth = searchControl.Width;

            int x = (centerX - controlWidth / 2) + 3;
            int y = searchButton.Bottom + 10;

            searchControl.Location = new Point(x, y);
        }

        public void HandleFormResize(Form form)
        {
            var borderlessForm = form.GetType()
                .GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .FirstOrDefault(f => f.FieldType == typeof(Guna2BorderlessForm))?
                .GetValue(form) as Guna2BorderlessForm;


            if (form.WindowState == FormWindowState.Maximized)
            {
                if (borderlessForm != null)
                    borderlessForm.BorderRadius = 0;
                maximizeButton.Visible = false;
                restoreButton.Visible = true;
                if (leftPanel != null) leftPanel.Width = 300;
                if (rightPanel != null) rightPanel.Width = 300;
                topLeftPanel.Width = 300;
                topRightPanel.Width = 300;
                searchButton.Width = 300;
                searchButton.Text = "Что ищем, читатель?";
                _otherX = 300;
                _avatarX = 999;
            }
            else
            {
                if (borderlessForm != null)
                    borderlessForm.BorderRadius = 11;
                maximizeButton.Visible = true;
                restoreButton.Visible = false;
                if (leftPanel != null) leftPanel.Width = 100;
                if (rightPanel != null) rightPanel.Width = 100;
                topLeftPanel.Width = 100;
                topRightPanel.Width = 100;
                searchButton.Width = 136;
                searchButton.Text = "Что ищем?";
                _otherX = 100;
                _avatarX = 175;
            }

            if (otherControl != null) otherControl.Location = new Point(otherButton.Left + _otherX, otherButton.Bottom + 10);
            if (searchControl != null) SetSearchControlPosition();
            if (avatarControl != null) avatarControl.Location = new Point(avatarPictureBox.Right + _avatarX, avatarPictureBox.Bottom + 10);
        }

        public void UpdatePanelsWidth()
        {
            if (leftPanel != null)
                leftPanel.Width = LeftPanelWidth > 0 ? LeftPanelWidth : _leftPanelDefaultWidth;

            if (rightPanel != null)
                rightPanel.Width = RightPanelWidth > 0 ? RightPanelWidth : _rightPanelDefaultWidth;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(FindForm());
        }

        public void OnControlOpenChanged(object sender, EventArgs e)
        {
            if (sender is Control control && control.Visible)
            {
                FindForm().Hide();
            }
        }

        public Panel leftPanel { get; set; }
        public Panel rightPanel { get; set; }

        public int LeftPanelWidth { get; set; }
        public int RightPanelWidth { get; set; }
    }
}
