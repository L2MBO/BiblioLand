using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class BookReportForm : Form
    {
        private Books _book;
        private int _currentUserId;
        public bool _reportReasonIsEmpty = false;
        public bool _reportMessageIsEmpty = false;

        public BookReportForm(Books book, int currentUserId)
        {
            InitializeComponent();

            _book = book;
            _currentUserId = currentUserId;
        }

        private void IsReportEmpty()
        {
            _reportReasonIsEmpty = reportReasonComboBox.SelectedIndex == -1;
            _reportMessageIsEmpty = string.IsNullOrWhiteSpace(reportMessageTextBox.Text);

            reportReasonLabel.ForeColor = _reportReasonIsEmpty == true ? Color.Red : Color.White;
            reportMessageLabel.ForeColor = _reportMessageIsEmpty == true ? Color.Red : Color.White;
        }

        private bool HasExistingReport()
        {
            return Program.context.BookReports
                .Any(report => report.UserID == _currentUserId && report.BookID == _book.BookID);
        }

        private void SendReportToDatabase()
        {
            var bookReport = new BookReports
            {
                UserID = _currentUserId,
                BookID = _book.BookID,
                ReportCategoryID = reportReasonComboBox.SelectedIndex + 1,
                ReportMessage = reportMessageTextBox.Text,
                ReportDate = DateTime.Now
            };

            Program.context.BookReports.Add(bookReport);
            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Мы рассмотрим вашу жалобу и примем меры!", "Жалоба успешно отправлена!");
        }

        private void ProcessReportSubmission()
        {
            if (!_reportReasonIsEmpty && !_reportMessageIsEmpty)
            {
                if (HasExistingReport())
                {
                    ValidationHelper.ShowErrorMessage("Вы уже отправляли жалобу на эту книгу.");
                    this.Close();
                }
                else
                {
                    SendReportToDatabase();
                    this.Close();
                }
            }
        }

        private void sendReportButton_Click(object sender, EventArgs e)
        {
            IsReportEmpty();
            ProcessReportSubmission();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
