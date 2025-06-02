namespace Biblio.CustomControls
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.booksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.oftenSearchedLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.searchPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.clearTextButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.searchTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.glasPanel = new System.Windows.Forms.Panel();
            this.glasPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.noResultPanel = new System.Windows.Forms.Panel();
            this.noResultPictureBox = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearTextButton)).BeginInit();
            this.glasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glasPictureBox)).BeginInit();
            this.noResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.noResultPanel);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(541, 282);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 264);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.booksPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 162);
            this.panel3.TabIndex = 6;
            // 
            // booksPanel
            // 
            this.booksPanel.Location = new System.Drawing.Point(4, 0);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(514, 158);
            this.booksPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oftenSearchedLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 45);
            this.panel2.TabIndex = 5;
            // 
            // oftenSearchedLabel
            // 
            this.oftenSearchedLabel.AutoSize = true;
            this.oftenSearchedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oftenSearchedLabel.ForeColor = System.Drawing.Color.White;
            this.oftenSearchedLabel.Location = new System.Drawing.Point(19, 15);
            this.oftenSearchedLabel.Name = "oftenSearchedLabel";
            this.oftenSearchedLabel.Size = new System.Drawing.Size(81, 16);
            this.oftenSearchedLabel.TabIndex = 0;
            this.oftenSearchedLabel.Text = "Часто ищут";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeButton);
            this.panel4.Controls.Add(this.searchPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 57);
            this.panel4.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageRotate = 0F;
            this.closeButton.Location = new System.Drawing.Point(471, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(45, 45);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 70;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.searchPanel.BorderRadius = 22;
            this.searchPanel.Controls.Add(this.clearTextButton);
            this.searchPanel.Controls.Add(this.searchTextField);
            this.searchPanel.Controls.Add(this.glasPanel);
            this.searchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.searchPanel.Location = new System.Drawing.Point(9, 6);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(456, 45);
            this.searchPanel.TabIndex = 69;
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.clearTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearTextButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.clearTextButton.Image = ((System.Drawing.Image)(resources.GetObject("clearTextButton.Image")));
            this.clearTextButton.ImageRotate = 0F;
            this.clearTextButton.Location = new System.Drawing.Point(410, 8);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.clearTextButton.Size = new System.Drawing.Size(27, 28);
            this.clearTextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearTextButton.TabIndex = 71;
            this.clearTextButton.TabStop = false;
            this.clearTextButton.Visible = false;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // searchTextField
            // 
            this.searchTextField.BorderColor = System.Drawing.Color.Transparent;
            this.searchTextField.BorderThickness = 0;
            this.searchTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextField.DefaultText = "";
            this.searchTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.searchTextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextField.ForeColor = System.Drawing.Color.White;
            this.searchTextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextField.Location = new System.Drawing.Point(41, 12);
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.PlaceholderText = "Что ищем, читатель?";
            this.searchTextField.SelectedText = "";
            this.searchTextField.Size = new System.Drawing.Size(376, 16);
            this.searchTextField.TabIndex = 57;
            this.searchTextField.TextChanged += new System.EventHandler(this.searchTextField_TextChanged);
            // 
            // glasPanel
            // 
            this.glasPanel.BackColor = System.Drawing.Color.Transparent;
            this.glasPanel.Controls.Add(this.glasPictureBox);
            this.glasPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.glasPanel.Location = new System.Drawing.Point(0, 0);
            this.glasPanel.Name = "glasPanel";
            this.glasPanel.Size = new System.Drawing.Size(40, 45);
            this.glasPanel.TabIndex = 55;
            // 
            // glasPictureBox
            // 
            this.glasPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.glasPictureBox.FillColor = System.Drawing.Color.Transparent;
            this.glasPictureBox.Image = global::Biblio.Properties.Resources.magnifyingGlass;
            this.glasPictureBox.ImageRotate = 0F;
            this.glasPictureBox.Location = new System.Drawing.Point(20, 11);
            this.glasPictureBox.Name = "glasPictureBox";
            this.glasPictureBox.Size = new System.Drawing.Size(25, 25);
            this.glasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.glasPictureBox.TabIndex = 55;
            this.glasPictureBox.TabStop = false;
            // 
            // noResultPanel
            // 
            this.noResultPanel.Controls.Add(this.noResultPictureBox);
            this.noResultPanel.Location = new System.Drawing.Point(13, 112);
            this.noResultPanel.Name = "noResultPanel";
            this.noResultPanel.Size = new System.Drawing.Size(514, 158);
            this.noResultPanel.TabIndex = 3;
            this.noResultPanel.Visible = false;
            // 
            // noResultPictureBox
            // 
            this.noResultPictureBox.Image = global::Biblio.Properties.Resources.noResults;
            this.noResultPictureBox.Location = new System.Drawing.Point(221, 28);
            this.noResultPictureBox.Name = "noResultPictureBox";
            this.noResultPictureBox.Size = new System.Drawing.Size(68, 98);
            this.noResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noResultPictureBox.TabIndex = 1;
            this.noResultPictureBox.TabStop = false;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(542, 283);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clearTextButton)).EndInit();
            this.glasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glasPictureBox)).EndInit();
            this.noResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noResultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel booksPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label oftenSearchedLabel;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox closeButton;
        private Guna.UI2.WinForms.Guna2Panel searchPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextField;
        private System.Windows.Forms.Panel glasPanel;
        private Guna.UI2.WinForms.Guna2PictureBox glasPictureBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox clearTextButton;
        private System.Windows.Forms.Panel noResultPanel;
        private System.Windows.Forms.PictureBox noResultPictureBox;
    }
}
