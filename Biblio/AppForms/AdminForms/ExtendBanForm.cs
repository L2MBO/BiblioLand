using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms.AdminForms
{
    public partial class ExtendBanForm : Form
    {
        public event Action DateChanged;
        private int _banedUserId;
        private bool _banCalendarIsUncorect = false;

        public ExtendBanForm(int reportedUserId)
        {
            InitializeComponent();

            _banedUserId = reportedUserId;

            SetExtenedBanFormStyle();
        }

        private void SetExtenedBanFormStyle()
        {
            var userBan = Program.context.UserBans.FirstOrDefault(user => user.BanedUserID == _banedUserId);

            banCalendar.MinDate = DateTime.Now;
            banCalendar.SelectionStart = userBan.BanExpiration;
        }

        private void UserBanValidation()
        {
            _banCalendarIsUncorect = banCalendar.SelectionStart.Date == DateTime.Now.Date;

            if (_banCalendarIsUncorect)
            {
                ValidationHelper.ShowErrorMessage("Вы не можете поставить сегодняшнюю дату!");
            }
        }

        private void ProcessReportSubmission()
        {
            if (!_banCalendarIsUncorect)
            {
                var result = MessageBox.Show("Вы уверены?",
                    "Подтвердите действие!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateBan();
                    DateChanged?.Invoke();
                    this.Close();
                }
            }
        }

        private void UpdateBan()
        {
            var userBan = Program.context.UserBans.FirstOrDefault(user => user.BanedUserID == _banedUserId);

            userBan.BanExpiration = banCalendar.SelectionStart.Date;
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Пользователь забанен!", "Успех!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issueBanButton_Click(object sender, EventArgs e)
        {
            UserBanValidation();
            ProcessReportSubmission();
        }
    }
}
