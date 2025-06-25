using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class UserBanForm : Form
    {
        private int _currentUserId = Program.CurrentUser.UserID;
        private int _banedUserId;
        private bool _banReasonIsEmpty = false;
        private bool _banCalendarIsUncorect = false;

        public UserBanForm(int reportedUserId)
        {
            InitializeComponent();

            _banedUserId = reportedUserId;

            SetUserBanFormStyle();
        }

        private void SetUserBanFormStyle()
        {
            banCalendar.MinDate = DateTime.Now;
        }

        private void UserBanValidation()
        {
            _banReasonIsEmpty = banReasonComboBox.SelectedIndex == -1;

            banReasonLabel.ForeColor = _banReasonIsEmpty == true ? Color.Red : Color.White;

            _banCalendarIsUncorect = banCalendar.SelectionStart.Date == DateTime.Now.Date;

            if (!_banReasonIsEmpty)
            {
                if (_banCalendarIsUncorect)
                {
                    ValidationHelper.ShowErrorMessage("Вы не можете поставить сегодняшнюю дату!");
                }
            }
        }

        private bool HasUserBan()
        {
            return Program.context.UserBans
                .Any(ban => ban.BanedUserID == _banedUserId);
        }

        private void ProcessReportSubmission()
        {
            if (!_banReasonIsEmpty && !_banCalendarIsUncorect)
            {
                if (HasUserBan())
                {
                    ValidationHelper.ShowErrorMessage("Данный пользователь уже забанен. Если вы хотите продлить бан перейдите в админ пнель!");
                    this.Close();
                }
                else
                {
                    SendBanToDatabase();
                    this.Close();
                }
            }
        }

        private void SendBanToDatabase()
        {
            var userBan = new UserBans
            {
                UserID = _currentUserId,
                BanedUserID = _banedUserId,
                BanCategoryID = banReasonComboBox.SelectedIndex + 1,
                BanMessage = string.IsNullOrEmpty(banMessageTextBox.Text) ? null : banMessageTextBox.Text,
                BanExpiration = banCalendar.SelectionStart.Date
            };

            Program.context.UserBans.Add(userBan);
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Пользователь забанен!", "Успех!");
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void issueBanButton_Click(object sender, EventArgs e)
        {
            UserBanValidation();
            ProcessReportSubmission();
        }

        private void banReasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (banReasonLabel.ForeColor == Color.Red)
            {
                banReasonLabel.ForeColor = Color.White;
            }
        }
    }
}
