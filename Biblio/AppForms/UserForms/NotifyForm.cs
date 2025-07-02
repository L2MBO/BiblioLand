using Biblio.AppForms.AdminForms;
using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.CustomControls;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class NotifyForm : Form
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isUpdatingComboBoxes = false;
        private List<object> _currentNotifications;

        public NotifyForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            reportTypeComboBox.SelectedIndexChanged += (s, e) => ShowAdminNotify();
            feedbackTypeComboBox.SelectedIndexChanged += (s, e) => ShowAdminNotify();
            sortComboBox.SelectedIndexChanged += (s, e) => RefreshNotifications();

            CheckUserRole();
        }

        private void CheckUserRole()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (currentUser != null)
            {
                AddAdminFunctional();
                ShowAdminNotify();
            }
            else
            {
                buttonsPanel.Width = 28;
                ShowUserNotify();
            }
        }

        private void AddAdminFunctional()
        {
            reportTypeComboBox.Visible = true;
            feedbackTypeComboBox.Visible = true;
            writeNotifyButton.Visible = true;
        }

        private void ShowUserNotify()
        {
            notifyPanel.Controls.Clear();

            var hiddenNotificationIds = Program.context.DeletedNotifications
                .Where(dn => dn.UserID == _currentUserId)
                .Select(dn => dn.NotifyID)
                .ToList();

            var notifications = Program.context.SystemNotifications
                .Where(n => !hiddenNotificationIds.Contains(n.NotifyID))
                .OrderByDescending(n => n.NotifyDate)
                .ToList()
                .Cast<object>()
                .ToList();

            notifications = ApplySorting(notifications);

            _currentNotifications = notifications.Cast<object>().ToList();

            if (notifications.Count > 0)
            {
                foreach (SystemNotifications notification in notifications)
                {
                    var userControl = new NotifyControl(notification);
                    userControl.Margin = new Padding(0, 0, 0, 10);
                    userControl.CheckChanged += NotifyControl_CheckChanged;
                    UpdateControlSize(userControl);
                    notifyPanel.Controls.Add(userControl);
                }
                notifyPanel.Dock = DockStyle.Top;
                notifyPanel.BackgroundImage = null;
            }
            else
            {
                notifyPanel.Dock = DockStyle.Fill;
                notifyPanel.BackgroundImage = Properties.Resources.blueNoResults;
            }
        }

        private void ShowAdminNotify()
        {
            if (_isUpdatingComboBoxes) return;

            _isUpdatingComboBoxes = true;


            var changedComboBox = reportTypeComboBox.Focused ? reportTypeComboBox :
                            feedbackTypeComboBox.Focused ? feedbackTypeComboBox : null;

            // Если пользователь изменил reportType
            if (changedComboBox == reportTypeComboBox && reportTypeComboBox.SelectedIndex > 0)
            {
                feedbackTypeComboBox.SelectedIndex = 0;
            }
            // Если пользователь изменил feedbackType
            else if (changedComboBox == feedbackTypeComboBox && feedbackTypeComboBox.SelectedIndex > 0)
            {
                reportTypeComboBox.SelectedIndex = 0;
            }

            notifyPanel.Controls.Clear();
            List<object> notifications = new List<object>();

            if (feedbackTypeComboBox.SelectedIndex == 0)
            {
                switch (reportTypeComboBox.SelectedIndex)
                {
                    case 0: // Все жалобы
                        notifications.AddRange(Program.context.BookReports.ToList());
                        notifications.AddRange(Program.context.ReviewReports.ToList());
                        notifications.AddRange(Program.context.UserReports.ToList());
                        break;

                    case 1: // Жалобы на книги
                        notifications.AddRange(Program.context.BookReports.ToList());
                        break;

                    case 2: // Жалобы на комментарии
                        notifications.AddRange(Program.context.ReviewReports.ToList());
                        break;

                    case 3: // Жалобы на профили
                        notifications.AddRange(Program.context.UserReports.ToList());
                        break;
                }
            }

            if (reportTypeComboBox.SelectedIndex == 0)
            {
                IQueryable<Feedback> feedbackQuery = Program.context.Feedback;

                switch (feedbackTypeComboBox.SelectedIndex)
                {
                    case 1: // Понравилось
                        feedbackQuery = feedbackQuery.Where(type => type.FeedbackCategoryID == 1);
                        break;
                    case 2: // Не понравилось
                        feedbackQuery = feedbackQuery.Where(type => type.FeedbackCategoryID == 2);
                        break;
                    case 3: // Баг
                        feedbackQuery = feedbackQuery.Where(type => type.FeedbackCategoryID == 3);
                        break;
                    case 4: // Идея
                        feedbackQuery = feedbackQuery.Where(type => type.FeedbackCategoryID == 4);
                        break;
                }

                notifications.AddRange(feedbackQuery.ToList().Cast<object>());
            }

            notifications = ApplySorting(notifications);

            _currentNotifications = notifications;

            if (notifications.Count > 0)
            {
                foreach (var notification in notifications)
                {
                    var userControl = new NotifyControl(notification);
                    userControl.Margin = new Padding(0, 0, 0, 10);
                    userControl.CheckChanged += NotifyControl_CheckChanged;
                    UpdateControlSize(userControl);
                    notifyPanel.Controls.Add(userControl);
                }
                notifyPanel.Dock = DockStyle.Top;
                notifyPanel.BackgroundImage = null;
            }
            else
            {
                notifyPanel.Dock = DockStyle.Fill;
                notifyPanel.BackgroundImage = Properties.Resources.blueNoResults;
            }

            _isUpdatingComboBoxes = false;
        }

        public void RefreshNotifications()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);
            bool isAdmin = currentUser?.UserRoleID != 1;

            if (isAdmin)
            {
                ShowAdminNotify();
            }
            else
            {
                ShowUserNotify();
            }
        }

        private List<object> ApplySorting(List<object> notifications)
        {
            if (notifications == null || !notifications.Any())
                return notifications;

            switch (sortComboBox.SelectedIndex)
            {
                case 0: // Новые
                    return notifications.OrderByDescending(n => GetNotificationDate(n)).ToList();
                case 1: // Старые
                    return notifications.OrderBy(n => GetNotificationDate(n)).ToList();
                default:
                    return notifications;
            }
        }

        private DateTime GetNotificationDate(object notification)
        {
            switch (notification)
            {
                case SystemNotifications sysNotif:
                    return sysNotif.NotifyDate;
                case BookReports bookReport:
                    return bookReport.ReportDate;
                case ReviewReports reviewReport:
                    return reviewReport.ReportDate;
                case UserReports userReport:
                    return userReport.ReportDate;
                case Feedback feedback:
                    return feedback.FeedbackDate;
                default:
                    return DateTime.MinValue;
            }
        }

        private void DeleteNotificationPermanently(object notificationData)
        {
            switch (notificationData)
            {
                case SystemNotifications sysNotif:
                    Program.context.SystemNotifications.Remove(sysNotif);
                    break;
                case BookReports bookReport:
                    Program.context.BookReports.Remove(bookReport);
                    break;
                case ReviewReports reviewReport:
                    Program.context.ReviewReports.Remove(reviewReport);
                    break;
                case UserReports userReport:
                    Program.context.UserReports.Remove(userReport);
                    break;
                case Feedback feedback:
                    Program.context.Feedback.Remove(feedback);
                    break;
            }
        }

        private void HideNotificationForUser(object notificationData)
        {
            if (notificationData is SystemNotifications sysNotif)
            {
                // Проверяем, не скрыто ли уже это уведомление
                if (!Program.context.DeletedNotifications.Any(dn =>
                    dn.NotifyID == sysNotif.NotifyID && dn.UserID == _currentUserId))
                {
                    Program.context.DeletedNotifications.Add(new DeletedNotifications
                    {
                        NotifyID = sysNotif.NotifyID,
                        UserID = _currentUserId,
                        DeletedDate = DateTime.Now
                    });
                }
            }
        }

        private void DeleteSelectedNotifications()
        {
            var checkedControls = GetCheckedNotificationControls();
            if (checkedControls.Count == 0) return;

            bool isAdmin = IsCurrentUserAdmin();

            try
            {
                ProcessNotificationsDeletion(checkedControls, isAdmin);
                SaveChangesAndUpdateUI(isAdmin);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        private List<NotifyControl> GetCheckedNotificationControls()
        {
            return notifyPanel.Controls.OfType<NotifyControl>()
                .Where(control => control.IsChecked)
                .ToList();
        }

        private bool IsCurrentUserAdmin()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);
            return currentUser?.UserRoleID != 1;
        }

        private void ProcessNotificationsDeletion(List<NotifyControl> controls, bool isAdmin)
        {
            foreach (var control in controls)
            {
                if (isAdmin)
                {
                    DeleteNotificationPermanently(control.NotificationData);
                }
                else
                {
                    HideNotificationForUser(control.NotificationData);
                }
            }
        }

        private void SaveChangesAndUpdateUI(bool isAdmin)
        {
            Program.context.SaveChanges();
            deleteNotifyButton.Enabled = false;

            if (isAdmin)
                ShowAdminNotify();
            else
                ShowUserNotify();
        }

        private void UpdateControlsSize()
        {
            if (_currentNotifications == null) return;

            foreach (Control control in notifyPanel.Controls)
            {
                if (control is NotifyControl userControl)
                {
                    UpdateControlSize(userControl);
                }
            }
        }

        private void UpdateControlSize(NotifyControl control)
        {
            control.Width = this.WindowState == FormWindowState.Maximized ? 1320 : 526;
        }

        private void UserNotifyForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
            UpdateControlsSize();
        }

        private void writeNotifyButton_Click(object sender, EventArgs e)
        {
            var form = new WriteNotifyForm();
            _dialogService.ShowDialogWithOverlay(this.FindForm(), form);
        }

        private void deleteNotifyButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedNotifications();
        }

        private void NotifyControl_CheckChanged(object sender, EventArgs e)
        {
            // Активируем кнопку удаления, если есть выбранные элементы
            deleteNotifyButton.Enabled = notifyPanel.Controls.OfType<NotifyControl>()
                .Any(control => control.IsChecked);
        }
    }
}
