namespace Biblio.AppForms
{
    partial class BookInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.commentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sortInterestingCommentButton = new Guna.UI2.WinForms.Guna2Button();
            this.sortNewCommentButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.writeCommentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.commentTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.sendCommentButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statisticsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.descriptionPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.ratingCountLabel = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.evaluateButton = new Guna.UI2.WinForms.Guna2Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.reportButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.newBookmarkButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.continueReadingButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationControl = new Biblio.CustomControls.NavigationControl();
            this.mainPanel.SuspendLayout();
            this.panel21.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.writeCommentPanel.SuspendLayout();
            this.panel19.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel15.SuspendLayout();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.commentsPanel);
            this.mainPanel.Controls.Add(this.panel22);
            this.mainPanel.Controls.Add(this.panel21);
            this.mainPanel.Controls.Add(this.panel20);
            this.mainPanel.Controls.Add(this.writeCommentPanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.statisticsPanel);
            this.mainPanel.Controls.Add(this.panel8);
            this.mainPanel.Controls.Add(this.descriptionPanel);
            this.mainPanel.Controls.Add(this.panel6);
            this.mainPanel.Controls.Add(this.panel7);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.bookPanel);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 25;
            this.mainPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mainPanel_Scroll);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // commentsPanel
            // 
            this.commentsPanel.AutoSize = true;
            this.commentsPanel.BackColor = System.Drawing.Color.Transparent;
            this.commentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentsPanel.Location = new System.Drawing.Point(256, 281);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(370, 0);
            this.commentsPanel.TabIndex = 55;
            // 
            // panel22
            // 
            this.panel22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(256, 271);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(370, 10);
            this.panel22.TabIndex = 54;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Transparent;
            this.panel21.Controls.Add(this.guna2Panel1);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(256, 239);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(370, 32);
            this.panel21.TabIndex = 53;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 14;
            this.guna2Panel1.Controls.Add(this.sortInterestingCommentButton);
            this.guna2Panel1.Controls.Add(this.sortNewCommentButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(172, 32);
            this.guna2Panel1.TabIndex = 0;
            // 
            // sortInterestingCommentButton
            // 
            this.sortInterestingCommentButton.Animated = true;
            this.sortInterestingCommentButton.BackColor = System.Drawing.Color.Transparent;
            this.sortInterestingCommentButton.BorderRadius = 11;
            this.sortInterestingCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortInterestingCommentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sortInterestingCommentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sortInterestingCommentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sortInterestingCommentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sortInterestingCommentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.sortInterestingCommentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortInterestingCommentButton.ForeColor = System.Drawing.Color.White;
            this.sortInterestingCommentButton.Location = new System.Drawing.Point(74, 3);
            this.sortInterestingCommentButton.Name = "sortInterestingCommentButton";
            this.sortInterestingCommentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.sortInterestingCommentButton.Size = new System.Drawing.Size(95, 25);
            this.sortInterestingCommentButton.TabIndex = 39;
            this.sortInterestingCommentButton.Text = "Интересные";
            this.sortInterestingCommentButton.Click += new System.EventHandler(this.sortInterestingCommentButton_Click);
            // 
            // sortNewCommentButton
            // 
            this.sortNewCommentButton.Animated = true;
            this.sortNewCommentButton.BackColor = System.Drawing.Color.Transparent;
            this.sortNewCommentButton.BorderRadius = 11;
            this.sortNewCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.sortNewCommentButton.Size = new System.Drawing.Size(65, 25);
            this.sortNewCommentButton.TabIndex = 38;
            this.sortNewCommentButton.Text = "Новые";
            this.sortNewCommentButton.Click += new System.EventHandler(this.sortNewCommentButton_Click);
            // 
            // panel20
            // 
            this.panel20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(256, 229);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(370, 10);
            this.panel20.TabIndex = 52;
            // 
            // writeCommentPanel
            // 
            this.writeCommentPanel.AutoSize = true;
            this.writeCommentPanel.BackColor = System.Drawing.Color.Transparent;
            this.writeCommentPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.writeCommentPanel.BorderRadius = 10;
            this.writeCommentPanel.BorderThickness = 2;
            this.writeCommentPanel.Controls.Add(this.commentTextBox);
            this.writeCommentPanel.Controls.Add(this.panel17);
            this.writeCommentPanel.Controls.Add(this.panel19);
            this.writeCommentPanel.Controls.Add(this.panel16);
            this.writeCommentPanel.Controls.Add(this.panel9);
            this.writeCommentPanel.Controls.Add(this.panel5);
            this.writeCommentPanel.Controls.Add(this.panel2);
            this.writeCommentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.writeCommentPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.writeCommentPanel.Location = new System.Drawing.Point(256, 143);
            this.writeCommentPanel.MaximumSize = new System.Drawing.Size(370, 0);
            this.writeCommentPanel.Name = "writeCommentPanel";
            this.writeCommentPanel.Size = new System.Drawing.Size(370, 86);
            this.writeCommentPanel.TabIndex = 51;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Animated = true;
            this.commentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.commentTextBox.BorderColor = System.Drawing.Color.Empty;
            this.commentTextBox.BorderThickness = 0;
            this.commentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentTextBox.DefaultText = "";
            this.commentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.commentTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTextBox.ForeColor = System.Drawing.Color.White;
            this.commentTextBox.Location = new System.Drawing.Point(10, 10);
            this.commentTextBox.MaxLength = 600;
            this.commentTextBox.MinimumSize = new System.Drawing.Size(0, 31);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.commentTextBox.PlaceholderText = "Оставить комментарий";
            this.commentTextBox.SelectedText = "";
            this.commentTextBox.Size = new System.Drawing.Size(350, 31);
            this.commentTextBox.TabIndex = 57;
            this.commentTextBox.TextChanged += new System.EventHandler(this.commentTextBox_TextChanged);
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(10, 41);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(350, 10);
            this.panel17.TabIndex = 56;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.sendCommentButton);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(10, 51);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(350, 25);
            this.panel19.TabIndex = 55;
            // 
            // sendCommentButton
            // 
            this.sendCommentButton.Animated = true;
            this.sendCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.sendCommentButton.BorderRadius = 11;
            this.sendCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCommentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendCommentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendCommentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendCommentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendCommentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.sendCommentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendCommentButton.ForeColor = System.Drawing.Color.White;
            this.sendCommentButton.Location = new System.Drawing.Point(264, 0);
            this.sendCommentButton.Name = "sendCommentButton";
            this.sendCommentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.sendCommentButton.Size = new System.Drawing.Size(86, 25);
            this.sendCommentButton.TabIndex = 37;
            this.sendCommentButton.Text = "Отправить";
            this.sendCommentButton.Click += new System.EventHandler(this.sendCommentButton_Click);
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(10, 76);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(350, 10);
            this.panel16.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(360, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 76);
            this.panel9.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 76);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(256, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 10);
            this.panel1.TabIndex = 47;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.AutoSize = true;
            this.statisticsPanel.BackColor = System.Drawing.Color.Transparent;
            this.statisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsPanel.Location = new System.Drawing.Point(256, 133);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(370, 0);
            this.statisticsPanel.TabIndex = 46;
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(256, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(370, 10);
            this.panel8.TabIndex = 45;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.AutoSize = true;
            this.descriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.Controls.Add(this.panel13);
            this.descriptionPanel.Controls.Add(this.panel12);
            this.descriptionPanel.Controls.Add(this.panel11);
            this.descriptionPanel.Controls.Add(this.panel10);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.FillColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.descriptionPanel.FillColor4 = System.Drawing.Color.Transparent;
            this.descriptionPanel.Location = new System.Drawing.Point(256, 88);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Quality = 1;
            this.descriptionPanel.ShadowDecoration.BorderRadius = 20;
            this.descriptionPanel.ShadowDecoration.Depth = 150;
            this.descriptionPanel.ShadowDecoration.Enabled = true;
            this.descriptionPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.descriptionPanel.Size = new System.Drawing.Size(370, 35);
            this.descriptionPanel.TabIndex = 44;
            // 
            // panel13
            // 
            this.panel13.AutoSize = true;
            this.panel13.Controls.Add(this.descriptionLabel);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(360, 15);
            this.panel13.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(360, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Описание";
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(360, 10);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 15);
            this.panel12.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 25);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(370, 10);
            this.panel11.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(370, 10);
            this.panel10.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(256, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(370, 10);
            this.panel6.TabIndex = 43;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.genreLabel);
            this.panel7.Controls.Add(this.nameLabel);
            this.panel7.Controls.Add(this.authorLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(256, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(370, 62);
            this.panel7.TabIndex = 42;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.ratingLabel);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(265, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(105, 62);
            this.panel14.TabIndex = 3;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(34, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(71, 20);
            this.ratingLabel.TabIndex = 7;
            this.ratingLabel.Text = "Оценка";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.ratingCountLabel);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(0, 21);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(105, 20);
            this.panel18.TabIndex = 6;
            // 
            // ratingCountLabel
            // 
            this.ratingCountLabel.AutoSize = true;
            this.ratingCountLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ratingCountLabel.ForeColor = System.Drawing.Color.White;
            this.ratingCountLabel.Location = new System.Drawing.Point(22, 0);
            this.ratingCountLabel.Name = "ratingCountLabel";
            this.ratingCountLabel.Size = new System.Drawing.Size(83, 13);
            this.ratingCountLabel.TabIndex = 0;
            this.ratingCountLabel.Text = "Число голосов";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.evaluateButton);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 41);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(105, 21);
            this.panel15.TabIndex = 4;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Animated = true;
            this.evaluateButton.BorderRadius = 10;
            this.evaluateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.evaluateButton.DefaultAutoSize = true;
            this.evaluateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.evaluateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.evaluateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.evaluateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.evaluateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.evaluateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.evaluateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evaluateButton.ForeColor = System.Drawing.Color.White;
            this.evaluateButton.Location = new System.Drawing.Point(27, 0);
            this.evaluateButton.MaximumSize = new System.Drawing.Size(0, 21);
            this.evaluateButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.evaluateButton.Size = new System.Drawing.Size(78, 21);
            this.evaluateButton.TabIndex = 2;
            this.evaluateButton.Text = "Оценить";
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(6, 44);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Жанр";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(5, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.authorLabel.Location = new System.Drawing.Point(6, 3);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(37, 13);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Автор";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(246, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 362);
            this.panel4.TabIndex = 41;
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.Color.Transparent;
            this.bookPanel.Controls.Add(this.reportButton);
            this.bookPanel.Controls.Add(this.panel25);
            this.bookPanel.Controls.Add(this.newBookmarkButton);
            this.bookPanel.Controls.Add(this.panel24);
            this.bookPanel.Controls.Add(this.continueReadingButton);
            this.bookPanel.Controls.Add(this.panel23);
            this.bookPanel.Controls.Add(this.bookPictureBox);
            this.bookPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookPanel.Location = new System.Drawing.Point(100, 16);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(146, 362);
            this.bookPanel.TabIndex = 40;
            // 
            // reportButton
            // 
            this.reportButton.Animated = true;
            this.reportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportButton.BorderRadius = 13;
            this.reportButton.BorderThickness = 2;
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Image = global::Biblio.Properties.Resources.report;
            this.reportButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.reportButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.reportButton.ImageSize = new System.Drawing.Size(15, 13);
            this.reportButton.Location = new System.Drawing.Point(0, 315);
            this.reportButton.Name = "reportButton";
            this.reportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.reportButton.Size = new System.Drawing.Size(146, 28);
            this.reportButton.TabIndex = 38;
            this.reportButton.Text = "Пожаловаться";
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 305);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(146, 10);
            this.panel25.TabIndex = 37;
            // 
            // newBookmarkButton
            // 
            this.newBookmarkButton.Animated = true;
            this.newBookmarkButton.BorderRadius = 13;
            this.newBookmarkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBookmarkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newBookmarkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newBookmarkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newBookmarkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newBookmarkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newBookmarkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.newBookmarkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newBookmarkButton.ForeColor = System.Drawing.Color.White;
            this.newBookmarkButton.Location = new System.Drawing.Point(0, 277);
            this.newBookmarkButton.Name = "newBookmarkButton";
            this.newBookmarkButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.newBookmarkButton.Size = new System.Drawing.Size(146, 28);
            this.newBookmarkButton.TabIndex = 36;
            this.newBookmarkButton.Text = "В закладки";
            this.newBookmarkButton.Click += new System.EventHandler(this.newBookmarkButton_Click);
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 267);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(146, 10);
            this.panel24.TabIndex = 35;
            // 
            // continueReadingButton
            // 
            this.continueReadingButton.Animated = true;
            this.continueReadingButton.BorderRadius = 20;
            this.continueReadingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueReadingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continueReadingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continueReadingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continueReadingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continueReadingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.continueReadingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.continueReadingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.continueReadingButton.ForeColor = System.Drawing.Color.White;
            this.continueReadingButton.Location = new System.Drawing.Point(0, 226);
            this.continueReadingButton.Name = "continueReadingButton";
            this.continueReadingButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.continueReadingButton.Size = new System.Drawing.Size(146, 41);
            this.continueReadingButton.TabIndex = 34;
            this.continueReadingButton.Text = "Читать";
            this.continueReadingButton.Click += new System.EventHandler(this.continueRadingButton_Click);
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 216);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(146, 10);
            this.panel23.TabIndex = 33;
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 15;
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(146, 216);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 4;
            this.bookPictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 16);
            this.panel3.TabIndex = 39;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(626, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 378);
            this.rightPanel.TabIndex = 38;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 378);
            this.leftPanel.TabIndex = 37;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 200;
            this.BorderlessForm.BorderRadius = 11;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
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
            this.navigationControl.Margin = new System.Windows.Forms.Padding(6);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(726, 52);
            this.navigationControl.TabIndex = 0;
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookInfoForm_Load);
            this.Shown += new System.EventHandler(this.BookInfoForm_Shown);
            this.SizeChanged += new System.EventHandler(this.BookInfoForm_SizeChanged);
            this.Resize += new System.EventHandler(this.BookInfoForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.writeCommentPanel.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel statisticsPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label ratingCountLabel;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel bookPanel;
        private Guna.UI2.WinForms.Guna2Button reportButton;
        private System.Windows.Forms.Panel panel25;
        private Guna.UI2.WinForms.Guna2Button newBookmarkButton;
        private System.Windows.Forms.Panel panel24;
        private Guna.UI2.WinForms.Guna2Button continueReadingButton;
        private System.Windows.Forms.Panel panel23;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel descriptionPanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2Button evaluateButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel writeCommentPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private Guna.UI2.WinForms.Guna2Button sendCommentButton;
        private Guna.UI2.WinForms.Guna2TextBox commentTextBox;
        private System.Windows.Forms.Panel panel21;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel20;
        private Guna.UI2.WinForms.Guna2Button sortNewCommentButton;
        private Guna.UI2.WinForms.Guna2Button sortInterestingCommentButton;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.FlowLayoutPanel commentsPanel;
    }
}