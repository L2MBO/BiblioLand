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
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.sortInterestingCommentButton = new Guna.UI2.WinForms.Guna2Button();
            this.sortNewCommentButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookmarksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
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
            this.panel21.Controls.Add(this.guna2Panel4);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(100, 59);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(526, 33);
            this.panel21.TabIndex = 59;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 14;
            this.guna2Panel4.Controls.Add(this.guna2Button3);
            this.guna2Panel4.Controls.Add(this.guna2Button2);
            this.guna2Panel4.Controls.Add(this.guna2Button1);
            this.guna2Panel4.Controls.Add(this.sortInterestingCommentButton);
            this.guna2Panel4.Controls.Add(this.sortNewCommentButton);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(504, 33);
            this.guna2Panel4.TabIndex = 0;
            // 
            // sortInterestingCommentButton
            // 
            this.sortInterestingCommentButton.Animated = true;
            this.sortInterestingCommentButton.BackColor = System.Drawing.Color.Transparent;
            this.sortInterestingCommentButton.BorderRadius = 13;
            this.sortInterestingCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortInterestingCommentButton.DefaultAutoSize = true;
            this.sortInterestingCommentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sortInterestingCommentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sortInterestingCommentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sortInterestingCommentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sortInterestingCommentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.sortInterestingCommentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortInterestingCommentButton.ForeColor = System.Drawing.Color.White;
            this.sortInterestingCommentButton.Location = new System.Drawing.Point(85, 3);
            this.sortInterestingCommentButton.Name = "sortInterestingCommentButton";
            this.sortInterestingCommentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.sortInterestingCommentButton.Size = new System.Drawing.Size(106, 27);
            this.sortInterestingCommentButton.TabIndex = 39;
            this.sortInterestingCommentButton.Text = "Буду читать 0";
            // 
            // sortNewCommentButton
            // 
            this.sortNewCommentButton.Animated = true;
            this.sortNewCommentButton.BackColor = System.Drawing.Color.Transparent;
            this.sortNewCommentButton.BorderRadius = 13;
            this.sortNewCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortNewCommentButton.DefaultAutoSize = true;
            this.sortNewCommentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sortNewCommentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sortNewCommentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sortNewCommentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sortNewCommentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.sortNewCommentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortNewCommentButton.ForeColor = System.Drawing.Color.White;
            this.sortNewCommentButton.Location = new System.Drawing.Point(3, 3);
            this.sortNewCommentButton.Name = "sortNewCommentButton";
            this.sortNewCommentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.sortNewCommentButton.Size = new System.Drawing.Size(76, 27);
            this.sortNewCommentButton.TabIndex = 38;
            this.sortNewCommentButton.Text = "Читаю 0";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(197, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.guna2Button1.Size = new System.Drawing.Size(103, 27);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "Прочитано 0";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DefaultAutoSize = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(306, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.guna2Button2.Size = new System.Drawing.Size(92, 27);
            this.guna2Button2.TabIndex = 41;
            this.guna2Button2.Text = "Брошено 0";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 13;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DefaultAutoSize = true;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(404, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.guna2Button3.Size = new System.Drawing.Size(98, 27);
            this.guna2Button3.TabIndex = 42;
            this.guna2Button3.Text = "Отложено 0";
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
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button sortInterestingCommentButton;
        private Guna.UI2.WinForms.Guna2Button sortNewCommentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel bookmarksPanel;
    }
}