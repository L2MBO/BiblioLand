using Biblio.AppForms;
using Biblio.AppForms.UserForms;
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
        private AvatarControl avatarControl;

        // Координаты для выпадающих элементов
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
            HideOrClose();
            minimizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Minimized;
            maximizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Maximized;
            restoreButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Normal;

            // Навигация по формам
            mainButton.Click += (s, e) => OpenMainForm();
            catalogButton.Click += (s, e) => OpenForm<BookСatalogForm>();
            bookmarksButton.Click += (s, e) => OpenForm<BookmarksForm>();
            notificationsButton.Click += (s, e) => OpenForm<NotifyForm>();
        }

        private void HideOrClose()
        {
            if (IsHide)
            {
                closeButton.Click += (s, e) => FindForm().Hide();
            }
            else
            {
                closeButton.Click += (s, e) => Application.Exit();
            }
        }

        private void NavigationControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ImageLoader.LoadAvatarImage(avatarPictureBox);

                UpdateNotificationsCount();
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

        private void OpenMainForm()
        {
            var parentForm = this.FindForm();
            parentForm.Hide();

            if (parentForm.WindowState == FormWindowState.Maximized)
            {
                var loadingForm = new LoadingForm();
                loadingForm.TopMost = true;
                VisibilityHelper.ShowNewForm(parentForm, loadingForm);

                var mainform = new MainForm();
                VisibilityHelper.ShowNewForm(parentForm, mainform);

                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                while (stopwatch.ElapsedMilliseconds < 1)
                {
                    Application.DoEvents(); // даёт форме рендериться
                    System.Threading.Thread.Sleep(10); // снижаем нагрузку
                }
                stopwatch.Stop();

                loadingForm.Close();
                loadingForm.Dispose();
            }
            else
                OpenForm<MainForm>();
        }

        public void UpdateNotificationsCount()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user =>
                user.UserID == Program.CurrentUser.UserID && user.UserRoleID != 1);

            int notificationsCount = 0;
            bool hasNotifications = false;

            if (currentUser != null) // Администратор
            {
                notificationsCount = CountAdminNotifications();
            }
            else // Обычный пользователь
            {
                notificationsCount = CountUserNotifications();
            }

            // Обновляем интерфейс
            hasNotifications = notificationsCount > 0;
            notifyLabel.Text = notificationsCount.ToString();
            notifyPanel.Visible = hasNotifications;
        }

        private int CountAdminNotifications()
        {
            try
            {
                // Считаем все типы жалоб и обратной связи
                int bookReports = Program.context.BookReports.Count();
                int reviewReports = Program.context.ReviewReports.Count();
                int userReports = Program.context.UserReports.Count();
                int feedback = Program.context.Feedback.Count();

                return bookReports + reviewReports + userReports + feedback;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета уведомлений для админа: {ex.Message}");
                return 0;
            }
        }

        private int CountUserNotifications()
        {
            try
            {
                // Получаем ID скрытых уведомлений для текущего пользователя
                var hiddenNotificationIds = Program.context.DeletedNotifications
                    .Where(dn => dn.UserID == Program.CurrentUser.UserID)
                    .Select(dn => dn.NotifyID)
                    .ToList();

                // Считаем только неудаленные уведомления
                return Program.context.SystemNotifications
                    .Count(n => !hiddenNotificationIds.Contains(n.NotifyID));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета уведомлений для пользователя: {ex.Message}");
                return 0;
            }
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
            int y = searchButton.Bottom + 3;

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
                _avatarX = 1304;
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
                _avatarX = 310;
            }

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

        public void RefreshAvatar()
        {
            if (!DesignMode)
            {
                ImageLoader.LoadAvatarImage(avatarPictureBox);
            }
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

        public static bool IsHide { get; set; } = false;
    }
}
