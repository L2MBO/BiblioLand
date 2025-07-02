namespace Biblio.AppForms.UserForms
{
    partial class ShowNotify
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
            this.label1 = new System.Windows.Forms.Label();
            this.banCalendar = new System.Windows.Forms.MonthCalendar();
            this.issueBanButton = new Guna.UI2.WinForms.Guna2Button();
            this.banMessageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.banMessageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.banReasonLabel = new System.Windows.Forms.Label();
            this.banReasonComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.banCalendar);
            this.guna2Panel1.Controls.Add(this.issueBanButton);
            this.guna2Panel1.Controls.Add(this.banMessageTextBox);
            this.guna2Panel1.Controls.Add(this.banMessageLabel);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.banReasonLabel);
            this.guna2Panel1.Controls.Add(this.banReasonComboBox);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(330, 441);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Дата окончания бана";
            // 
            // banCalendar
            // 
            this.banCalendar.BackColor = System.Drawing.Color.White;
            this.banCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.banCalendar.Location = new System.Drawing.Point(24, 217);
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
            this.issueBanButton.Location = new System.Drawing.Point(181, 391);
            this.issueBanButton.Name = "issueBanButton";
            this.issueBanButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.issueBanButton.Size = new System.Drawing.Size(130, 36);
            this.issueBanButton.TabIndex = 37;
            this.issueBanButton.Text = "Выдать бан";
            // 
            // banMessageTextBox
            // 
            this.banMessageTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banMessageTextBox.BorderRadius = 17;
            this.banMessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.banMessageTextBox.DefaultText = "";
            this.banMessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.banMessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.banMessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.banMessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.banMessageTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.banMessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banMessageTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.banMessageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.banMessageTextBox.ForeColor = System.Drawing.Color.White;
            this.banMessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.banMessageTextBox.Location = new System.Drawing.Point(20, 147);
            this.banMessageTextBox.MaxLength = 200;
            this.banMessageTextBox.Name = "banMessageTextBox";
            this.banMessageTextBox.PlaceholderText = "Не обязательное поле";
            this.banMessageTextBox.SelectedText = "";
            this.banMessageTextBox.Size = new System.Drawing.Size(291, 36);
            this.banMessageTextBox.TabIndex = 36;
            // 
            // banMessageLabel
            // 
            this.banMessageLabel.AutoSize = true;
            this.banMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banMessageLabel.ForeColor = System.Drawing.Color.White;
            this.banMessageLabel.Location = new System.Drawing.Point(20, 126);
            this.banMessageLabel.Name = "banMessageLabel";
            this.banMessageLabel.Size = new System.Drawing.Size(82, 15);
            this.banMessageLabel.TabIndex = 35;
            this.banMessageLabel.Text = "Сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Тема";
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // banReasonLabel
            // 
            this.banReasonLabel.AutoSize = true;
            this.banReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banReasonLabel.ForeColor = System.Drawing.Color.White;
            this.banReasonLabel.Location = new System.Drawing.Point(20, 60);
            this.banReasonLabel.Name = "banReasonLabel";
            this.banReasonLabel.Size = new System.Drawing.Size(100, 15);
            this.banReasonLabel.TabIndex = 32;
            this.banReasonLabel.Text = "Причина бана";
            // 
            // banReasonComboBox
            // 
            this.banReasonComboBox.BackColor = System.Drawing.Color.Transparent;
            this.banReasonComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banReasonComboBox.BorderRadius = 17;
            this.banReasonComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banReasonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.banReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banReasonComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.banReasonComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banReasonComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banReasonComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.banReasonComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.banReasonComboBox.ForeColor = System.Drawing.Color.White;
            this.banReasonComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.banReasonComboBox.ItemHeight = 30;
            this.banReasonComboBox.Items.AddRange(new object[] {
            "Нарушение законов РФ",
            "Неподобающий никнейм",
            "Нарушение правил написания комментариев",
            "Другое"});
            this.banReasonComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.banReasonComboBox.Location = new System.Drawing.Point(20, 80);
            this.banReasonComboBox.Name = "banReasonComboBox";
            this.banReasonComboBox.Size = new System.Drawing.Size(291, 36);
            this.banReasonComboBox.TabIndex = 31;
            this.banReasonComboBox.TabStop = false;
            this.banReasonComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ShowNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(331, 442);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowNotify";
            this.Text = "ShowNotify";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar banCalendar;
        private Guna.UI2.WinForms.Guna2Button issueBanButton;
        private Guna.UI2.WinForms.Guna2TextBox banMessageTextBox;
        private System.Windows.Forms.Label banMessageLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private System.Windows.Forms.Label banReasonLabel;
        private Guna.UI2.WinForms.Guna2ComboBox banReasonComboBox;
    }
}