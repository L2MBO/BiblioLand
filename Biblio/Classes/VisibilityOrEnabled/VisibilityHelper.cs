﻿using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Biblio.HideClasses
{
    public class VisibilityHelper
    {
        public static void ShowPassword(MaterialSingleLineTextField[] passwordFields, PictureBox showButton, PictureBox hideButton)
        {
            showButton.Visible = false;
            hideButton.Visible = true;

            foreach (var field in passwordFields)
            {
                field.PasswordChar = '\0';
            }
        }

        public static void HidePassword(MaterialSingleLineTextField[] passwordFields, PictureBox showButton, PictureBox hideButton)
        {
            hideButton.Visible = false;
            showButton.Visible = true;

            foreach (var field in passwordFields)
            {
                field.PasswordChar = '*';
            }
        }

        public static void ShowVerificationCode(Label VerificationCodeInfo, MaterialSingleLineTextField VerificationCodeField, Label ResendVerificationCode, Label TimeInfo)
        {
            VerificationCodeField.Visible = true;
            VerificationCodeInfo.Visible = true;
            ResendVerificationCode.Visible = true;
            TimeInfo.Visible = true;
        }

        public static void ShowLogInLabel(Label LogInInfo, Label TimeInfo)
        {
            LogInInfo.Visible = true;
            TimeInfo.Visible = true;
        }

        public static void ShowNewForm(Form form, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = form.Location;
            newForm.WindowState = form.WindowState;
            newForm.Show();
        }
    }
}
