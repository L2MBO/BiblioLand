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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.AppForms
{
    public partial class ForgetPasswordForm : Form
    {
        private ValidationHelper _validationHelper;

        public ForgetPasswordForm()
        {
            InitializeComponent();
            
            _validationHelper = new ValidationHelper();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private async void recoverPasswordButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { mailTextField };
            
            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                var result = await _validationHelper.ValidationForgetPassword(mailTextField, VerificationCodeInfoLabel, verificationCodeTextField, ResendVerificationCodeLabel, timerLabel);

                if (result.success)
                {
                    RecoverPasswordForm form = new RecoverPasswordForm(_validationHelper, result.email);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private async void ResendVerificationCodeLabel_Click(object sender, EventArgs e)
        {
            await ValidationHelper.ResendConfirmationCode(mailTextField, timerLabel, ResendVerificationCodeLabel);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void closeButton_Click(object sender, EventArgs e) 
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
            ValidationHelper._isCodeSent = false;
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
