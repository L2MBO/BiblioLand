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
            this.writeCommentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.commentLabel = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profileButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.writeCommentPanel.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 63);
            this.panel1.TabIndex = 0;
            // 
            // writeCommentPanel
            // 
            this.writeCommentPanel.AutoSize = true;
            this.writeCommentPanel.BackColor = System.Drawing.Color.Transparent;
            this.writeCommentPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.writeCommentPanel.BorderRadius = 10;
            this.writeCommentPanel.BorderThickness = 1;
            this.writeCommentPanel.Controls.Add(this.panel26);
            this.writeCommentPanel.Controls.Add(this.panel27);
            this.writeCommentPanel.Controls.Add(this.panel2);
            this.writeCommentPanel.Controls.Add(this.panel16);
            this.writeCommentPanel.Controls.Add(this.panel9);
            this.writeCommentPanel.Controls.Add(this.panel5);
            this.writeCommentPanel.Controls.Add(this.panel3);
            this.writeCommentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeCommentPanel.FillColor = System.Drawing.Color.Transparent;
            this.writeCommentPanel.Location = new System.Drawing.Point(43, 0);
            this.writeCommentPanel.MaximumSize = new System.Drawing.Size(370, 0);
            this.writeCommentPanel.Name = "writeCommentPanel";
            this.writeCommentPanel.Size = new System.Drawing.Size(317, 63);
            this.writeCommentPanel.TabIndex = 53;
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
            this.panel26.TabIndex = 68;
            // 
            // commentLabel
            // 
            this.commentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(0, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(297, 16);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Комментарий";
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(10, 26);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(297, 10);
            this.panel27.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.reportButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 16);
            this.panel2.TabIndex = 4;
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
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportButton.Image = global::Biblio.Properties.Resources.report;
            this.reportButton.Location = new System.Drawing.Point(281, 0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(16, 16);
            this.reportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportButton.TabIndex = 0;
            this.reportButton.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(10, 53);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(297, 10);
            this.panel16.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(307, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 53);
            this.panel9.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 53);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 10);
            this.panel3.TabIndex = 0;
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
            // 
            // UserCommentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.writeCommentPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(360, 63);
            this.Name = "UserCommentsControl";
            this.Size = new System.Drawing.Size(360, 63);
            this.panel1.ResumeLayout(false);
            this.writeCommentPanel.ResumeLayout(false);
            this.writeCommentPanel.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel writeCommentPanel;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox reportButton;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox profileButton;
    }
}
