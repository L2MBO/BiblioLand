namespace Biblio.AppForms
{
    partial class RecoverPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.unvisiblePassword = new System.Windows.Forms.PictureBox();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.changePasswordButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.whitePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordButton)).BeginInit();
            this.whitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmPasswordTextField);
            this.panel1.Controls.Add(this.visiblePassword);
            this.panel1.Controls.Add(this.unvisiblePassword);
            this.panel1.Controls.Add(this.passwordTextField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.changePasswordButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 378);
            this.panel1.TabIndex = 2;
            // 
            // confirmPasswordTextField
            // 
            this.confirmPasswordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPasswordTextField.Depth = 0;
            this.confirmPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.confirmPasswordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPasswordTextField.Hint = "Подтверждение пароля";
            this.confirmPasswordTextField.Location = new System.Drawing.Point(39, 203);
            this.confirmPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmPasswordTextField.Name = "confirmPasswordTextField";
            this.confirmPasswordTextField.PasswordChar = '*';
            this.confirmPasswordTextField.SelectedText = "";
            this.confirmPasswordTextField.SelectionLength = 0;
            this.confirmPasswordTextField.SelectionStart = 0;
            this.confirmPasswordTextField.Size = new System.Drawing.Size(190, 23);
            this.confirmPasswordTextField.TabIndex = 26;
            this.confirmPasswordTextField.UseSystemPasswordChar = false;
            // 
            // visiblePassword
            // 
            this.visiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblePassword.Image = global::Biblio.Properties.Resources.visiblePussword;
            this.visiblePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.visiblePassword.Location = new System.Drawing.Point(237, 200);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(25, 13);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 25;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // unvisiblePassword
            // 
            this.unvisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unvisiblePassword.Image = global::Biblio.Properties.Resources.unVisiblePussword;
            this.unvisiblePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unvisiblePassword.Location = new System.Drawing.Point(237, 200);
            this.unvisiblePassword.Name = "unvisiblePassword";
            this.unvisiblePassword.Size = new System.Drawing.Size(25, 13);
            this.unvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unvisiblePassword.TabIndex = 24;
            this.unvisiblePassword.TabStop = false;
            this.unvisiblePassword.Visible = false;
            this.unvisiblePassword.Click += new System.EventHandler(this.unvisiblePassword_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(39, 167);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(190, 23);
            this.passwordTextField.TabIndex = 23;
            this.passwordTextField.UseSystemPasswordChar = false;
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
            // changePasswordButton
            // 
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.Image = global::Biblio.Properties.Resources.newPassword;
            this.changePasswordButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changePasswordButton.Location = new System.Drawing.Point(66, 296);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(170, 34);
            this.changePasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changePasswordButton.TabIndex = 17;
            this.changePasswordButton.TabStop = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Смена пароля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whitePanel
            // 
            this.whitePanel.BackColor = System.Drawing.SystemColors.Control;
            this.whitePanel.Controls.Add(this.closeButton);
            this.whitePanel.Controls.Add(this.collapseButton);
            this.whitePanel.Location = new System.Drawing.Point(0, 0);
            this.whitePanel.Name = "whitePanel";
            this.whitePanel.Size = new System.Drawing.Size(300, 24);
            this.whitePanel.TabIndex = 23;
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
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.whitePanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoverPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPasswordForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordButton)).EndInit();
            this.whitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox changePasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel whitePanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmPasswordTextField;
        private System.Windows.Forms.PictureBox visiblePassword;
        private System.Windows.Forms.PictureBox unvisiblePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
    }
}