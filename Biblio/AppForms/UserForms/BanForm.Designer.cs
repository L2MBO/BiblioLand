namespace Biblio.AppForms.UserForms
{
    partial class BanForm
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
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.banPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.reportMessageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.reportReasonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.banExpirationLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.messagePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.banPanel.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormRounded
            // 
            this.FormRounded.AnimateWindow = true;
            this.FormRounded.AnimationInterval = 200;
            this.FormRounded.BorderRadius = 35;
            this.FormRounded.ContainerControl = this;
            this.FormRounded.DockIndicatorTransparencyValue = 0.6D;
            this.FormRounded.DragEndTransparencyValue = 0.2D;
            this.FormRounded.DragForm = false;
            this.FormRounded.HasFormShadow = false;
            this.FormRounded.TransparentWhileDrag = true;
            // 
            // banPanel
            // 
            this.banPanel.BorderColor = System.Drawing.Color.Red;
            this.banPanel.BorderRadius = 20;
            this.banPanel.BorderThickness = 1;
            this.banPanel.Controls.Add(this.closeButton);
            this.banPanel.Controls.Add(this.messagePanel);
            this.banPanel.Controls.Add(this.reasonLabel);
            this.banPanel.Controls.Add(this.banExpirationLabel);
            this.banPanel.Controls.Add(this.label1);
            this.banPanel.Controls.Add(this.reportMessageLabel);
            this.banPanel.Controls.Add(this.label2);
            this.banPanel.Controls.Add(this.reportReasonLabel);
            this.banPanel.Location = new System.Drawing.Point(0, 0);
            this.banPanel.Name = "banPanel";
            this.banPanel.Size = new System.Drawing.Size(348, 277);
            this.banPanel.TabIndex = 1;
            // 
            // reportMessageLabel
            // 
            this.reportMessageLabel.AutoSize = true;
            this.reportMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportMessageLabel.ForeColor = System.Drawing.Color.White;
            this.reportMessageLabel.Location = new System.Drawing.Point(19, 147);
            this.reportMessageLabel.Name = "reportMessageLabel";
            this.reportMessageLabel.Size = new System.Drawing.Size(203, 15);
            this.reportMessageLabel.TabIndex = 35;
            this.reportMessageLabel.Text = "Сообщение администратора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(93, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Вы были забанены";
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
            this.closeButton.Location = new System.Drawing.Point(313, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 33;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // reportReasonLabel
            // 
            this.reportReasonLabel.AutoSize = true;
            this.reportReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportReasonLabel.ForeColor = System.Drawing.Color.White;
            this.reportReasonLabel.Location = new System.Drawing.Point(19, 60);
            this.reportReasonLabel.Name = "reportReasonLabel";
            this.reportReasonLabel.Size = new System.Drawing.Size(108, 15);
            this.reportReasonLabel.TabIndex = 32;
            this.reportReasonLabel.Text = "Причина бана: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Дата окончания бана:";
            // 
            // banExpirationLabel
            // 
            this.banExpirationLabel.AutoSize = true;
            this.banExpirationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banExpirationLabel.ForeColor = System.Drawing.Color.Red;
            this.banExpirationLabel.Location = new System.Drawing.Point(180, 118);
            this.banExpirationLabel.Name = "banExpirationLabel";
            this.banExpirationLabel.Size = new System.Drawing.Size(41, 15);
            this.banExpirationLabel.TabIndex = 39;
            this.banExpirationLabel.Text = "Дата";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reasonLabel.ForeColor = System.Drawing.Color.Red;
            this.reasonLabel.Location = new System.Drawing.Point(19, 89);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(64, 15);
            this.reasonLabel.TabIndex = 41;
            this.reasonLabel.Text = "Причина";
            // 
            // messagePanel
            // 
            this.messagePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messagePanel.BorderRadius = 17;
            this.messagePanel.BorderThickness = 1;
            this.messagePanel.Controls.Add(this.messageLabel);
            this.messagePanel.Controls.Add(this.panel4);
            this.messagePanel.Controls.Add(this.panel3);
            this.messagePanel.Controls.Add(this.panel2);
            this.messagePanel.Controls.Add(this.panel1);
            this.messagePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.messagePanel.Location = new System.Drawing.Point(22, 168);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(305, 87);
            this.messagePanel.TabIndex = 45;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(10, 10);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(285, 67);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Описание";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 87);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 87);
            this.panel1.TabIndex = 0;
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(349, 278);
            this.Controls.Add(this.banPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanForm";
            this.banPanel.ResumeLayout(false);
            this.banPanel.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel banPanel;
        private System.Windows.Forms.Label reportMessageLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private System.Windows.Forms.Label reportReasonLabel;
        private System.Windows.Forms.Label banExpirationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reasonLabel;
        private Guna.UI2.WinForms.Guna2Panel messagePanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}