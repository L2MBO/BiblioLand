namespace Biblio.AppForms
{
    partial class AuthorizationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.whitePanel = new System.Windows.Forms.Panel();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.fogetPasswordLabel = new System.Windows.Forms.Label();
            this.unvisiblePassword = new System.Windows.Forms.PictureBox();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.blockLogInLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logInButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registrationButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.redPanel = new System.Windows.Forms.Panel();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.redPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // whitePanel
            // 
            this.whitePanel.BackColor = System.Drawing.SystemColors.Control;
            this.whitePanel.Location = new System.Drawing.Point(0, 0);
            this.whitePanel.Name = "whitePanel";
            this.whitePanel.Size = new System.Drawing.Size(300, 24);
            this.whitePanel.TabIndex = 20;
            this.whitePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // nameTextField
            // 
            this.nameTextField.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextField.Depth = 0;
            this.nameTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextField.Hint = "Имя пользователя";
            this.nameTextField.Location = new System.Drawing.Point(39, 133);
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(223, 23);
            this.nameTextField.TabIndex = 1;
            this.nameTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(39, 176);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(190, 23);
            this.passwordTextField.TabIndex = 2;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Авторизация";
            // 
            // fogetPasswordLabel
            // 
            this.fogetPasswordLabel.AutoSize = true;
            this.fogetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fogetPasswordLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fogetPasswordLabel.Location = new System.Drawing.Point(88, 240);
            this.fogetPasswordLabel.Name = "fogetPasswordLabel";
            this.fogetPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.fogetPasswordLabel.TabIndex = 7;
            this.fogetPasswordLabel.Text = "Забыли пароль?";
            this.fogetPasswordLabel.Click += new System.EventHandler(this.fogetPasswordLabel_Click);
            // 
            // unvisiblePassword
            // 
            this.unvisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unvisiblePassword.Image = global::Biblio.Properties.Resources.unVisiblePussword;
            this.unvisiblePassword.Location = new System.Drawing.Point(237, 186);
            this.unvisiblePassword.Name = "unvisiblePassword";
            this.unvisiblePassword.Size = new System.Drawing.Size(25, 13);
            this.unvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unvisiblePassword.TabIndex = 8;
            this.unvisiblePassword.TabStop = false;
            this.unvisiblePassword.Visible = false;
            this.unvisiblePassword.Click += new System.EventHandler(this.unvisiblePassword_Click);
            // 
            // visiblePassword
            // 
            this.visiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblePassword.Image = global::Biblio.Properties.Resources.visiblePussword;
            this.visiblePassword.Location = new System.Drawing.Point(237, 186);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(25, 13);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 9;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.timerLabel.ForeColor = System.Drawing.Color.Gray;
            this.timerLabel.Location = new System.Drawing.Point(218, 215);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 16);
            this.timerLabel.TabIndex = 22;
            this.timerLabel.Visible = false;
            // 
            // blockLogInLabel
            // 
            this.blockLogInLabel.AutoSize = true;
            this.blockLogInLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.blockLogInLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockLogInLabel.ForeColor = System.Drawing.Color.Gray;
            this.blockLogInLabel.Location = new System.Drawing.Point(68, 214);
            this.blockLogInLabel.Name = "blockLogInLabel";
            this.blockLogInLabel.Size = new System.Drawing.Size(153, 16);
            this.blockLogInLabel.TabIndex = 23;
            this.blockLogInLabel.Text = "Повторите попытку через:";
            this.blockLogInLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logInButton);
            this.panel1.Controls.Add(this.blockLogInLabel);
            this.panel1.Controls.Add(this.timerLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.visiblePassword);
            this.panel1.Controls.Add(this.unvisiblePassword);
            this.panel1.Controls.Add(this.fogetPasswordLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordTextField);
            this.panel1.Controls.Add(this.nameTextField);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 326);
            this.panel1.TabIndex = 0;
            // 
            // logInButton
            // 
            this.logInButton.Animated = true;
            this.logInButton.BorderRadius = 17;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.IndicateFocus = true;
            this.logInButton.Location = new System.Drawing.Point(90, 270);
            this.logInButton.Name = "logInButton";
            this.logInButton.PressedColor = System.Drawing.Color.Maroon;
            this.logInButton.Size = new System.Drawing.Size(118, 34);
            this.logInButton.TabIndex = 3;
            this.logInButton.Text = "ВХОД";
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Biblio.Properties.Resources.greyLine;
            this.pictureBox2.Location = new System.Drawing.Point(14, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Привет, читатель!";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введи свои личные данные и начни путешествие вместе с нами";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.registrationButton);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(300, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 326);
            this.panel2.TabIndex = 1;
            // 
            // registrationButton
            // 
            this.registrationButton.Animated = true;
            this.registrationButton.BorderColor = System.Drawing.Color.White;
            this.registrationButton.BorderRadius = 17;
            this.registrationButton.BorderThickness = 1;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registrationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registrationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registrationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registrationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.IndicateFocus = true;
            this.registrationButton.Location = new System.Drawing.Point(81, 204);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.PressedColor = System.Drawing.Color.Maroon;
            this.registrationButton.Size = new System.Drawing.Size(152, 34);
            this.registrationButton.TabIndex = 4;
            this.registrationButton.Text = "РЕГИСТРАЦИЯ";
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Biblio.Properties.Resources.greyLine;
            this.pictureBox3.Location = new System.Drawing.Point(-11, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(296, 11);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // collapseButton
            // 
            this.collapseButton.Image = global::Biblio.Properties.Resources.blackCollapse;
            this.collapseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.collapseButton.Location = new System.Drawing.Point(248, 3);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(17, 17);
            this.collapseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapseButton.TabIndex = 19;
            this.collapseButton.TabStop = false;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::Biblio.Properties.Resources.blackClose;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(272, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(17, 17);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 18;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.redPanel.Controls.Add(this.closeButton);
            this.redPanel.Controls.Add(this.collapseButton);
            this.redPanel.Location = new System.Drawing.Point(300, 0);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(300, 24);
            this.redPanel.TabIndex = 19;
            this.redPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 20;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.whitePanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.redPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel whitePanel;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label blockLogInLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox visiblePassword;
        private System.Windows.Forms.PictureBox unvisiblePassword;
        private System.Windows.Forms.Label fogetPasswordLabel;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Button logInButton;
        private Guna.UI2.WinForms.Guna2Button registrationButton;
    }
}