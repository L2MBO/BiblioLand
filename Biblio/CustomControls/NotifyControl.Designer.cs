namespace Biblio.CustomControls
{
    partial class NotifyControl
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.mainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.BorderRadius = 10;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.avatarPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(526, 51);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.typeLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(251, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 51);
            this.panel4.TabIndex = 9;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(0, 18);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(156, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Жалоба на комментарий";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dateLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(414, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 51);
            this.panel3.TabIndex = 8;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(3, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(37, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.deleteCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(497, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 51);
            this.panel1.TabIndex = 7;
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.deleteCheckBox.CheckedState.BorderRadius = 0;
            this.deleteCheckBox.CheckedState.BorderThickness = 0;
            this.deleteCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.deleteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteCheckBox.Location = new System.Drawing.Point(7, 18);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(15, 14);
            this.deleteCheckBox.TabIndex = 10;
            this.deleteCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.deleteCheckBox.UncheckedState.BorderRadius = 0;
            this.deleteCheckBox.UncheckedState.BorderThickness = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(44, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(218, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Отправил: ";
            this.nameLabel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.avatarPictureBox.BorderRadius = 6;
            this.avatarPictureBox.Image = global::Biblio.Properties.Resources.logo1;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(10, 10);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(30, 30);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // NotifyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "NotifyControl";
            this.Size = new System.Drawing.Size(526, 51);
            this.Click += new System.EventHandler(this.mainPanel_Click);
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox deleteCheckBox;
    }
}
