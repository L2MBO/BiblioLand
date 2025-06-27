using Biblio.Classes.Coding;
using Biblio.Classes.Customization;
using Biblio.Classes.Customization.FormCustomization;
using Biblio.Classes.DataAccess;
using Biblio.Classes.Images.InstallingImages;
using Biblio.Models;
using Biblio.ValidationClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class SettingsForm : Form
    {
        private DialogWithOverlayService _dialogService = new DialogWithOverlayService();
        private static int _currentUserId = Program.CurrentUser.UserID;
        private Users _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);
        private static readonly Regex _onlyEnglishChars = new Regex(@"^[A-Za-z\d\W_]+$");
        private static readonly Regex _whitespaceRegex = new Regex(@"\s+");
        private string _base64Avatar;
        private bool _isAvatarDeleted = false;

        public SettingsForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            AutoScrollHelper.ConfigureScrollbars(profileMainPanel, disableHorizontal: true, disableVertical: true);

            ImageLoader.LoadAvatarImage(avatarPictureBox);

            userNameTextBox.Text = _currentUser.Username;
            descriptionTextBox.Text = _currentUser.Descriotion;

            SetUserAnonymity();

            PerformLayout();
        }

        private void SetUserAnonymity()
        {
            if (_currentUser.PrivateProfile == 1)
            {
                privateToggleSwitch.Checked = true;
            }
            else
            {
                privateToggleSwitch.Checked = false;
            }
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
            settingsTabControl.Update();

            if (this.WindowState == FormWindowState.Maximized)
            {
                avatarPictureBox.Width = 200;
                avatarPictureBox.Height = 200;
                avatarPictureBox.BorderRadius = 15;
                avatarPanel.Height = 226;
                userNameRuleLabel.Text = "Состоит из английских букв, цифр и символов @/./+/-/_. За недопустимый по правилам ник Вы можете получить бан.";
                passwordRuleLabel.Text = "Пароль должен содержать заглавные и строчные буквы, а также символы и цифры. Минимальная длина - 8 символов";
                privateDescriptionLabel.Text = "Другие будут видеть только аватар, никнейм и чуть-чуть статистики. Закладки — только Ваши.";
            }
            else
            {
                avatarPictureBox.Width = 44;
                avatarPictureBox.Height = 44;
                avatarPictureBox.BorderRadius = 7;
                avatarPanel.Height = 70;
                userNameRuleLabel.Text = "За недопустимый по правилам ник Вы можете получить бан.";
                passwordRuleLabel.Text = "Заглавные, строчные, символы и цифры. Минимум 8 символов";
                privateDescriptionLabel.Text = "Другие будут видеть только аватар, никнейм и чуть-чуть статистики.";
            }
        }

        private int CalculateTextBoxHeight(string text, Font font, int width)
        {
            string adjustedText = text.Length > 0 ? Environment.NewLine + Environment.NewLine + text : text;

            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(adjustedText, font, new Size(width, 0),
                    TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height) + descriptionTextBox.Margin.Vertical + descriptionTextBox.Padding.Vertical;
            }
        }

        private bool ChangeUserAnonymity()
        {
            var currentValue = Program.context.Users
                .AsNoTracking()
                .Where(u => u.UserID == _currentUser.UserID)
                .Select(u => u.PrivateProfile)
                .FirstOrDefault();

            int newValue = privateToggleSwitch.Checked ? 1 : 0;

            if (currentValue != newValue)
            {
                _currentUser.PrivateProfile = newValue;
                return true;
            }

            return false;
        }

        private bool IsUserNameValid()
        {
            userNameTextBox.ForeColor = userNameTextBox.Text == "" || !_onlyEnglishChars.IsMatch(userNameTextBox.Text) ? Color.Red : Color.White;

            return userNameTextBox.Text == "" || !_onlyEnglishChars.IsMatch(userNameTextBox.Text) ? false : true;
        }

        private bool IsReportEmpty()
        {
            oldPasswordLabel.ForeColor = oldPasswordTextBox.Text == "" ? Color.Red : Color.White;
            newPasswordLabel.ForeColor = newPasswordTextBox.Text == "" ? Color.Red : Color.White;
            confirmPasswordLabel.ForeColor = confirmPasswordTextBox.Text == "" ? Color.Red : Color.White;

            return oldPasswordTextBox.Text == "" || newPasswordTextBox.Text == "" || confirmPasswordTextBox.Text == "" ? false : true;
        }

        private bool IsMailEmpty()
        {
            newMailLabel.ForeColor = string.IsNullOrWhiteSpace(newMailTextBox.Text) ? Color.Red : Color.White;

            return string.IsNullOrWhiteSpace(newMailTextBox.Text) ? false : true;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            if (IsUserNameValid())
            {
                bool hadSpaces = userNameTextBox.Text.Contains(" ");
                bool changesMade = false;

                if (userNameTextBox.Text != _currentUser.Username)
                {
                    _currentUser.Username = userNameTextBox.Text?.Replace(" ", "");
                    changesMade = true;
                }

                if (_whitespaceRegex.Replace(descriptionTextBox.Text ?? "", "")
                    != _whitespaceRegex.Replace(_currentUser.Descriotion ?? "", ""))
                {
                    _currentUser.Descriotion = string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text.Trim();
                    changesMade = true;
                }

                if (_isAvatarDeleted)
                {
                    _currentUser.Avatar = _base64Avatar;
                    changesMade = true;
                    _isAvatarDeleted = false;
                }
                else if (!string.IsNullOrEmpty(_base64Avatar) &&
                        _base64Avatar != UserAvatarDataHelper.GetBase64ImageFromDatabase(_currentUserId))
                {
                    _currentUser.Avatar = _base64Avatar;
                    changesMade = true;
                }

                if (changesMade)
                {
                    Program.context.SaveChanges();

                    navigationControl.RefreshAvatar();

                    string saveSettingsMessage = hadSpaces
                        ? "Пробелы у имени пользователя были удалены.\n\nДанные обновлены"
                        : "Данные обновлены";

                    ValidationHelper.ShowInformationMessage(saveSettingsMessage, "Успех");
                }
            }
        }

        private void savePasswordButton_Click(object sender, EventArgs e)
        {
            if (IsReportEmpty())
            {
                if (ValidationHelper.ValidationPasswordField(newPasswordTextBox, confirmPasswordTextBox))
                {
                    ValidationHelper.ValidationResetPassword(oldPasswordTextBox, newPasswordTextBox, confirmPasswordTextBox);
                }
            }
        }

        private void saveMailButton_Click(object sender, EventArgs e)
        {
            string mail = newMailTextBox.Text?.Trim();

            if (IsMailEmpty())
            {
                if (ValidationHelper.ValidateMailField(mail))
                {
                    ValidationHelper.ValidateNewMail(newMailTextBox);
                }
            }
        }

        private void changeAvatarButton_Click(object sender, EventArgs e)
        {
            var form = new ImageLoadForm(_currentUserId);

            if (_dialogService.ShowDialogWithOverlay(this, form) == DialogResult.OK)
            {
                _base64Avatar = form.Base64Avatar;
                ImageLoader.LoadAvatarImageFromString(_base64Avatar, avatarPictureBox);
            }
        }

        private void deleteAvatarButton_Click(object sender, EventArgs e)
        {
            string defaultBase64Avatar = CodingOrDecoding.ImageCoding(null);

            string currentAvatar = UserAvatarDataHelper.GetBase64ImageFromDatabase(_currentUserId);

            if (currentAvatar == defaultBase64Avatar)
            {
                return;
            }

            ImageLoader.LoadAvatarImageFromString(defaultBase64Avatar, avatarPictureBox);

            _base64Avatar = defaultBase64Avatar;
            _isAvatarDeleted = true;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int textBoxWidth = descriptionTextBox.Width;

            int preferredHeight = CalculateTextBoxHeight(descriptionTextBox.Text, descriptionTextBox.Font, textBoxWidth);

            descriptionTextBox.Height = preferredHeight;

            descriptionPanel.PerformLayout();
        }

        private void savePrivateButton_Click(object sender, EventArgs e)
        {
            bool hasChanges = ChangeUserAnonymity();

            if (hasChanges)
            {
                Program.context.SaveChanges();
            }

            MessageBox.Show("Данные успешно обновлены");
        }
    }
}
