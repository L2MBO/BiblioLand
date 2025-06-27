namespace Biblio.AppForms.AdminForms
{
    partial class ExtendBanForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.banCalendar = new System.Windows.Forms.MonthCalendar();
            this.issueBanButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.banCalendar);
            this.guna2Panel1.Controls.Add(this.issueBanButton);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(245, 302);
            this.guna2Panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Дата окончания бана";
            // 
            // banCalendar
            // 
            this.banCalendar.BackColor = System.Drawing.Color.White;
            this.banCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.banCalendar.Location = new System.Drawing.Point(41, 79);
            this.banCalendar.MaxSelectionCount = 1;
            this.banCalendar.MinDate = new System.DateTime(2025, 6, 25, 0, 0, 0, 0);
            this.banCalendar.Name = "banCalendar";
            this.banCalendar.ShowTodayCircle = false;
            this.banCalendar.TabIndex = 38;
            this.banCalendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            // 
            // issueBanButton
            // 
            this.issueBanButton.Animated = true;
            this.issueBanButton.BorderRadius = 17;
            this.issueBanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBanButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.issueBanButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.issueBanButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.issueBanButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.issueBanButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.issueBanButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issueBanButton.ForeColor = System.Drawing.Color.White;
            this.issueBanButton.Location = new System.Drawing.Point(75, 253);
            this.issueBanButton.Name = "issueBanButton";
            this.issueBanButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.issueBanButton.Size = new System.Drawing.Size(130, 36);
            this.issueBanButton.TabIndex = 37;
            this.issueBanButton.Text = "Выдать бан";
            this.issueBanButton.Click += new System.EventHandler(this.issueBanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Обновить сроки бана";
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
            this.closeButton.Location = new System.Drawing.Point(210, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 33;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // ExtendBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(246, 303);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtendBanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendBanForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar banCalendar;
        private Guna.UI2.WinForms.Guna2Button issueBanButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
    }
}