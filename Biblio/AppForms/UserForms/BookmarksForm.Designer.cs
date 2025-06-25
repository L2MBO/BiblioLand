namespace Biblio.AppForms
{
    partial class BookmarksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationControl = new Biblio.CustomControls.NavigationControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.buttonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.willReadingButton = new Guna.UI2.WinForms.Guna2Button();
            this.readingButton = new Guna.UI2.WinForms.Guna2Button();
            this.wasReadButton = new Guna.UI2.WinForms.Guna2Button();
            this.abandonedButton = new Guna.UI2.WinForms.Guna2Button();
            this.postponedButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookmarksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 11;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // navigationControl
            // 
            this.navigationControl.AutoSize = true;
            this.navigationControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.navigationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationControl.leftPanel = null;
            this.navigationControl.LeftPanelWidth = 0;
            this.navigationControl.Location = new System.Drawing.Point(0, 0);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(726, 52);
            this.navigationControl.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bookmarksPanel);
            this.mainPanel.Controls.Add(this.panel21);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 3;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(626, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 378);
            this.rightPanel.TabIndex = 22;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 378);
            this.leftPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 59);
            this.panel1.TabIndex = 23;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Transparent;
            this.panel21.Controls.Add(this.buttonPanel);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(100, 59);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(526, 33);
            this.panel21.TabIndex = 59;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.BorderRadius = 14;
            this.buttonPanel.Controls.Add(this.postponedButton);
            this.buttonPanel.Controls.Add(this.abandonedButton);
            this.buttonPanel.Controls.Add(this.wasReadButton);
            this.buttonPanel.Controls.Add(this.willReadingButton);
            this.buttonPanel.Controls.Add(this.readingButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(505, 33);
            this.buttonPanel.TabIndex = 0;
            // 
            // willReadingButton
            // 
            this.willReadingButton.Animated = true;
            this.willReadingButton.BackColor = System.Drawing.Color.Transparent;
            this.willReadingButton.BorderRadius = 13;
            this.willReadingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.willReadingButton.DefaultAutoSize = true;
            this.willReadingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.willReadingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.willReadingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.willReadingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.willReadingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.willReadingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.willReadingButton.ForeColor = System.Drawing.Color.White;
            this.willReadingButton.Location = new System.Drawing.Point(85, 3);
            this.willReadingButton.Name = "willReadingButton";
            this.willReadingButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.willReadingButton.Size = new System.Drawing.Size(106, 27);
            this.willReadingButton.TabIndex = 39;
            this.willReadingButton.Text = "Буду читать 0";
            this.willReadingButton.Click += new System.EventHandler(this.willReadingButton_Click);
            // 
            // readingButton
            // 
            this.readingButton.Animated = true;
            this.readingButton.BackColor = System.Drawing.Color.Transparent;
            this.readingButton.BorderRadius = 13;
            this.readingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readingButton.DefaultAutoSize = true;
            this.readingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.readingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.readingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.readingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.readingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.readingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readingButton.ForeColor = System.Drawing.Color.White;
            this.readingButton.Location = new System.Drawing.Point(3, 3);
            this.readingButton.Name = "readingButton";
            this.readingButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.readingButton.Size = new System.Drawing.Size(76, 27);
            this.readingButton.TabIndex = 38;
            this.readingButton.Text = "Читаю 0";
            this.readingButton.Click += new System.EventHandler(this.readingButton_Click);
            // 
            // wasReadButton
            // 
            this.wasReadButton.Animated = true;
            this.wasReadButton.BackColor = System.Drawing.Color.Transparent;
            this.wasReadButton.BorderRadius = 13;
            this.wasReadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wasReadButton.DefaultAutoSize = true;
            this.wasReadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wasReadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wasReadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wasReadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wasReadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.wasReadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wasReadButton.ForeColor = System.Drawing.Color.White;
            this.wasReadButton.Location = new System.Drawing.Point(197, 3);
            this.wasReadButton.Name = "wasReadButton";
            this.wasReadButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.wasReadButton.Size = new System.Drawing.Size(103, 27);
            this.wasReadButton.TabIndex = 40;
            this.wasReadButton.Text = "Прочитано 0";
            this.wasReadButton.Click += new System.EventHandler(this.wasReadButton_Click);
            // 
            // abandonedButton
            // 
            this.abandonedButton.Animated = true;
            this.abandonedButton.BackColor = System.Drawing.Color.Transparent;
            this.abandonedButton.BorderRadius = 13;
            this.abandonedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abandonedButton.DefaultAutoSize = true;
            this.abandonedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.abandonedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.abandonedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.abandonedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.abandonedButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.abandonedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abandonedButton.ForeColor = System.Drawing.Color.White;
            this.abandonedButton.Location = new System.Drawing.Point(306, 3);
            this.abandonedButton.Name = "abandonedButton";
            this.abandonedButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.abandonedButton.Size = new System.Drawing.Size(92, 27);
            this.abandonedButton.TabIndex = 41;
            this.abandonedButton.Text = "Брошено 0";
            this.abandonedButton.Click += new System.EventHandler(this.abandonedButton_Click);
            // 
            // postponedButton
            // 
            this.postponedButton.Animated = true;
            this.postponedButton.BackColor = System.Drawing.Color.Transparent;
            this.postponedButton.BorderRadius = 13;
            this.postponedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postponedButton.DefaultAutoSize = true;
            this.postponedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.postponedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.postponedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.postponedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.postponedButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.postponedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.postponedButton.ForeColor = System.Drawing.Color.White;
            this.postponedButton.Location = new System.Drawing.Point(404, 3);
            this.postponedButton.Name = "postponedButton";
            this.postponedButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.postponedButton.Size = new System.Drawing.Size(98, 27);
            this.postponedButton.TabIndex = 42;
            this.postponedButton.Text = "Отложено 0";
            this.postponedButton.Click += new System.EventHandler(this.postponedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Закладки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblio.Properties.Resources.blueUnderLine;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bookmarksPanel
            // 
            this.bookmarksPanel.AutoSize = true;
            this.bookmarksPanel.BackColor = System.Drawing.Color.Transparent;
            this.bookmarksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookmarksPanel.Location = new System.Drawing.Point(100, 92);
            this.bookmarksPanel.Name = "bookmarksPanel";
            this.bookmarksPanel.Size = new System.Drawing.Size(526, 0);
            this.bookmarksPanel.TabIndex = 60;
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookmarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookmarksForm";
            this.Resize += new System.EventHandler(this.BookmarksForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel21;
        private Guna.UI2.WinForms.Guna2Panel buttonPanel;
        private Guna.UI2.WinForms.Guna2Button postponedButton;
        private Guna.UI2.WinForms.Guna2Button abandonedButton;
        private Guna.UI2.WinForms.Guna2Button wasReadButton;
        private Guna.UI2.WinForms.Guna2Button willReadingButton;
        private Guna.UI2.WinForms.Guna2Button readingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel bookmarksPanel;
    }
}