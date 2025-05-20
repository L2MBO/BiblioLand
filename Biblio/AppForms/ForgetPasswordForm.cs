using Biblio.Classes.ConfirmationCode;
using Biblio.Classes.Customization;
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
    public partial class ForgetPasswordForm : MaterialForm
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            RoundingHelper.SetRoundedRegion(this, 20, 20);
            whitePanel.MouseDown += Form_MouseDown;
            _validationHelper = new ValidationHelper();
        }

        private ValidationHelper _validationHelper;

        private async void recoverPasswordButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { mailTextField };
            
            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                var result = await _validationHelper.ValidationForgetPassword(mailTextField, VerificationCodeInfoLabel, verificationCodeTextField, ResendVerificationCodeLabel, timerLabel);

                if (result.success)
                {
                    RecoverPasswordForm form = new RecoverPasswordForm(_validationHelper, result.email);
                    form.Owner = this;
                    this.Hide();
                    form.Show();
                }
            }
        }

        private async void ResendVerificationCodeLabel_Click(object sender, EventArgs e)
        {
            await ValidationHelper.ResendConfirmationCode(mailTextField, timerLabel, ResendVerificationCodeLabel);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e) 
        {
            this.Owner.Show();
            this.Close();
            ValidationHelper._isCodeSent = false;
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
