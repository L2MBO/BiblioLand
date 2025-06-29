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
            this.panel21 = new System.Windows.Forms.Panel();
            this.writeNotifyButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.navigationControl = new Biblio.CustomControls.NavigationControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.notifyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel21.SuspendLayout();
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
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 4;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Transparent;
            this.panel21.Controls.Add(this.sortComboBox);
            this.panel21.Controls.Add(this.panel2);
            this.panel21.Controls.Add(this.writeNotifyButton);
            this.panel21.Controls.Add(this.guna2CircleButton3);
            this.panel21.Controls.Add(this.buttonsPanel);
            this.panel21.Controls.Add(this.typeComboBox);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(100, 59);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(526, 36);
            this.panel21.TabIndex = 61;
            // 
            // writeNotifyButton
            // 
            this.writeNotifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
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
            this.writeNotifyButton.Location = new System.Drawing.Point(458, 4);
            this.writeNotifyButton.Name = "writeNotifyButton";
            this.writeNotifyButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.writeNotifyButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.writeNotifyButton.Size = new System.Drawing.Size(28, 28);
            this.writeNotifyButton.TabIndex = 66;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2CircleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.Enabled = false;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.DarkRed;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = global::Biblio.Properties.Resources.trash;
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2CircleButton3.Location = new System.Drawing.Point(490, 4);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(28, 28);
            this.guna2CircleButton3.TabIndex = 65;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonsPanel.BorderRadius = 17;
            this.buttonsPanel.BorderThickness = 1;
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.buttonsPanel.Location = new System.Drawing.Point(450, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(76, 36);
            this.buttonsPanel.TabIndex = 65;
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.typeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeComboBox.BorderRadius = 17;
            this.typeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.typeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeComboBox.ForeColor = System.Drawing.Color.White;
            this.typeComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.ItemHeight = 30;
            this.typeComboBox.Items.AddRange(new object[] {
            "Тип обращения",
            "Жалоба на книгу",
            "Жалоба на комментарий",
            "Жалоба на профиль",
            "Обратная связь"});
            this.typeComboBox.Location = new System.Drawing.Point(0, 0);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(202, 36);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 9;
            this.typeComboBox.TextOffset = new System.Drawing.Point(7, 0);
            this.typeComboBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 59);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblio.Properties.Resources.blueUnderLine;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Уведомления";
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
            this.navigationControl.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 36);
            this.panel2.TabIndex = 68;
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
            this.sortComboBox.Location = new System.Drawing.Point(347, 0);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(93, 36);
            this.sortComboBox.StartIndex = 0;
            this.sortComboBox.TabIndex = 69;
            this.sortComboBox.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // notifyPanel
            // 
            this.notifyPanel.AutoSize = true;
            this.notifyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notifyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifyPanel.Location = new System.Drawing.Point(100, 105);
            this.notifyPanel.Name = "notifyPanel";
            this.notifyPanel.Size = new System.Drawing.Size(526, 0);
            this.notifyPanel.TabIndex = 77;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(100, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(526, 10);
            this.panel7.TabIndex = 76;
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserNotifyForm";
            this.Resize += new System.EventHandler(this.UserNotifyForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel21.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private Guna.UI2.WinForms.Guna2CircleButton writeNotifyButton;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2Panel buttonsPanel;
        private Guna.UI2.WinForms.Guna2ComboBox sortComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel notifyPanel;
        private System.Windows.Forms.Panel panel7;
    }
}