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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.blockLogInLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.PictureBox();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.unvisiblePassword = new System.Windows.Forms.PictureBox();
            this.fogetPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.registrationButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.whitePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationButton)).BeginInit();
            this.redPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blockLogInLabel);
            this.panel1.Controls.Add(this.timerLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logInButton);
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
            // logInButton
            // 
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Image = global::Biblio.Properties.Resources.logIn;
            this.logInButton.Location = new System.Drawing.Point(90, 270);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(118, 34);
            this.logInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logInButton.TabIndex = 10;
            this.logInButton.TabStop = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
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
            // fogetPasswordLabel
            // 
            this.fogetPasswordLabel.AutoSize = true;
            this.fogetPasswordLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fogetPasswordLabel.Location = new System.Drawing.Point(88, 240);
            this.fogetPasswordLabel.Name = "fogetPasswordLabel";
            this.fogetPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.fogetPasswordLabel.TabIndex = 7;
            this.fogetPasswordLabel.Text = "Забыли пароль?";
            this.fogetPasswordLabel.Click += new System.EventHandler(this.fogetPasswordLabel_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.registrationButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(300, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 326);
            this.panel2.TabIndex = 1;
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
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Image = global::Biblio.Properties.Resources.registr;
            this.registrationButton.Location = new System.Drawing.Point(81, 204);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(152, 34);
            this.registrationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registrationButton.TabIndex = 11;
            this.registrationButton.TabStop = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
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
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.redPanel.Controls.Add(this.closeButton);
            this.redPanel.Controls.Add(this.collapseButton);
            this.redPanel.Location = new System.Drawing.Point(300, 0);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(300, 24);
            this.redPanel.TabIndex = 19;
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
            // whitePanel
            // 
            this.whitePanel.BackColor = System.Drawing.SystemColors.Control;
            this.whitePanel.Location = new System.Drawing.Point(0, 0);
            this.whitePanel.Name = "whitePanel";
            this.whitePanel.Size = new System.Drawing.Size(300, 24);
            this.whitePanel.TabIndex = 20;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationButton)).EndInit();
            this.redPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fogetPasswordLabel;
        private System.Windows.Forms.PictureBox visiblePassword;
        private System.Windows.Forms.PictureBox unvisiblePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logInButton;
        private System.Windows.Forms.PictureBox registrationButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel whitePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label blockLogInLabel;
    }
}