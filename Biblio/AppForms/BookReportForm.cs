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
        private int _commentId;
        private int _reportedUserId;
        public bool _reportReasonIsEmpty = false;
        public bool _reportMessageIsEmpty = false;
        private string _reportType;

        public BookReportForm(Books book, int commentId, int reportedUserId, int currentUserId, string reportType)
        {
            InitializeComponent();

            _book = book;
            _commentId = commentId;
            _reportedUserId = reportedUserId;
            _currentUserId = currentUserId;
            _reportType = reportType;

            FillReportReasonComboBox();
        }

        private void FillReportReasonComboBox()
        {
            reportReasonComboBox.Items.Clear();

            switch (_reportType)
            {
                case "Book":
                    reportReasonComboBox.Items.AddRange(new object[] {
                        "Дубль",
                        "Несоответвие жанра",
                        "Другое"
                });
                    break;

                case "Comment":
                    reportReasonComboBox.Items.AddRange(new object[] {
                        "Нарушение законов РФ",
                        "Призыв к суициду",
                        "Призыв к травле",
                        "Реклама сторонних ресурсов",
                        "Спам",
                        "Другое"
                });
                    break;

                case "User":
                    reportReasonComboBox.Items.AddRange(new object[] {
                        "Нарушение законов РФ",
                        "Неподобающий никнейм",
                        "Другое"
                });
                    break;

                default:
                    throw new ArgumentException("Неизвестный тип репорта");
            }
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
            switch (_reportType)
            {
                case "Book":
                    return Program.context.BookReports
                        .Any(report => report.UserID == _currentUserId && report.BookID == _book.BookID);

                case "Comment":
                    return Program.context.ReviewReports
                        .Any(report => report.UserID == _currentUserId && report.ReviewID == _commentId);

                case "User":
                    return Program.context.UserReports
                        .Any(report => report.UserID == _currentUserId && report.ReportedUserID == _reportedUserId);

                default:
                    return false;
            }
        }

        private void SendReportToDatabase()
        {
            var report = new BookReports
            {
                UserID = _currentUserId,
                ReportCategoryID = reportReasonComboBox.SelectedIndex + 1,
                ReportMessage = reportMessageTextBox.Text,
                ReportDate = DateTime.Now
            };

            // В зависимости от типа репорта заполняем нужные поля
            switch (_reportType)
            {
                case "Book":
                    report.BookID = _book.BookID;
                    Program.context.BookReports.Add(report);
                    break;

                case "Comment":
                    report.ReviewID = _commentId;
                    Program.context.ReviewReports.Add(report);
                    break;

                case "User":
                    report.ReportedUserID = _reportedUserId;
                    Program.context.UserReports.Add(report);
                    break;
            }

            Program.context.SaveChanges();

            ValidationHelper.ShowInformationMessage("Мы рассмотрим вашу жалобу и примем меры!", "Жалоба успешно отправлена!");
        }

        private void ProcessReportSubmission()
        {
            if (!_reportReasonIsEmpty && !_reportMessageIsEmpty)
            {
                if (HasExistingReport())
                {
                    string errorMessage;

                    switch (_reportType)
                    {
                        case "Book":
                            errorMessage = "Вы уже отправляли жалобу на эту книгу.";
                            break;
                        case "Comment":
                            errorMessage = "Вы уже отправляли жалобу на этот комментарий.";
                            break;
                        case "User":
                            errorMessage = "Вы уже отправляли жалобу на этого пользователя.";
                            break;
                        default:
                            errorMessage = "Вы уже отправляли жалобу на этот объект.";
                            break;
                    }

                    ValidationHelper.ShowErrorMessage(errorMessage);
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
