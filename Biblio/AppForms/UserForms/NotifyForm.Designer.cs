namespace Biblio.AppForms
{
    partial class NotifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyForm));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.notifyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.feedbackTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteNotifyButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.writeNotifyButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.reportTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.navigationControl = new Biblio.CustomControls.NavigationControl();
            this.mainPanel.SuspendLayout();
            this.panel21.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 11;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.notifyPanel);
            this.mainPanel.Controls.Add(this.panel7);
            this.mainPanel.Controls.Add(this.panel21);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1452, 727);
            this.mainPanel.TabIndex = 4;
            // 
            // notifyPanel
            // 
            this.notifyPanel.AutoSize = true;
            this.notifyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notifyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifyPanel.Location = new System.Drawing.Point(200, 201);
            this.notifyPanel.Margin = new System.Windows.Forms.Padding(6);
            this.notifyPanel.Name = "notifyPanel";
            this.notifyPanel.Size = new System.Drawing.Size(1052, 0);
            this.notifyPanel.TabIndex = 77;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(200, 182);
            this.panel7.Margin = new System.Windows.Forms.Padding(6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1052, 19);
            this.panel7.TabIndex = 76;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Transparent;
            this.panel21.Controls.Add(this.feedbackTypeComboBox);
            this.panel21.Controls.Add(this.panel3);
            this.panel21.Controls.Add(this.sortComboBox);
            this.panel21.Controls.Add(this.panel2);
            this.panel21.Controls.Add(this.buttonsPanel);
            this.panel21.Controls.Add(this.reportTypeComboBox);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(200, 113);
            this.panel21.Margin = new System.Windows.Forms.Padding(6);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1052, 69);
            this.panel21.TabIndex = 61;
            // 
            // feedbackTypeComboBox
            // 
            this.feedbackTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.feedbackTypeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.feedbackTypeComboBox.BorderRadius = 17;
            this.feedbackTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackTypeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.feedbackTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.feedbackTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feedbackTypeComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.feedbackTypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.feedbackTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.feedbackTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.feedbackTypeComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackTypeComboBox.ItemHeight = 30;
            this.feedbackTypeComboBox.Items.AddRange(new object[] {
            "Тип обращения",
            "Понравилось",
            "Не понравилось",
            "Баг",
            "Идея"});
            this.feedbackTypeComboBox.Location = new System.Drawing.Point(334, 0);
            this.feedbackTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.feedbackTypeComboBox.Name = "feedbackTypeComboBox";
            this.feedbackTypeComboBox.Size = new System.Drawing.Size(304, 36);
            this.feedbackTypeComboBox.StartIndex = 0;
            this.feedbackTypeComboBox.TabIndex = 71;
            this.feedbackTypeComboBox.TextOffset = new System.Drawing.Point(7, 0);
            this.feedbackTypeComboBox.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(314, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 69);
            this.panel3.TabIndex = 70;
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortComboBox.BorderRadius = 17;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.sortComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.sortComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sortComboBox.ItemHeight = 30;
            this.sortComboBox.Items.AddRange(new object[] {
            "Новые",
            "Старые"});
            this.sortComboBox.Location = new System.Drawing.Point(722, 0);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(182, 36);
            this.sortComboBox.StartIndex = 0;
            this.sortComboBox.TabIndex = 69;
            this.sortComboBox.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(904, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 69);
            this.panel2.TabIndex = 68;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.buttonsPanel.Controls.Add(this.deleteNotifyButton);
            this.buttonsPanel.Controls.Add(this.panel5);
            this.buttonsPanel.Controls.Add(this.panel4);
            this.buttonsPanel.Controls.Add(this.writeNotifyButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.buttonsPanel.Location = new System.Drawing.Point(924, 0);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(128, 69);
            this.buttonsPanel.TabIndex = 65;
            // 
            // deleteNotifyButton
            // 
            this.deleteNotifyButton.Animated = true;
            this.deleteNotifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.deleteNotifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteNotifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteNotifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteNotifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteNotifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteNotifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteNotifyButton.Enabled = false;
            this.deleteNotifyButton.FillColor = System.Drawing.Color.DarkRed;
            this.deleteNotifyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteNotifyButton.ForeColor = System.Drawing.Color.White;
            this.deleteNotifyButton.Image = global::Biblio.Properties.Resources.trash;
            this.deleteNotifyButton.ImageSize = new System.Drawing.Size(18, 18);
            this.deleteNotifyButton.Location = new System.Drawing.Point(72, 8);
            this.deleteNotifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteNotifyButton.Name = "deleteNotifyButton";
            this.deleteNotifyButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deleteNotifyButton.Size = new System.Drawing.Size(56, 53);
            this.deleteNotifyButton.TabIndex = 81;
            this.deleteNotifyButton.Click += new System.EventHandler(this.deleteNotifyButton_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 8);
            this.panel5.TabIndex = 80;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 8);
            this.panel4.TabIndex = 79;
            // 
            // writeNotifyButton
            // 
            this.writeNotifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.writeNotifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeNotifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.writeNotifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.writeNotifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.writeNotifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.writeNotifyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.writeNotifyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.writeNotifyButton.ForeColor = System.Drawing.Color.White;
            this.writeNotifyButton.Image = global::Biblio.Properties.Resources.plas;
            this.writeNotifyButton.ImageSize = new System.Drawing.Size(17, 17);
            this.writeNotifyButton.Location = new System.Drawing.Point(4, 8);
            this.writeNotifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.writeNotifyButton.Name = "writeNotifyButton";
            this.writeNotifyButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.writeNotifyButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.writeNotifyButton.Size = new System.Drawing.Size(56, 54);
            this.writeNotifyButton.TabIndex = 76;
            this.writeNotifyButton.Visible = false;
            this.writeNotifyButton.Click += new System.EventHandler(this.writeNotifyButton_Click);
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportTypeComboBox.BorderRadius = 17;
            this.reportTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportTypeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.reportTypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.reportTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.reportTypeComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportTypeComboBox.ItemHeight = 30;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Тип жалобы",
            "На книгу",
            "На комментарий",
            "На пользователя"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.reportTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(314, 36);
            this.reportTypeComboBox.StartIndex = 0;
            this.reportTypeComboBox.TabIndex = 9;
            this.reportTypeComboBox.TextOffset = new System.Drawing.Point(7, 0);
            this.reportTypeComboBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 113);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblio.Properties.Resources.blueUnderLine;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "Уведомления";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1252, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 727);
            this.rightPanel.TabIndex = 22;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 727);
            this.leftPanel.TabIndex = 21;
            // 
            // navigationControl
            // 
            this.navigationControl.AutoSize = true;
            this.navigationControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.navigationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationControl.leftPanel = null;
            this.navigationControl.LeftPanelWidth = 0;
            this.navigationControl.Location = new System.Drawing.Point(0, 0);
            this.navigationControl.Margin = new System.Windows.Forms.Padding(12);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(1452, 100);
            this.navigationControl.TabIndex = 3;
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1452, 827);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserNotifyForm";
            this.Resize += new System.EventHandler(this.UserNotifyForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox reportTypeComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox sortComboBox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel notifyPanel;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2CircleButton writeNotifyButton;
        private Guna.UI2.WinForms.Guna2ComboBox feedbackTypeComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2CircleButton deleteNotifyButton;
    }
}