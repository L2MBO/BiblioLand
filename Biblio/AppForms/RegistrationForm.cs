using Biblio.Classes.Animations;
using Biblio.Classes.ConfirmationCode;
using Biblio.Classes.Customization;
using Biblio.HideClasses;
using Biblio.ValidationClasses;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void visiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField, confirmPasswordTextField };
            VisibilityHelper.ShowPassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private void unvisiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField, confirmPasswordTextField };
            VisibilityHelper.HidePassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private void autorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }

        private async void registrationButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { nameTextField, mailTextField, passwordTextField, confirmPasswordTextField };

            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                if (ValidationHelper.ValidateMailField(mailTextField))
                {
                    if (ValidationHelper.ValidationPasswordField(passwordTextField, confirmPasswordTextField))
                    {
                        if(ValidationHelper.ValidationRegistration(nameTextField, mailTextField, passwordTextField, confirmPasswordTextField))
                        {
                            AuthorizationForm form = new AuthorizationForm();
                            form.Show();
                            this.Hide();
                        }
                    }
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