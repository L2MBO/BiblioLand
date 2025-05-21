using Biblio.AppForms;
using Biblio.Classes.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            // Привязка событий кнопок
            closeButton.Click += (s, e) => Application.Exit();
            minimizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Minimized;
            maximizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Maximized;
            restoreButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Normal;

            // Навигация по формам
            mainButton.Click += (s, e) => OpenForm<MainForm>();
            catalogButton.Click += (s, e) => OpenForm<BookСatalogForm>();
            topButton.Click += (s, e) => OpenForm<TopForm>();
            bookmarksButton.Click += (s, e) => OpenForm<BookmarksForm>();
            notificationsButton.Click += (s, e) => OpenForm<UserNotifyForm>();

            // Поиск и другие элементы
            searchButton.Click += searchButton_Click;
            otherButton.Click += otherButton_Click;
            avatarPictureBox.Click += avatarPictureBox_Click;

            // Перемещение формы
            this.MouseDown += Form_MouseDown;
            topLeftPanel.MouseDown += Form_MouseDown;
            topRightPanel.MouseDown += Form_MouseDown;
            topNavigationPanel.MouseDown += Form_MouseDown;
            bottomNavigationPanel.MouseDown += Form_MouseDown;
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

            newForm.Show();
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
            otherControl.OpenChanged += OnControlOpenChanged;
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
            avatarControl.OpenChanged += OnControlOpenChanged;
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
            if (form.WindowState == FormWindowState.Maximized)
            {
                RoundingHelper.SetRoundedRegion(form, 0, 0);
                maximizeButton.Visible = false;
                restoreButton.Visible = true;
                //if (leftPanel != null) leftPanel.Width = 300;
                //if (rightPanel != null) rightPanel.Width = 300;
                topLeftPanel.Width = 300;
                topRightPanel.Width = 300;
                searchButton.Width = 300;
                searchButton.Text = "Что ищем, читатель?";
                _otherX = 300;
                _avatarX = 999;
            }
            else
            {
                RoundingHelper.SetRoundedRegion(form, 11, 11);
                maximizeButton.Visible = true;
                restoreButton.Visible = false;
                //if (leftPanel != null) leftPanel.Width = 100;
                //if (rightPanel != null) rightPanel.Width = 100;
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
            ReleaseCapture();
            SendMessage(FindForm().Handle, 0x112, 0xf012, 0);
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
