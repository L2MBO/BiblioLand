namespace Biblio.CustomControls
{
    partial class MainControl
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.ratingPanel = new System.Windows.Forms.Panel();
            this.ratingTextPanel = new System.Windows.Forms.Panel();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.starPanel = new System.Windows.Forms.Panel();
            this.starPictureBox = new System.Windows.Forms.PictureBox();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.infoPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            this.ratingPanel.SuspendLayout();
            this.ratingTextPanel.SuspendLayout();
            this.starPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.authorLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 216);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.infoPanel.Size = new System.Drawing.Size(146, 65);
            this.infoPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(0, 29);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(146, 36);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoEllipsis = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(0, 5);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.authorLabel.Size = new System.Drawing.Size(146, 18);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Автор";
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.ratingPanel);
            this.imagePanel.Controls.Add(this.bookPictureBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(146, 216);
            this.imagePanel.TabIndex = 2;
            // 
            // ratingPanel
            // 
            this.ratingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ratingPanel.Controls.Add(this.ratingTextPanel);
            this.ratingPanel.Controls.Add(this.starPanel);
            this.ratingPanel.Location = new System.Drawing.Point(80, 190);
            this.ratingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(65, 23);
            this.ratingPanel.TabIndex = 2;
            // 
            // ratingTextPanel
            // 
            this.ratingTextPanel.Controls.Add(this.ratingLabel);
            this.ratingTextPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ratingTextPanel.Location = new System.Drawing.Point(27, 0);
            this.ratingTextPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ratingTextPanel.Name = "ratingTextPanel";
            this.ratingTextPanel.Size = new System.Drawing.Size(38, 23);
            this.ratingTextPanel.TabIndex = 3;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(-4, 0);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(42, 23);
            this.ratingLabel.TabIndex = 1;
            this.ratingLabel.Text = "0.0";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // starPanel
            // 
            this.starPanel.Controls.Add(this.starPictureBox);
            this.starPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.starPanel.Location = new System.Drawing.Point(0, 0);
            this.starPanel.Margin = new System.Windows.Forms.Padding(2);
            this.starPanel.Name = "starPanel";
            this.starPanel.Size = new System.Drawing.Size(22, 23);
            this.starPanel.TabIndex = 3;
            // 
            // starPictureBox
            // 
            this.starPictureBox.Image = global::Biblio.Properties.Resources.star;
            this.starPictureBox.Location = new System.Drawing.Point(4, 1);
            this.starPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.starPictureBox.Name = "starPictureBox";
            this.starPictureBox.Size = new System.Drawing.Size(18, 18);
            this.starPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starPictureBox.TabIndex = 1;
            this.starPictureBox.TabStop = false;
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 15;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPictureBox.FillColor = System.Drawing.Color.Black;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(146, 216);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 3;
            this.bookPictureBox.TabStop = false;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.infoPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(146, 281);
            this.infoPanel.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            this.ratingPanel.ResumeLayout(false);
            this.ratingTextPanel.ResumeLayout(false);
            this.starPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel ratingPanel;
        private System.Windows.Forms.Panel starPanel;
        private System.Windows.Forms.Panel ratingTextPanel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.PictureBox starPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
    }
}
