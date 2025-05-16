namespace Biblio.CustomControls
{
    partial class LastUpdatesControl
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderRadius = 20;
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.middlePanel);
            this.mainPanel.Controls.Add(this.bookPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(16, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 181);
            this.mainPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.timePanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(720, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(180, 181);
            this.rightPanel.TabIndex = 3;
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.timePanel.Location = new System.Drawing.Point(0, 71);
            this.timePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(180, 37);
            this.timePanel.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoEllipsis = true;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.timeLabel.Location = new System.Drawing.Point(6, 6);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(89, 29);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Время";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.middlePanel.Controls.Add(this.infoPanel);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.middlePanel.Location = new System.Drawing.Point(128, 0);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(592, 181);
            this.middlePanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.infoPanel.Controls.Add(this.authorLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Location = new System.Drawing.Point(20, 46);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(572, 85);
            this.infoPanel.TabIndex = 3;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoEllipsis = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(0, 0);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(572, 31);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Автор";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(-4, 42);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(576, 42);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(128, 181);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 1;
            this.bookPictureBox.TabStop = false;
            // 
            // LastUpdatesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LastUpdatesControl";
            this.Size = new System.Drawing.Size(930, 210);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox bookPictureBox;
    }
}
