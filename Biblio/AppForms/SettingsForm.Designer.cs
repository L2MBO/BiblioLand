namespace Biblio.AppForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.settingsTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.saveProfileButton = new Guna.UI2.WinForms.Guna2Button();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avatarPanel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.deleteAvatarButton = new Guna.UI2.WinForms.Guna2Button();
            this.changeAvatarButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.changePasswordPage = new System.Windows.Forms.TabPage();
            this.savePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.passwordRuleLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.oldPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.changeMailPage = new System.Windows.Forms.TabPage();
            this.saveMailButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.newMailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newMailLabel = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.navigationControl = new Biblio.CustomControls.NavigationControl();
            this.mainPanel.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.profilePage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.avatarPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.changePasswordPage.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.changeMailPage.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 11;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.settingsTabControl);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 4;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.settingsTabControl.Controls.Add(this.profilePage);
            this.settingsTabControl.Controls.Add(this.changePasswordPage);
            this.settingsTabControl.Controls.Add(this.changeMailPage);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabControl.ItemSize = new System.Drawing.Size(105, 30);
            this.settingsTabControl.Location = new System.Drawing.Point(100, 63);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(526, 315);
            this.settingsTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.settingsTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.settingsTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.settingsTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.settingsTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.settingsTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.settingsTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.settingsTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.settingsTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.settingsTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.settingsTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.settingsTabControl.TabButtonSize = new System.Drawing.Size(105, 30);
            this.settingsTabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsTabControl.TabIndex = 25;
            this.settingsTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            // 
            // profilePage
            // 
            this.profilePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.profilePage.Controls.Add(this.panel4);
            this.profilePage.Location = new System.Drawing.Point(109, 4);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(413, 307);
            this.profilePage.TabIndex = 0;
            this.profilePage.Text = "Профиль";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.descriptionPanel);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.avatarPanel);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 301);
            this.panel4.TabIndex = 8;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.saveProfileButton);
            this.descriptionPanel.Controls.Add(this.descriptionTextBox);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(10, 196);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(397, 105);
            this.descriptionPanel.TabIndex = 45;
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Animated = true;
            this.saveProfileButton.BorderRadius = 13;
            this.saveProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveProfileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveProfileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveProfileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveProfileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveProfileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.saveProfileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveProfileButton.ForeColor = System.Drawing.Color.White;
            this.saveProfileButton.Location = new System.Drawing.Point(0, 74);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.saveProfileButton.Size = new System.Drawing.Size(156, 28);
            this.saveProfileButton.TabIndex = 48;
            this.saveProfileButton.Text = "Сохранить изменения";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Animated = true;
            this.descriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTextBox.BorderRadius = 10;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.MaxLength = 600;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.descriptionTextBox.PlaceholderText = "";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(397, 66);
            this.descriptionTextBox.TabIndex = 47;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 141);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 55);
            this.panel8.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(-2, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "За недопустимый по правилам ник Вы можете получить бан.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "О себе";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.userNameTextBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 71);
            this.panel7.TabIndex = 43;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Animated = true;
            this.userNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameTextBox.BorderRadius = 17;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.White;
            this.userNameTextBox.Location = new System.Drawing.Point(0, 35);
            this.userNameTextBox.MaxLength = 20;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(397, 36);
            this.userNameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Никнейм";
            // 
            // avatarPanel
            // 
            this.avatarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.avatarPanel.Controls.Add(this.panel10);
            this.avatarPanel.Controls.Add(this.panel9);
            this.avatarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.avatarPanel.Location = new System.Drawing.Point(10, 0);
            this.avatarPanel.Name = "avatarPanel";
            this.avatarPanel.Size = new System.Drawing.Size(397, 70);
            this.avatarPanel.TabIndex = 38;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.deleteAvatarButton);
            this.panel10.Controls.Add(this.changeAvatarButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(63, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(334, 70);
            this.panel10.TabIndex = 11;
            // 
            // deleteAvatarButton
            // 
            this.deleteAvatarButton.Animated = true;
            this.deleteAvatarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.deleteAvatarButton.BorderRadius = 9;
            this.deleteAvatarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAvatarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteAvatarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteAvatarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteAvatarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteAvatarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.deleteAvatarButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAvatarButton.ForeColor = System.Drawing.Color.White;
            this.deleteAvatarButton.Location = new System.Drawing.Point(6, 45);
            this.deleteAvatarButton.Name = "deleteAvatarButton";
            this.deleteAvatarButton.PressedColor = System.Drawing.Color.DarkRed;
            this.deleteAvatarButton.Size = new System.Drawing.Size(79, 19);
            this.deleteAvatarButton.TabIndex = 10;
            this.deleteAvatarButton.Text = "Удалить";
            // 
            // changeAvatarButton
            // 
            this.changeAvatarButton.Animated = true;
            this.changeAvatarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.changeAvatarButton.BorderRadius = 9;
            this.changeAvatarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeAvatarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeAvatarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeAvatarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeAvatarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeAvatarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.changeAvatarButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeAvatarButton.ForeColor = System.Drawing.Color.White;
            this.changeAvatarButton.Location = new System.Drawing.Point(6, 20);
            this.changeAvatarButton.Name = "changeAvatarButton";
            this.changeAvatarButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.changeAvatarButton.Size = new System.Drawing.Size(79, 19);
            this.changeAvatarButton.TabIndex = 9;
            this.changeAvatarButton.Text = "Изменить";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.avatarPictureBox);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(63, 70);
            this.panel9.TabIndex = 9;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BorderRadius = 7;
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(0, 20);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(44, 44);
            this.avatarPictureBox.TabIndex = 8;
            this.avatarPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Аватарка";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 301);
            this.panel5.TabIndex = 0;
            // 
            // changePasswordPage
            // 
            this.changePasswordPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.changePasswordPage.Controls.Add(this.savePasswordButton);
            this.changePasswordPage.Controls.Add(this.panel13);
            this.changePasswordPage.Controls.Add(this.panel12);
            this.changePasswordPage.Controls.Add(this.panel11);
            this.changePasswordPage.Controls.Add(this.panel6);
            this.changePasswordPage.Location = new System.Drawing.Point(109, 4);
            this.changePasswordPage.Name = "changePasswordPage";
            this.changePasswordPage.Padding = new System.Windows.Forms.Padding(3);
            this.changePasswordPage.Size = new System.Drawing.Size(413, 307);
            this.changePasswordPage.TabIndex = 1;
            this.changePasswordPage.Text = "Смена пароля";
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Animated = true;
            this.savePasswordButton.BorderRadius = 13;
            this.savePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savePasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savePasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savePasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savePasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.savePasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savePasswordButton.ForeColor = System.Drawing.Color.White;
            this.savePasswordButton.Location = new System.Drawing.Point(13, 248);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.savePasswordButton.Size = new System.Drawing.Size(156, 28);
            this.savePasswordButton.TabIndex = 49;
            this.savePasswordButton.Text = "Сохранить изменения";
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.passwordRuleLabel);
            this.panel13.Controls.Add(this.confirmPasswordTextBox);
            this.panel13.Controls.Add(this.confirmPasswordLabel);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(13, 145);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(397, 86);
            this.panel13.TabIndex = 46;
            // 
            // passwordRuleLabel
            // 
            this.passwordRuleLabel.AutoSize = true;
            this.passwordRuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRuleLabel.ForeColor = System.Drawing.Color.Silver;
            this.passwordRuleLabel.Location = new System.Drawing.Point(-2, 1);
            this.passwordRuleLabel.Name = "passwordRuleLabel";
            this.passwordRuleLabel.Size = new System.Drawing.Size(331, 13);
            this.passwordRuleLabel.TabIndex = 12;
            this.passwordRuleLabel.Text = "Заглавные, строчные, символы и цифры. Минимум 8 символов";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPasswordTextBox.BorderRadius = 17;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTextBox.DefaultText = "";
            this.confirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(0, 50);
            this.confirmPasswordTextBox.MaxLength = 64;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.confirmPasswordTextBox.PlaceholderText = "";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(397, 36);
            this.confirmPasswordTextBox.TabIndex = 11;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(-2, 30);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(151, 13);
            this.confirmPasswordLabel.TabIndex = 5;
            this.confirmPasswordLabel.Text = "Новый пароль повторно";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.newPasswordTextBox);
            this.panel12.Controls.Add(this.newPasswordLabel);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(13, 74);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(397, 71);
            this.panel12.TabIndex = 45;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordTextBox.BorderRadius = 17;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.newPasswordTextBox.Location = new System.Drawing.Point(0, 35);
            this.newPasswordTextBox.MaxLength = 64;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.newPasswordTextBox.PlaceholderText = "";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.Size = new System.Drawing.Size(397, 36);
            this.newPasswordTextBox.TabIndex = 11;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.newPasswordLabel.Location = new System.Drawing.Point(-2, 15);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(92, 13);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "Новый пароль";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.oldPasswordTextBox);
            this.panel11.Controls.Add(this.oldPasswordLabel);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(13, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(397, 71);
            this.panel11.TabIndex = 44;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Animated = true;
            this.oldPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldPasswordTextBox.BorderRadius = 17;
            this.oldPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPasswordTextBox.DefaultText = "";
            this.oldPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oldPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(0, 35);
            this.oldPasswordTextBox.MaxLength = 64;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.oldPasswordTextBox.PlaceholderText = "";
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(397, 36);
            this.oldPasswordTextBox.TabIndex = 11;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.oldPasswordLabel.Location = new System.Drawing.Point(-2, 15);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(97, 13);
            this.oldPasswordLabel.TabIndex = 5;
            this.oldPasswordLabel.Text = "Старый пароль";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 301);
            this.panel6.TabIndex = 1;
            // 
            // changeMailPage
            // 
            this.changeMailPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.changeMailPage.Controls.Add(this.saveMailButton);
            this.changeMailPage.Controls.Add(this.label7);
            this.changeMailPage.Controls.Add(this.panel15);
            this.changeMailPage.Controls.Add(this.panel14);
            this.changeMailPage.Location = new System.Drawing.Point(109, 4);
            this.changeMailPage.Name = "changeMailPage";
            this.changeMailPage.Padding = new System.Windows.Forms.Padding(3);
            this.changeMailPage.Size = new System.Drawing.Size(413, 307);
            this.changeMailPage.TabIndex = 2;
            this.changeMailPage.Text = "Смена почты";
            // 
            // saveMailButton
            // 
            this.saveMailButton.Animated = true;
            this.saveMailButton.BorderRadius = 13;
            this.saveMailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveMailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveMailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveMailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveMailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveMailButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.saveMailButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveMailButton.ForeColor = System.Drawing.Color.White;
            this.saveMailButton.Location = new System.Drawing.Point(13, 110);
            this.saveMailButton.Name = "saveMailButton";
            this.saveMailButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.saveMailButton.Size = new System.Drawing.Size(156, 28);
            this.saveMailButton.TabIndex = 50;
            this.saveMailButton.Text = "Сохранить изменения";
            this.saveMailButton.Click += new System.EventHandler(this.saveMailButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(11, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "На нее будут приходить новые письма";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.newMailTextBox);
            this.panel15.Controls.Add(this.newMailLabel);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(13, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(397, 71);
            this.panel15.TabIndex = 45;
            // 
            // newMailTextBox
            // 
            this.newMailTextBox.Animated = true;
            this.newMailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newMailTextBox.BorderRadius = 17;
            this.newMailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newMailTextBox.DefaultText = "";
            this.newMailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newMailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newMailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newMailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newMailTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newMailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.newMailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newMailTextBox.ForeColor = System.Drawing.Color.White;
            this.newMailTextBox.Location = new System.Drawing.Point(0, 35);
            this.newMailTextBox.MaxLength = 60;
            this.newMailTextBox.Name = "newMailTextBox";
            this.newMailTextBox.PasswordChar = '*';
            this.newMailTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.newMailTextBox.PlaceholderText = "";
            this.newMailTextBox.SelectedText = "";
            this.newMailTextBox.Size = new System.Drawing.Size(397, 36);
            this.newMailTextBox.TabIndex = 11;
            // 
            // newMailLabel
            // 
            this.newMailLabel.AutoSize = true;
            this.newMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMailLabel.ForeColor = System.Drawing.Color.White;
            this.newMailLabel.Location = new System.Drawing.Point(-2, 15);
            this.newMailLabel.Name = "newMailLabel";
            this.newMailLabel.Size = new System.Drawing.Size(81, 13);
            this.newMailLabel.TabIndex = 5;
            this.newMailLabel.Text = "Новая почта";
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 301);
            this.panel14.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(100, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 14);
            this.panel3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 49);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(626, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 378);
            this.rightPanel.TabIndex = 22;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 378);
            this.leftPanel.TabIndex = 21;
            // 
            // navigationControl
            // 
            this.navigationControl.AutoSize = true;
            this.navigationControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.navigationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationControl.leftPanel = null;
            this.navigationControl.LeftPanelWidth = 0;
            this.navigationControl.Location = new System.Drawing.Point(0, 0);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(726, 52);
            this.navigationControl.TabIndex = 0;
            this.navigationControl.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            this.profilePage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.descriptionPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.avatarPanel.ResumeLayout(false);
            this.avatarPanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.changePasswordPage.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.changeMailPage.ResumeLayout(false);
            this.changeMailPage.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TabControl settingsTabControl;
        private System.Windows.Forms.TabPage profilePage;
        private System.Windows.Forms.TabPage changePasswordPage;
        private System.Windows.Forms.TabPage changeMailPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel avatarPanel;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2Button deleteAvatarButton;
        private Guna.UI2.WinForms.Guna2Button changeAvatarButton;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel descriptionPanel;
        private Guna.UI2.WinForms.Guna2Button saveProfileButton;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel13;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button savePasswordButton;
        private System.Windows.Forms.Label passwordRuleLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI2.WinForms.Guna2TextBox newMailTextBox;
        private System.Windows.Forms.Label newMailLabel;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2Button saveMailButton;
    }
}