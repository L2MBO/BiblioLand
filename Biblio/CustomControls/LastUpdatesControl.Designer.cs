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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 8);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 8);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 94);
            this.panel3.TabIndex = 5;
            this.panel3.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(457, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 94);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderRadius = 20;
            this.mainPanel.Controls.Add(this.middlePanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.bookPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(8, 8);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(449, 94);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.middlePanel.Controls.Add(this.infoPanel);
            this.middlePanel.Controls.Add(this.panel6);
            this.middlePanel.Controls.Add(this.panel5);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(64, 0);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(2);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(284, 94);
            this.middlePanel.TabIndex = 7;
            this.middlePanel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.infoPanel.Controls.Add(this.authorLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(8, 24);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(276, 44);
            this.infoPanel.TabIndex = 8;
            this.infoPanel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoEllipsis = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(0, 0);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(276, 16);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Автор";
            this.authorLabel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(0, 22);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(276, 22);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название";
            this.nameLabel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(8, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 24);
            this.panel6.TabIndex = 7;
            this.panel6.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 94);
            this.panel5.TabIndex = 6;
            this.panel5.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.timePanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(348, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(101, 94);
            this.rightPanel.TabIndex = 6;
            this.rightPanel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 10;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(64, 94);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 2;
            this.bookPictureBox.TabStop = false;
            this.bookPictureBox.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoEllipsis = true;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.timeLabel.Location = new System.Drawing.Point(3, 3);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(45, 15);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Время";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeLabel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.timePanel.Location = new System.Drawing.Point(0, 37);
            this.timePanel.Margin = new System.Windows.Forms.Padding(2);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(101, 19);
            this.timePanel.TabIndex = 0;
            this.timePanel.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            // 
            // LastUpdatesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LastUpdatesControl";
            this.Size = new System.Drawing.Size(465, 110);
            this.Click += new System.EventHandler(this.LastUpdatesControl_Click);
            this.mainPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel rightPanel;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
    }
}
