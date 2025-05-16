namespace Biblio.AppForms
{
    partial class ForgetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.ResendVerificationCodeLabel = new System.Windows.Forms.Label();
            this.verificationCodeTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.VerificationCodeInfoLabel = new System.Windows.Forms.Label();
            this.recoverPasswordButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.whitePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoverPasswordButton)).BeginInit();
            this.whitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.timerLabel);
            this.panel1.Controls.Add(this.ResendVerificationCodeLabel);
            this.panel1.Controls.Add(this.verificationCodeTextField);
            this.panel1.Controls.Add(this.VerificationCodeInfoLabel);
            this.panel1.Controls.Add(this.recoverPasswordButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mailTextField);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 378);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Biblio.Properties.Resources.greyLine;
            this.pictureBox2.Location = new System.Drawing.Point(16, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.timerLabel.ForeColor = System.Drawing.Color.Gray;
            this.timerLabel.Location = new System.Drawing.Point(234, 268);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 16);
            this.timerLabel.TabIndex = 21;
            this.timerLabel.Visible = false;
            // 
            // ResendVerificationCodeLabel
            // 
            this.ResendVerificationCodeLabel.AutoSize = true;
            this.ResendVerificationCodeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResendVerificationCodeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResendVerificationCodeLabel.ForeColor = System.Drawing.Color.Gray;
            this.ResendVerificationCodeLabel.Location = new System.Drawing.Point(35, 267);
            this.ResendVerificationCodeLabel.Name = "ResendVerificationCodeLabel";
            this.ResendVerificationCodeLabel.Size = new System.Drawing.Size(201, 16);
            this.ResendVerificationCodeLabel.TabIndex = 20;
            this.ResendVerificationCodeLabel.Text = "Не пришел код? отправить еще раз";
            this.ResendVerificationCodeLabel.Visible = false;
            this.ResendVerificationCodeLabel.Click += new System.EventHandler(this.ResendVerificationCodeLabel_Click);
            // 
            // verificationCodeTextField
            // 
            this.verificationCodeTextField.BackColor = System.Drawing.SystemColors.Control;
            this.verificationCodeTextField.Depth = 0;
            this.verificationCodeTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verificationCodeTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verificationCodeTextField.Hint = "Код подтверждения";
            this.verificationCodeTextField.Location = new System.Drawing.Point(38, 234);
            this.verificationCodeTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.verificationCodeTextField.Name = "verificationCodeTextField";
            this.verificationCodeTextField.PasswordChar = '\0';
            this.verificationCodeTextField.SelectedText = "";
            this.verificationCodeTextField.SelectionLength = 0;
            this.verificationCodeTextField.SelectionStart = 0;
            this.verificationCodeTextField.Size = new System.Drawing.Size(223, 23);
            this.verificationCodeTextField.TabIndex = 19;
            this.verificationCodeTextField.UseSystemPasswordChar = false;
            this.verificationCodeTextField.Visible = false;
            // 
            // VerificationCodeInfoLabel
            // 
            this.VerificationCodeInfoLabel.ForeColor = System.Drawing.Color.Silver;
            this.VerificationCodeInfoLabel.Location = new System.Drawing.Point(57, 185);
            this.VerificationCodeInfoLabel.Name = "VerificationCodeInfoLabel";
            this.VerificationCodeInfoLabel.Size = new System.Drawing.Size(187, 39);
            this.VerificationCodeInfoLabel.TabIndex = 18;
            this.VerificationCodeInfoLabel.Text = "Мы отправили на вашу почту код подтверждения, пожалуйста введите его в поле ниже";
            this.VerificationCodeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VerificationCodeInfoLabel.Visible = false;
            // 
            // recoverPasswordButton
            // 
            this.recoverPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverPasswordButton.Image = global::Biblio.Properties.Resources.passwordRecovery;
            this.recoverPasswordButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recoverPasswordButton.Location = new System.Drawing.Point(37, 296);
            this.recoverPasswordButton.Name = "recoverPasswordButton";
            this.recoverPasswordButton.Size = new System.Drawing.Size(224, 34);
            this.recoverPasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recoverPasswordButton.TabIndex = 17;
            this.recoverPasswordButton.TabStop = false;
            this.recoverPasswordButton.Click += new System.EventHandler(this.recoverPasswordButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Восстановление пароля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailTextField
            // 
            this.mailTextField.BackColor = System.Drawing.SystemColors.Control;
            this.mailTextField.Depth = 0;
            this.mailTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mailTextField.Hint = "Почта";
            this.mailTextField.Location = new System.Drawing.Point(38, 150);
            this.mailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailTextField.Name = "mailTextField";
            this.mailTextField.PasswordChar = '\0';
            this.mailTextField.SelectedText = "";
            this.mailTextField.SelectionLength = 0;
            this.mailTextField.SelectionStart = 0;
            this.mailTextField.Size = new System.Drawing.Size(223, 23);
            this.mailTextField.TabIndex = 2;
            this.mailTextField.UseSystemPasswordChar = false;
            // 
            // whitePanel
            // 
            this.whitePanel.BackColor = System.Drawing.SystemColors.Control;
            this.whitePanel.Controls.Add(this.closeButton);
            this.whitePanel.Controls.Add(this.collapseButton);
            this.whitePanel.Location = new System.Drawing.Point(0, 0);
            this.whitePanel.Name = "whitePanel";
            this.whitePanel.Size = new System.Drawing.Size(300, 24);
            this.whitePanel.TabIndex = 19;
            // 
            // closeButton
            // 
            this.closeButton.Image = global::Biblio.Properties.Resources.close;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(272, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(17, 17);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 18;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Image = global::Biblio.Properties.Resources.collapse;
            this.collapseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.collapseButton.Location = new System.Drawing.Point(248, 3);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(17, 17);
            this.collapseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapseButton.TabIndex = 19;
            this.collapseButton.TabStop = false;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.whitePanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoverPasswordButton)).EndInit();
            this.whitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailTextField;
        private System.Windows.Forms.PictureBox recoverPasswordButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField verificationCodeTextField;
        private System.Windows.Forms.Label VerificationCodeInfoLabel;
        private System.Windows.Forms.Label ResendVerificationCodeLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel whitePanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}