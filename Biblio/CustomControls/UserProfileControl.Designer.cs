namespace Biblio.CustomControls
{
    partial class UserProfileControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.statusPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 1);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(525, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 50);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.mainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.BorderRadius = 10;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.statusPictureBox);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.avatarPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(525, 50);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.roleLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(299, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 50);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(0, 18);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(137, 13);
            this.roleLabel.TabIndex = 4;
            this.roleLabel.Text = "Супер администратор";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roleLabel.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.statusPictureBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusPictureBox.ImageRotate = 0F;
            this.statusPictureBox.Location = new System.Drawing.Point(49, 19);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.statusPictureBox.Size = new System.Drawing.Size(10, 10);
            this.statusPictureBox.TabIndex = 5;
            this.statusPictureBox.TabStop = false;
            this.statusPictureBox.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.registrationDateLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(442, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 50);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.AutoSize = true;
            this.registrationDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.registrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationDateLabel.ForeColor = System.Drawing.Color.White;
            this.registrationDateLabel.Location = new System.Drawing.Point(3, 18);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(37, 13);
            this.registrationDateLabel.TabIndex = 3;
            this.registrationDateLabel.Text = "Дата";
            this.registrationDateLabel.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(65, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(228, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            this.nameLabel.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.avatarPictureBox.BorderRadius = 6;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(10, 10);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(30, 30);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.UserProfileControl_Click);
            // 
            // UserProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserProfileControl";
            this.Size = new System.Drawing.Size(526, 51);
            this.Click += new System.EventHandler(this.UserProfileControl_Click);
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.Label roleLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox statusPictureBox;
        private System.Windows.Forms.Panel panel4;
    }
}
