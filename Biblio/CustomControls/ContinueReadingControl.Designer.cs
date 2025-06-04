namespace Biblio.CustomControls
{
    partial class ContinueReadingControl
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderRadius = 20;
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.bookPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(8, 8);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(275, 94);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.infoPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(64, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(211, 94);
            this.rightPanel.TabIndex = 5;
            this.rightPanel.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.infoPanel.Controls.Add(this.authorLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 9);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(199, 75);
            this.infoPanel.TabIndex = 3;
            this.infoPanel.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoEllipsis = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(0, 48);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(199, 37);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Автор";
            this.authorLabel.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(199, 36);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название";
            this.nameLabel.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 12;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(64, 94);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 4;
            this.bookPictureBox.TabStop = false;
            this.bookPictureBox.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            // 
            // ContinueReadingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContinueReadingControl";
            this.Size = new System.Drawing.Size(290, 109);
            this.Click += new System.EventHandler(this.ContinueReadingControl_Click);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
