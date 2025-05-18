namespace Biblio.CustomControls
{
    partial class BookSearchControl
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
            this.bookPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.BorderRadius = 16;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.bookPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(244, 69);
            this.mainPanel.TabIndex = 0;
            // 
            // bookPanel
            // 
            this.bookPanel.Controls.Add(this.nameLabel);
            this.bookPanel.Controls.Add(this.authorLabel);
            this.bookPanel.Controls.Add(this.bookPictureBox);
            this.bookPanel.Location = new System.Drawing.Point(9, 8);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(228, 53);
            this.bookPanel.TabIndex = 0;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(49, 3);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(31, 12);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Автор";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(49, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(174, 26);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 13;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(40, 53);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 2;
            this.bookPictureBox.TabStop = false;
            // 
            // BookSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookSearchControl";
            this.Size = new System.Drawing.Size(245, 70);
            this.mainPanel.ResumeLayout(false);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel bookPanel;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authorLabel;
    }
}
