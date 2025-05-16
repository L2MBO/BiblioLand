using Biblio.Classes.ConfirmationCode;
using Biblio.Classes.Customization;
using Biblio.Classes.Hash;
using Biblio.HideClasses;
using Biblio.Models;
using Biblio.ValidationClasses;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class AuthorizationForm : MaterialForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            validationHelper = new ValidationHelper();
            this.MaximizeBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            CustomizationHelper.SetRoundedRegion(this, 20, 20);
            redPanel.MouseDown += Form_MouseDown;
            whitePanel.MouseDown += Form_MouseDown;
        }

        private void fogetPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm();
            form.Owner = this;
            this.Hide();
            form.Show();
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
            form.Owner = this;
            this.Hide();
            form.Show();
        }

        private ValidationHelper validationHelper;

        private async void logInButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { nameTextField, passwordTextField };

            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                if (validationHelper.ValidateLogIn(nameTextField, passwordTextField, blockLogInLabel, timerLabel, logInButton))
                {
                    MainForm form = new MainForm();
                    form.Owner = this;
                    this.Hide();
                    form.Show();
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
