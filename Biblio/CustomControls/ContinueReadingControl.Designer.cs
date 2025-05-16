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
            this.readingBookProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.readingBookProgressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
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
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.infoPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightPanel.Location = new System.Drawing.Point(64, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(211, 94);
            this.rightPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.infoPanel.Controls.Add(this.readingBookProgressBar);
            this.infoPanel.Controls.Add(this.readingBookProgressLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 9);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(199, 75);
            this.infoPanel.TabIndex = 3;
            // 
            // readingBookProgressBar
            // 
            this.readingBookProgressBar.BorderRadius = 2;
            this.readingBookProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.readingBookProgressBar.Location = new System.Drawing.Point(3, 68);
            this.readingBookProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.readingBookProgressBar.Name = "readingBookProgressBar";
            this.readingBookProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.readingBookProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.readingBookProgressBar.Size = new System.Drawing.Size(186, 5);
            this.readingBookProgressBar.TabIndex = 4;
            this.readingBookProgressBar.Text = "guna2ProgressBar1";
            this.readingBookProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // readingBookProgressLabel
            // 
            this.readingBookProgressLabel.AutoEllipsis = true;
            this.readingBookProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.readingBookProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readingBookProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.readingBookProgressLabel.Location = new System.Drawing.Point(0, 48);
            this.readingBookProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readingBookProgressLabel.Name = "readingBookProgressLabel";
            this.readingBookProgressLabel.Size = new System.Drawing.Size(199, 37);
            this.readingBookProgressLabel.TabIndex = 5;
            this.readingBookProgressLabel.Text = "Страница ? из ?";
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
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(64, 94);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 1;
            this.bookPictureBox.TabStop = false;
            // 
            // ContinueReadingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContinueReadingControl";
            this.Size = new System.Drawing.Size(290, 109);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel infoPanel;
        private Guna.UI2.WinForms.Guna2ProgressBar readingBookProgressBar;
        private System.Windows.Forms.Label readingBookProgressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox bookPictureBox;
    }
}
