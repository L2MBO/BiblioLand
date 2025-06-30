using Biblio.CustomControls;
using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Biblio.AppForms
{
    public partial class NotifyForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;

        public NotifyForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            CheckUserRole();
        }

        private void CheckUserRole()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (currentUser != null && _currentUserId != Program.CurrentUser.UserID)
            {
                reportTypeComboBox.Visible = true;
                writeNotifyButton.Visible = true;
                ShowAdminNotify();
                
            }
            else
            {
                ShowUserNotify();
            }
        }

        private void ShowUserNotify()
        {

        }

        private void ShowAdminNotify()
        {
            IQueryable<Feedback> query = Program.context.Feedback;
            // выводим информацию, по выбранной админом типом жалобы: 
            //Все жалобы - 0
            //Жалоба на книгу - 1
            //Жалоба на комментарий - 2
            //Жалоба на профиль - 3

            //switch (reportTypeComboBox.SelectedIndex)
            //{
            //    case 0: // передать все записи в таблицах: BookReports, ReviewReports, UserReports в контрол NotifyControl
            // В остльных индексах передавать соответствующие таблицы
            //}

            //выводим информацию, по выбранному админом типу обращения: 
            switch (feedbackTypeComboBox.SelectedIndex)
            {
                case 0:
                    // выводим все типы
                    break;

                case 1: // Понравилось
                    query = query.Where(type => type.FeedbackCategoryID == 1);
                    break;

                case 2: // Не понравилось
                    query = query.Where(type => type.FeedbackCategoryID == 2);
                    break;

                case 3: // Баг
                    query = query.Where(type => type.FeedbackCategoryID == 3);
                    break;

                case 4: // Идея
                    query = query.Where(type => type.FeedbackCategoryID == 4);
                    break;
            }

            UpdateNotifyList(query.ToList());
        }

        private void UpdateNotifyList(List<Feedback> messages)
        {
            notifyPanel.Controls.Clear();

            if (messages.Count > 0)
            {
                foreach (Feedback message in messages)
                {
                    var userControl = new NotifyControl(message);
                    userControl.Margin = new Padding(0, 0, 0, 10);
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

        private void UpdateControlsSize()
        {
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
    }
}
