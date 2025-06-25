namespace Biblio.AppForms
{
    partial class ImageLoadForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.loadImagePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadImageButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.loadImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 35;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.loadImagePanel);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(255, 140);
            this.guna2Panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AllowDrop = true;
            this.closeButton.Animated = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = global::Biblio.Properties.Resources.whiteXmark;
            this.closeButton.ImageSize = new System.Drawing.Size(10, 10);
            this.closeButton.Location = new System.Drawing.Point(228, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 34;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loadImagePanel
            // 
            this.loadImagePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadImagePanel.BorderRadius = 15;
            this.loadImagePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.loadImagePanel.BorderThickness = 2;
            this.loadImagePanel.Controls.Add(this.label1);
            this.loadImagePanel.Controls.Add(this.label3);
            this.loadImagePanel.Controls.Add(this.loadImageButton);
            this.loadImagePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadImagePanel.Location = new System.Drawing.Point(24, 22);
            this.loadImagePanel.Name = "loadImagePanel";
            this.loadImagePanel.Size = new System.Drawing.Size(207, 97);
            this.loadImagePanel.TabIndex = 1;
            this.loadImagePanel.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вы можете загрузить файл до 5 MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нажмите чтобы выбрать";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Animated = true;
            this.loadImageButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadImageButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.loadImageButton.BorderThickness = 1;
            this.loadImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadImageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loadImageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadImageButton.ForeColor = System.Drawing.Color.White;
            this.loadImageButton.Image = global::Biblio.Properties.Resources.download;
            this.loadImageButton.ImageOffset = new System.Drawing.Point(0, -2);
            this.loadImageButton.Location = new System.Drawing.Point(88, 7);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.loadImageButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loadImageButton.Size = new System.Drawing.Size(31, 31);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // ImageLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(256, 141);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageLoadForm";
            this.Text = "ImageLoadForm";
            this.guna2Panel1.ResumeLayout(false);
            this.loadImagePanel.ResumeLayout(false);
            this.loadImagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel loadImagePanel;
        private Guna.UI2.WinForms.Guna2CircleButton loadImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
    }
}