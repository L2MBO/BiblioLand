namespace Biblio.CustomControls
{
    partial class UserCommentsControl
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
            this.profileButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.PictureBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.commentLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.likesButton = new System.Windows.Forms.PictureBox();
            this.likesCountLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).BeginInit();
            this.panel26.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 150);
            this.panel1.TabIndex = 0;
            // 
            // profileButton
            // 
            this.profileButton.BorderRadius = 7;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.ImageRotate = 0F;
            this.profileButton.Location = new System.Drawing.Point(0, 0);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(40, 40);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 9;
            this.profileButton.TabStop = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 10);
            this.panel4.TabIndex = 68;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 124);
            this.panel5.TabIndex = 69;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(307, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 124);
            this.panel9.TabIndex = 70;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(10, 124);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(297, 10);
            this.panel16.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Controls.Add(this.reportButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 16);
            this.panel3.TabIndex = 72;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(281, 16);
            this.nameLabel.TabIndex = 65;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportButton
            // 
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportButton.Image = global::Biblio.Properties.Resources.report;
            this.reportButton.Location = new System.Drawing.Point(281, 0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(16, 16);
            this.reportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportButton.TabIndex = 0;
            this.reportButton.TabStop = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(10, 26);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(297, 10);
            this.panel27.TabIndex = 73;
            // 
            // panel26
            // 
            this.panel26.AutoSize = true;
            this.panel26.Controls.Add(this.commentLabel);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(10, 36);
            this.panel26.MinimumSize = new System.Drawing.Size(0, 16);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(297, 16);
            this.panel26.TabIndex = 74;
            // 
            // commentLabel
            // 
            this.commentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(0, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(297, 16);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Комментарий";
            this.commentLabel.TextChanged += new System.EventHandler(this.commentLabel_TextChanged);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.AutoSize = true;
            this.descriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionPanel.BorderRadius = 10;
            this.descriptionPanel.BorderThickness = 1;
            this.descriptionPanel.Controls.Add(this.panel26);
            this.descriptionPanel.Controls.Add(this.panel27);
            this.descriptionPanel.Controls.Add(this.panel3);
            this.descriptionPanel.Controls.Add(this.panel16);
            this.descriptionPanel.Controls.Add(this.panel9);
            this.descriptionPanel.Controls.Add(this.panel5);
            this.descriptionPanel.Controls.Add(this.panel4);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionPanel.FillColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor4 = System.Drawing.Color.Transparent;
            this.descriptionPanel.Location = new System.Drawing.Point(43, 0);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Quality = 1;
            this.descriptionPanel.ShadowDecoration.BorderRadius = 10;
            this.descriptionPanel.ShadowDecoration.Depth = 150;
            this.descriptionPanel.ShadowDecoration.Enabled = true;
            this.descriptionPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.descriptionPanel.Size = new System.Drawing.Size(317, 134);
            this.descriptionPanel.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.likesButton);
            this.panel2.Controls.Add(this.likesCountLabel);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(43, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 16);
            this.panel2.TabIndex = 2;
            // 
            // likesButton
            // 
            this.likesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.likesButton.Image = global::Biblio.Properties.Resources.whiteLike;
            this.likesButton.Location = new System.Drawing.Point(226, 0);
            this.likesButton.Name = "likesButton";
            this.likesButton.Size = new System.Drawing.Size(16, 16);
            this.likesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesButton.TabIndex = 2;
            this.likesButton.TabStop = false;
            this.likesButton.Click += new System.EventHandler(this.likesButton_Click);
            // 
            // likesCountLabel
            // 
            this.likesCountLabel.AutoSize = true;
            this.likesCountLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.likesCountLabel.ForeColor = System.Drawing.Color.White;
            this.likesCountLabel.Location = new System.Drawing.Point(242, 0);
            this.likesCountLabel.Name = "likesCountLabel";
            this.likesCountLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.likesCountLabel.Size = new System.Drawing.Size(75, 15);
            this.likesCountLabel.TabIndex = 1;
            this.likesCountLabel.Text = " Чило лайков";
            this.likesCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(157, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Время добавления коммента";
            // 
            // UserCommentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(360, 79);
            this.Name = "UserCommentsControl";
            this.Size = new System.Drawing.Size(360, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).EndInit();
            this.panel26.ResumeLayout(false);
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox profileButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox reportButton;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label commentLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel descriptionPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox likesButton;
        private System.Windows.Forms.Label likesCountLabel;
    }
}
