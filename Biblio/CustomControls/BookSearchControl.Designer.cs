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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(244, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.titleLabel);
            this.guna2Panel2.Controls.Add(this.authorLabel);
            this.guna2Panel2.Controls.Add(this.bookPictureBox);
            this.guna2Panel2.Location = new System.Drawing.Point(9, 8);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(228, 53);
            this.guna2Panel2.TabIndex = 0;
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 13;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(40, 53);
            this.bookPictureBox.TabIndex = 2;
            this.bookPictureBox.TabStop = false;
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
            // titleLabel
            // 
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(49, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 26);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "название";
            // 
            // BookSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "BookSearchControl";
            this.Size = new System.Drawing.Size(245, 70);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
    }
}
