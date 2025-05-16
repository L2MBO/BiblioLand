namespace Biblio.CustomControls
{
    partial class OtherControl
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
            this.catalogPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.catalogInfoLabel = new System.Windows.Forms.Label();
            this.catalogLabel = new System.Windows.Forms.Label();
            this.catalogRightArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.cardsPictureBox = new System.Windows.Forms.PictureBox();
            this.rankPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.rankInfoLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankRightArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.rankPictureBox = new System.Windows.Forms.PictureBox();
            this.catalogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRightArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsPictureBox)).BeginInit();
            this.rankPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankRightArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogPanel
            // 
            this.catalogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.catalogPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catalogPanel.BorderRadius = 10;
            this.catalogPanel.BorderThickness = 1;
            this.catalogPanel.Controls.Add(this.catalogInfoLabel);
            this.catalogPanel.Controls.Add(this.catalogLabel);
            this.catalogPanel.Controls.Add(this.catalogRightArrowPictureBox);
            this.catalogPanel.Controls.Add(this.cardsPictureBox);
            this.catalogPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.catalogPanel.Location = new System.Drawing.Point(10, 9);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(250, 50);
            this.catalogPanel.TabIndex = 2;
            // 
            // catalogInfoLabel
            // 
            this.catalogInfoLabel.AutoSize = true;
            this.catalogInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.catalogInfoLabel.Location = new System.Drawing.Point(50, 25);
            this.catalogInfoLabel.Name = "catalogInfoLabel";
            this.catalogInfoLabel.Size = new System.Drawing.Size(157, 13);
            this.catalogInfoLabel.TabIndex = 3;
            this.catalogInfoLabel.Text = "Все карты нашей библиотеки";
            // 
            // catalogLabel
            // 
            this.catalogLabel.AutoSize = true;
            this.catalogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogLabel.ForeColor = System.Drawing.Color.White;
            this.catalogLabel.Location = new System.Drawing.Point(50, 9);
            this.catalogLabel.Name = "catalogLabel";
            this.catalogLabel.Size = new System.Drawing.Size(93, 16);
            this.catalogLabel.TabIndex = 2;
            this.catalogLabel.Text = "Каталог карт";
            // 
            // catalogRightArrowPictureBox
            // 
            this.catalogRightArrowPictureBox.Image = global::Biblio.Properties.Resources.rightArrow;
            this.catalogRightArrowPictureBox.Location = new System.Drawing.Point(227, 20);
            this.catalogRightArrowPictureBox.Name = "catalogRightArrowPictureBox";
            this.catalogRightArrowPictureBox.Size = new System.Drawing.Size(8, 12);
            this.catalogRightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catalogRightArrowPictureBox.TabIndex = 1;
            this.catalogRightArrowPictureBox.TabStop = false;
            // 
            // cardsPictureBox
            // 
            this.cardsPictureBox.Image = global::Biblio.Properties.Resources.cards;
            this.cardsPictureBox.Location = new System.Drawing.Point(15, 18);
            this.cardsPictureBox.Name = "cardsPictureBox";
            this.cardsPictureBox.Size = new System.Drawing.Size(16, 16);
            this.cardsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardsPictureBox.TabIndex = 0;
            this.cardsPictureBox.TabStop = false;
            // 
            // rankPanel
            // 
            this.rankPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rankPanel.BorderRadius = 10;
            this.rankPanel.BorderThickness = 1;
            this.rankPanel.Controls.Add(this.rankInfoLabel);
            this.rankPanel.Controls.Add(this.rankLabel);
            this.rankPanel.Controls.Add(this.rankRightArrowPictureBox);
            this.rankPanel.Controls.Add(this.rankPictureBox);
            this.rankPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rankPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.rankPanel.Location = new System.Drawing.Point(10, 65);
            this.rankPanel.Name = "rankPanel";
            this.rankPanel.Size = new System.Drawing.Size(250, 50);
            this.rankPanel.TabIndex = 3;
            // 
            // rankInfoLabel
            // 
            this.rankInfoLabel.AutoSize = true;
            this.rankInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rankInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.rankInfoLabel.Location = new System.Drawing.Point(50, 25);
            this.rankInfoLabel.Name = "rankInfoLabel";
            this.rankInfoLabel.Size = new System.Drawing.Size(162, 13);
            this.rankInfoLabel.TabIndex = 5;
            this.rankInfoLabel.Text = "Посмотри, какое место у тебя";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rankLabel.ForeColor = System.Drawing.Color.White;
            this.rankLabel.Location = new System.Drawing.Point(50, 9);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(146, 16);
            this.rankLabel.TabIndex = 4;
            this.rankLabel.Text = "Топы пользователей";
            // 
            // rankRightArrowPictureBox
            // 
            this.rankRightArrowPictureBox.Image = global::Biblio.Properties.Resources.rightArrow;
            this.rankRightArrowPictureBox.Location = new System.Drawing.Point(227, 20);
            this.rankRightArrowPictureBox.Name = "rankRightArrowPictureBox";
            this.rankRightArrowPictureBox.Size = new System.Drawing.Size(8, 12);
            this.rankRightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rankRightArrowPictureBox.TabIndex = 2;
            this.rankRightArrowPictureBox.TabStop = false;
            // 
            // rankPictureBox
            // 
            this.rankPictureBox.Image = global::Biblio.Properties.Resources.rank;
            this.rankPictureBox.Location = new System.Drawing.Point(15, 18);
            this.rankPictureBox.Name = "rankPictureBox";
            this.rankPictureBox.Size = new System.Drawing.Size(16, 16);
            this.rankPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rankPictureBox.TabIndex = 1;
            this.rankPictureBox.TabStop = false;
            // 
            // OtherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.catalogPanel);
            this.Controls.Add(this.rankPanel);
            this.Name = "OtherControl";
            this.Size = new System.Drawing.Size(270, 125);
            this.catalogPanel.ResumeLayout(false);
            this.catalogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRightArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsPictureBox)).EndInit();
            this.rankPanel.ResumeLayout(false);
            this.rankPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankRightArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel catalogPanel;
        private System.Windows.Forms.Label catalogInfoLabel;
        private System.Windows.Forms.Label catalogLabel;
        private System.Windows.Forms.PictureBox catalogRightArrowPictureBox;
        private System.Windows.Forms.PictureBox cardsPictureBox;
        private Guna.UI2.WinForms.Guna2Panel rankPanel;
        private System.Windows.Forms.Label rankInfoLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.PictureBox rankRightArrowPictureBox;
        private System.Windows.Forms.PictureBox rankPictureBox;
    }
}
