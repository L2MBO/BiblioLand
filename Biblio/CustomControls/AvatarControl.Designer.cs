namespace Biblio.CustomControls
{
    partial class AvatarControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.avatarPanel = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.delimiter3 = new System.Windows.Forms.Panel();
            this.adminButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.delimiter2 = new System.Windows.Forms.Panel();
            this.addContentButton = new Guna.UI2.WinForms.Guna2Button();
            this.delimiter1 = new System.Windows.Forms.Panel();
            this.feedbackButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userAvatarPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.avatarPanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.avatarPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 263);
            this.mainPanel.TabIndex = 0;
            // 
            // avatarPanel
            // 
            this.avatarPanel.Controls.Add(this.exitButton);
            this.avatarPanel.Controls.Add(this.flowLayoutPanel1);
            this.avatarPanel.Controls.Add(this.panel7);
            this.avatarPanel.Controls.Add(this.panel4);
            this.avatarPanel.Controls.Add(this.settingsButton);
            this.avatarPanel.Controls.Add(this.delimiter3);
            this.avatarPanel.Controls.Add(this.adminButton);
            this.avatarPanel.Controls.Add(this.panel3);
            this.avatarPanel.Controls.Add(this.line1);
            this.avatarPanel.Controls.Add(this.delimiter2);
            this.avatarPanel.Controls.Add(this.addContentButton);
            this.avatarPanel.Controls.Add(this.delimiter1);
            this.avatarPanel.Controls.Add(this.feedbackButton);
            this.avatarPanel.Controls.Add(this.panel5);
            this.avatarPanel.Controls.Add(this.panel6);
            this.avatarPanel.Controls.Add(this.flowLayoutPanel2);
            this.avatarPanel.Controls.Add(this.userInfoPanel);
            this.avatarPanel.Location = new System.Drawing.Point(20, 20);
            this.avatarPanel.Name = "avatarPanel";
            this.avatarPanel.Size = new System.Drawing.Size(160, 223);
            this.avatarPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.exitButton.BorderRadius = 9;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.exitButton.Image = global::Biblio.Properties.Resources.log_out;
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exitButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.exitButton.ImageSize = new System.Drawing.Size(15, 15);
            this.exitButton.Location = new System.Drawing.Point(0, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.exitButton.Size = new System.Drawing.Size(160, 20);
            this.exitButton.TabIndex = 46;
            this.exitButton.Text = "Выход";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitButton.TextOffset = new System.Drawing.Point(-5, -1);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 10);
            this.flowLayoutPanel1.TabIndex = 45;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 1);
            this.panel7.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 10);
            this.panel4.TabIndex = 43;
            // 
            // settingsButton
            // 
            this.settingsButton.Animated = true;
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.settingsButton.BorderRadius = 9;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = global::Biblio.Properties.Resources.gear;
            this.settingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.settingsButton.ImageSize = new System.Drawing.Size(15, 15);
            this.settingsButton.Location = new System.Drawing.Point(0, 162);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.settingsButton.Size = new System.Drawing.Size(160, 20);
            this.settingsButton.TabIndex = 42;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.TextOffset = new System.Drawing.Point(-5, -1);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // delimiter3
            // 
            this.delimiter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiter3.Location = new System.Drawing.Point(0, 152);
            this.delimiter3.Name = "delimiter3";
            this.delimiter3.Size = new System.Drawing.Size(160, 10);
            this.delimiter3.TabIndex = 41;
            this.delimiter3.Visible = false;
            // 
            // adminButton
            // 
            this.adminButton.Animated = true;
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.adminButton.BorderRadius = 9;
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Image = global::Biblio.Properties.Resources.admin;
            this.adminButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adminButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.adminButton.ImageSize = new System.Drawing.Size(15, 15);
            this.adminButton.Location = new System.Drawing.Point(0, 132);
            this.adminButton.Name = "adminButton";
            this.adminButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.adminButton.Size = new System.Drawing.Size(160, 20);
            this.adminButton.TabIndex = 40;
            this.adminButton.Text = "Админ панель";
            this.adminButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminButton.TextOffset = new System.Drawing.Point(-5, -1);
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 10);
            this.panel3.TabIndex = 39;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line1.Dock = System.Windows.Forms.DockStyle.Top;
            this.line1.Location = new System.Drawing.Point(0, 121);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(160, 1);
            this.line1.TabIndex = 38;
            this.line1.Visible = false;
            // 
            // delimiter2
            // 
            this.delimiter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiter2.Location = new System.Drawing.Point(0, 111);
            this.delimiter2.Name = "delimiter2";
            this.delimiter2.Size = new System.Drawing.Size(160, 10);
            this.delimiter2.TabIndex = 37;
            this.delimiter2.Visible = false;
            // 
            // addContentButton
            // 
            this.addContentButton.Animated = true;
            this.addContentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.addContentButton.BorderRadius = 9;
            this.addContentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addContentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addContentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addContentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addContentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addContentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addContentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.addContentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addContentButton.ForeColor = System.Drawing.Color.White;
            this.addContentButton.Image = global::Biblio.Properties.Resources.rightArrow;
            this.addContentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addContentButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.addContentButton.ImageSize = new System.Drawing.Size(10, 15);
            this.addContentButton.Location = new System.Drawing.Point(0, 91);
            this.addContentButton.Name = "addContentButton";
            this.addContentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.addContentButton.Size = new System.Drawing.Size(160, 20);
            this.addContentButton.TabIndex = 36;
            this.addContentButton.Text = "Добавить контент";
            this.addContentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addContentButton.TextOffset = new System.Drawing.Point(-5, -1);
            this.addContentButton.Visible = false;
            this.addContentButton.Click += new System.EventHandler(this.addContentButton_Click);
            // 
            // delimiter1
            // 
            this.delimiter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiter1.Location = new System.Drawing.Point(0, 81);
            this.delimiter1.Name = "delimiter1";
            this.delimiter1.Size = new System.Drawing.Size(160, 10);
            this.delimiter1.TabIndex = 35;
            this.delimiter1.Visible = false;
            // 
            // feedbackButton
            // 
            this.feedbackButton.Animated = true;
            this.feedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.feedbackButton.BorderRadius = 9;
            this.feedbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feedbackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feedbackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedbackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feedbackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.feedbackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbackButton.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.Image = global::Biblio.Properties.Resources.chat;
            this.feedbackButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.feedbackButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.feedbackButton.ImageSize = new System.Drawing.Size(15, 15);
            this.feedbackButton.Location = new System.Drawing.Point(0, 61);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.feedbackButton.Size = new System.Drawing.Size(160, 20);
            this.feedbackButton.TabIndex = 34;
            this.feedbackButton.Text = "Обратная связь";
            this.feedbackButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.feedbackButton.TextOffset = new System.Drawing.Point(-5, -1);
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 10);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 1);
            this.panel6.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(160, 10);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.panel2);
            this.userInfoPanel.Controls.Add(this.userAvatarPictureBox);
            this.userInfoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(160, 40);
            this.userInfoPanel.TabIndex = 13;
            this.userInfoPanel.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Location = new System.Drawing.Point(49, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 30);
            this.panel2.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoEllipsis = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 30);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Имя";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameLabel.Click += new System.EventHandler(this.userProfile_Click);
            this.userNameLabel.MouseEnter += new System.EventHandler(this.UserNameLabel_MouseEnter);
            this.userNameLabel.MouseLeave += new System.EventHandler(this.UserNameLabel_MouseLeave);
            // 
            // userAvatarPictureBox
            // 
            this.userAvatarPictureBox.BorderRadius = 10;
            this.userAvatarPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.userAvatarPictureBox.FillColor = System.Drawing.Color.Red;
            this.userAvatarPictureBox.ImageRotate = 0F;
            this.userAvatarPictureBox.Location = new System.Drawing.Point(0, 0);
            this.userAvatarPictureBox.Name = "userAvatarPictureBox";
            this.userAvatarPictureBox.Size = new System.Drawing.Size(40, 40);
            this.userAvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatarPictureBox.TabIndex = 1;
            this.userAvatarPictureBox.TabStop = false;
            this.userAvatarPictureBox.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // AvatarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "AvatarControl";
            this.Size = new System.Drawing.Size(201, 264);
            this.mainPanel.ResumeLayout(false);
            this.avatarPanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel avatarPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox userAvatarPictureBox;
        private Guna.UI2.WinForms.Guna2Button addContentButton;
        private System.Windows.Forms.Panel delimiter1;
        private Guna.UI2.WinForms.Guna2Button feedbackButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private System.Windows.Forms.Panel delimiter3;
        private Guna.UI2.WinForms.Guna2Button adminButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel delimiter2;
    }
}
