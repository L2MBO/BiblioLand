namespace Biblio.CustomControls
{
    partial class AddContentControl
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(100, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bookButton);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 50);
            this.panel1.TabIndex = 0;
            // 
            // cardButton
            // 
            this.cardButton.Animated = true;
            this.cardButton.BorderRadius = 10;
            this.cardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.cardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardButton.ForeColor = System.Drawing.Color.White;
            this.cardButton.Location = new System.Drawing.Point(0, 30);
            this.cardButton.Name = "cardButton";
            this.cardButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cardButton.Size = new System.Drawing.Size(80, 20);
            this.cardButton.TabIndex = 5;
            this.cardButton.Text = "Карточку";
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 10);
            this.panel2.TabIndex = 4;
            // 
            // bookButton
            // 
            this.bookButton.Animated = true;
            this.bookButton.BorderRadius = 10;
            this.bookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookButton.ForeColor = System.Drawing.Color.White;
            this.bookButton.Location = new System.Drawing.Point(0, 0);
            this.bookButton.Name = "bookButton";
            this.bookButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.bookButton.Size = new System.Drawing.Size(80, 20);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Книгу";
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // AddContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AddContentControl";
            this.Size = new System.Drawing.Size(101, 71);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button cardButton;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bookButton;
    }
}
