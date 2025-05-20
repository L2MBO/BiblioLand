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
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            RoundingHelper.SetRoundedRegion(this, 20, 20);
            orangePanel.MouseDown += Form_MouseDown;
            whitePanel.MouseDown += Form_MouseDown;
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
            this.Owner.Show();
            this.Close();
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
                        ValidationHelper.ValidationRegistration(nameTextField, mailTextField, passwordTextField, confirmPasswordTextField);
                    }
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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