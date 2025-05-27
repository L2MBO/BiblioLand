using Biblio.Classes.Animations;
using Biblio.HideClasses;
using Biblio.ValidationClasses;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class AuthorizationForm : Form
    {
        private ValidationHelper validationHelper;

        public AuthorizationForm()
        {
            InitializeComponent();

            validationHelper = new ValidationHelper();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void fogetPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm();
            form.Show();
            this.Hide();
        }

        private void visiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField };
            VisibilityHelper.ShowPassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private void unvisiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField };
            VisibilityHelper.HidePassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }

        private async void logInButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { nameTextField, passwordTextField };

            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                if (validationHelper.ValidateLogIn(nameTextField, passwordTextField, blockLogInLabel, timerLabel, logInButton))
                {
                    MainForm form = new MainForm();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
