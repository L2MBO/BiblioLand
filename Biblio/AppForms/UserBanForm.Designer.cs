namespace Biblio.AppForms
{
    partial class UserBanForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sendReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.reportMessageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.reportMessageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.reportReasonLabel = new System.Windows.Forms.Label();
            this.reportReasonComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.sendReportButton);
            this.guna2Panel1.Controls.Add(this.reportMessageTextBox);
            this.guna2Panel1.Controls.Add(this.reportMessageLabel);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.reportReasonLabel);
            this.guna2Panel1.Controls.Add(this.reportReasonComboBox);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(330, 250);
            this.guna2Panel1.TabIndex = 1;
            // 
            // sendReportButton
            // 
            this.sendReportButton.Animated = true;
            this.sendReportButton.BorderRadius = 17;
            this.sendReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.sendReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendReportButton.ForeColor = System.Drawing.Color.White;
            this.sendReportButton.Location = new System.Drawing.Point(181, 197);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.sendReportButton.Size = new System.Drawing.Size(130, 36);
            this.sendReportButton.TabIndex = 37;
            this.sendReportButton.Text = "Отправить жалобу";
            // 
            // reportMessageTextBox
            // 
            this.reportMessageTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportMessageTextBox.BorderRadius = 17;
            this.reportMessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reportMessageTextBox.DefaultText = "";
            this.reportMessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reportMessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reportMessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportMessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportMessageTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.reportMessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportMessageTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.reportMessageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportMessageTextBox.ForeColor = System.Drawing.Color.White;
            this.reportMessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportMessageTextBox.Location = new System.Drawing.Point(20, 147);
            this.reportMessageTextBox.Name = "reportMessageTextBox";
            this.reportMessageTextBox.PlaceholderText = "";
            this.reportMessageTextBox.SelectedText = "";
            this.reportMessageTextBox.Size = new System.Drawing.Size(291, 36);
            this.reportMessageTextBox.TabIndex = 36;
            // 
            // reportMessageLabel
            // 
            this.reportMessageLabel.AutoSize = true;
            this.reportMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportMessageLabel.ForeColor = System.Drawing.Color.White;
            this.reportMessageLabel.Location = new System.Drawing.Point(20, 126);
            this.reportMessageLabel.Name = "reportMessageLabel";
            this.reportMessageLabel.Size = new System.Drawing.Size(82, 15);
            this.reportMessageLabel.TabIndex = 35;
            this.reportMessageLabel.Text = "Сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Забанить пользователя";
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
            this.closeButton.Location = new System.Drawing.Point(295, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 33;
            // 
            // reportReasonLabel
            // 
            this.reportReasonLabel.AutoSize = true;
            this.reportReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportReasonLabel.ForeColor = System.Drawing.Color.White;
            this.reportReasonLabel.Location = new System.Drawing.Point(20, 60);
            this.reportReasonLabel.Name = "reportReasonLabel";
            this.reportReasonLabel.Size = new System.Drawing.Size(124, 15);
            this.reportReasonLabel.TabIndex = 32;
            this.reportReasonLabel.Text = "Причина репорта";
            // 
            // reportReasonComboBox
            // 
            this.reportReasonComboBox.BackColor = System.Drawing.Color.Transparent;
            this.reportReasonComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportReasonComboBox.BorderRadius = 17;
            this.reportReasonComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportReasonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportReasonComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.reportReasonComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportReasonComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportReasonComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.reportReasonComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportReasonComboBox.ForeColor = System.Drawing.Color.White;
            this.reportReasonComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportReasonComboBox.ItemHeight = 30;
            this.reportReasonComboBox.Items.AddRange(new object[] {
            "Дубль",
            "Несоответвие жанра",
            "Другое"});
            this.reportReasonComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.reportReasonComboBox.Location = new System.Drawing.Point(20, 80);
            this.reportReasonComboBox.Name = "reportReasonComboBox";
            this.reportReasonComboBox.Size = new System.Drawing.Size(291, 36);
            this.reportReasonComboBox.TabIndex = 31;
            this.reportReasonComboBox.TabStop = false;
            this.reportReasonComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // UserBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(331, 251);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserBanForm";
            this.Text = "UserBanForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button sendReportButton;
        private Guna.UI2.WinForms.Guna2TextBox reportMessageTextBox;
        private System.Windows.Forms.Label reportMessageLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private System.Windows.Forms.Label reportReasonLabel;
        private Guna.UI2.WinForms.Guna2ComboBox reportReasonComboBox;
    }
}