﻿namespace Biblio.CustomControls
{
    partial class NavigationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
            this.topPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.delimiter3 = new System.Windows.Forms.Panel();
            this.bookmarksButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.delimiter4 = new System.Windows.Forms.Panel();
            this.notificationsButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.delimiter5 = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.delimiter2 = new System.Windows.Forms.Panel();
            this.catalogButton = new Guna.UI2.WinForms.Guna2Button();
            this.delimiter1 = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.PictureBox();
            this.bottomNavigationPanel = new System.Windows.Forms.Panel();
            this.topNavigationPanel = new System.Windows.Forms.Panel();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.restoreButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.notifyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainButton)).BeginInit();
            this.topRightPanel.SuspendLayout();
            this.topRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.notifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.topPanel.Controls.Add(this.navigationPanel);
            this.topPanel.Controls.Add(this.topLeftPanel);
            this.topPanel.Controls.Add(this.topRightPanel);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(726, 52);
            this.topPanel.TabIndex = 22;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.searchButton);
            this.navigationPanel.Controls.Add(this.panel17);
            this.navigationPanel.Controls.Add(this.panel16);
            this.navigationPanel.Controls.Add(this.bottomNavigationPanel);
            this.navigationPanel.Controls.Add(this.topNavigationPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(100, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(526, 44);
            this.navigationPanel.TabIndex = 25;
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // searchButton
            // 
            this.searchButton.Animated = true;
            this.searchButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.searchButton.BorderRadius = 17;
            this.searchButton.BorderThickness = 1;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::Biblio.Properties.Resources.magnifyingGlass;
            this.searchButton.Location = new System.Drawing.Point(129, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.searchButton.Size = new System.Drawing.Size(280, 34);
            this.searchButton.TabIndex = 79;
            this.searchButton.Text = "Что ищем, читатель?";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel17
            // 
            this.panel17.AutoSize = true;
            this.panel17.Controls.Add(this.notifyPanel);
            this.panel17.Controls.Add(this.delimiter3);
            this.panel17.Controls.Add(this.bookmarksButton);
            this.panel17.Controls.Add(this.delimiter4);
            this.panel17.Controls.Add(this.notificationsButton);
            this.panel17.Controls.Add(this.delimiter5);
            this.panel17.Controls.Add(this.avatarPictureBox);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(409, 7);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(117, 34);
            this.panel17.TabIndex = 56;
            // 
            // delimiter3
            // 
            this.delimiter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter3.Location = new System.Drawing.Point(0, 0);
            this.delimiter3.Name = "delimiter3";
            this.delimiter3.Size = new System.Drawing.Size(5, 34);
            this.delimiter3.TabIndex = 68;
            // 
            // bookmarksButton
            // 
            this.bookmarksButton.Animated = true;
            this.bookmarksButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bookmarksButton.BorderThickness = 1;
            this.bookmarksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookmarksButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookmarksButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookmarksButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookmarksButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookmarksButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookmarksButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.bookmarksButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookmarksButton.ForeColor = System.Drawing.Color.White;
            this.bookmarksButton.Image = global::Biblio.Properties.Resources.bookmark;
            this.bookmarksButton.ImageSize = new System.Drawing.Size(16, 20);
            this.bookmarksButton.Location = new System.Drawing.Point(5, 0);
            this.bookmarksButton.Name = "bookmarksButton";
            this.bookmarksButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.bookmarksButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.bookmarksButton.Size = new System.Drawing.Size(34, 34);
            this.bookmarksButton.TabIndex = 58;
            // 
            // delimiter4
            // 
            this.delimiter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter4.Location = new System.Drawing.Point(39, 0);
            this.delimiter4.Name = "delimiter4";
            this.delimiter4.Size = new System.Drawing.Size(5, 34);
            this.delimiter4.TabIndex = 57;
            // 
            // notificationsButton
            // 
            this.notificationsButton.Animated = true;
            this.notificationsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notificationsButton.BorderThickness = 1;
            this.notificationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notificationsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notificationsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notificationsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notificationsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.notificationsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.notificationsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notificationsButton.ForeColor = System.Drawing.Color.White;
            this.notificationsButton.Image = global::Biblio.Properties.Resources.bell;
            this.notificationsButton.ImageSize = new System.Drawing.Size(18, 20);
            this.notificationsButton.Location = new System.Drawing.Point(44, 0);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.notificationsButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.notificationsButton.Size = new System.Drawing.Size(34, 34);
            this.notificationsButton.TabIndex = 56;
            // 
            // delimiter5
            // 
            this.delimiter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter5.Location = new System.Drawing.Point(78, 0);
            this.delimiter5.Name = "delimiter5";
            this.delimiter5.Size = new System.Drawing.Size(5, 34);
            this.delimiter5.TabIndex = 1;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(83, 0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatarPictureBox.Size = new System.Drawing.Size(34, 34);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.avatarPictureBox_Click);
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.Controls.Add(this.delimiter2);
            this.panel16.Controls.Add(this.catalogButton);
            this.panel16.Controls.Add(this.delimiter1);
            this.panel16.Controls.Add(this.mainButton);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 7);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(129, 34);
            this.panel16.TabIndex = 55;
            // 
            // delimiter2
            // 
            this.delimiter2.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiter2.Location = new System.Drawing.Point(124, 0);
            this.delimiter2.Name = "delimiter2";
            this.delimiter2.Size = new System.Drawing.Size(5, 34);
            this.delimiter2.TabIndex = 70;
            // 
            // catalogButton
            // 
            this.catalogButton.Animated = true;
            this.catalogButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.catalogButton.BorderRadius = 17;
            this.catalogButton.BorderThickness = 1;
            this.catalogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.catalogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.catalogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.catalogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.catalogButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.catalogButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.catalogButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.catalogButton.ForeColor = System.Drawing.Color.White;
            this.catalogButton.Location = new System.Drawing.Point(39, 0);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.catalogButton.Size = new System.Drawing.Size(85, 34);
            this.catalogButton.TabIndex = 69;
            this.catalogButton.Text = "Каталог";
            // 
            // delimiter1
            // 
            this.delimiter1.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiter1.Location = new System.Drawing.Point(34, 0);
            this.delimiter1.Name = "delimiter1";
            this.delimiter1.Size = new System.Drawing.Size(5, 34);
            this.delimiter1.TabIndex = 68;
            // 
            // mainButton
            // 
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainButton.Image = ((System.Drawing.Image)(resources.GetObject("mainButton.Image")));
            this.mainButton.Location = new System.Drawing.Point(0, 0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(34, 34);
            this.mainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButton.TabIndex = 57;
            this.mainButton.TabStop = false;
            // 
            // bottomNavigationPanel
            // 
            this.bottomNavigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomNavigationPanel.Location = new System.Drawing.Point(0, 41);
            this.bottomNavigationPanel.Name = "bottomNavigationPanel";
            this.bottomNavigationPanel.Size = new System.Drawing.Size(526, 3);
            this.bottomNavigationPanel.TabIndex = 0;
            this.bottomNavigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topNavigationPanel
            // 
            this.topNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.topNavigationPanel.Name = "topNavigationPanel";
            this.topNavigationPanel.Size = new System.Drawing.Size(526, 7);
            this.topNavigationPanel.TabIndex = 54;
            this.topNavigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(100, 44);
            this.topLeftPanel.TabIndex = 24;
            this.topLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topRightPanel
            // 
            this.topRightPanel.Controls.Add(this.topRight);
            this.topRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.topRightPanel.Location = new System.Drawing.Point(626, 0);
            this.topRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(100, 44);
            this.topRightPanel.TabIndex = 21;
            this.topRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topRight
            // 
            this.topRight.Controls.Add(this.closeButton);
            this.topRight.Controls.Add(this.maximizeButton);
            this.topRight.Controls.Add(this.restoreButton);
            this.topRight.Controls.Add(this.minimizeButton);
            this.topRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.topRight.Location = new System.Drawing.Point(0, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(100, 44);
            this.topRight.TabIndex = 54;
            this.topRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::Biblio.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(69, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 15);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 7;
            this.closeButton.TabStop = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Image = global::Biblio.Properties.Resources.maximaze;
            this.maximizeButton.Location = new System.Drawing.Point(43, 15);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(15, 15);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizeButton.TabIndex = 6;
            this.maximizeButton.TabStop = false;
            // 
            // restoreButton
            // 
            this.restoreButton.Image = global::Biblio.Properties.Resources.restore;
            this.restoreButton.Location = new System.Drawing.Point(43, 15);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(15, 15);
            this.restoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreButton.TabIndex = 5;
            this.restoreButton.TabStop = false;
            this.restoreButton.Visible = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::Biblio.Properties.Resources.collapse;
            this.minimizeButton.Location = new System.Drawing.Point(17, 15);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::Biblio.Properties.Resources.squareGreyLine;
            this.pictureBox2.Location = new System.Drawing.Point(0, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(726, 8);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // notifyPanel
            // 
            this.notifyPanel.BorderRadius = 5;
            this.notifyPanel.Controls.Add(this.notifyLabel);
            this.notifyPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.notifyPanel.Location = new System.Drawing.Point(67, 0);
            this.notifyPanel.Name = "notifyPanel";
            this.notifyPanel.Size = new System.Drawing.Size(12, 15);
            this.notifyPanel.TabIndex = 73;
            this.notifyPanel.Visible = false;
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.notifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyLabel.ForeColor = System.Drawing.Color.White;
            this.notifyLabel.Location = new System.Drawing.Point(-1, 1);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(14, 13);
            this.notifyLabel.TabIndex = 71;
            this.notifyLabel.Text = "1";
            // 
            // NavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.topPanel);
            this.Name = "NavigationControl";
            this.Size = new System.Drawing.Size(726, 52);
            this.topPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainButton)).EndInit();
            this.topRightPanel.ResumeLayout(false);
            this.topRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.notifyPanel.ResumeLayout(false);
            this.notifyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2CircleButton bookmarksButton;
        private System.Windows.Forms.Panel delimiter4;
        private Guna.UI2.WinForms.Guna2CircleButton notificationsButton;
        private System.Windows.Forms.Panel delimiter5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel delimiter3;
        private System.Windows.Forms.Panel delimiter2;
        private Guna.UI2.WinForms.Guna2Button catalogButton;
        private System.Windows.Forms.Panel delimiter1;
        private System.Windows.Forms.PictureBox mainButton;
        private System.Windows.Forms.Panel bottomNavigationPanel;
        private System.Windows.Forms.Panel topNavigationPanel;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox restoreButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Panel notifyPanel;
        private System.Windows.Forms.Label notifyLabel;
    }
}
