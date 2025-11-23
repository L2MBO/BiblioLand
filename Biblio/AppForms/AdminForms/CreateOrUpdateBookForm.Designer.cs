namespace Biblio.AppForms
{
    partial class CreateOrUpdateBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrUpdateBookForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selectPdfLabel = new System.Windows.Forms.Label();
            this.selectPdfButton = new Guna.UI2.WinForms.Guna2Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookButton = new Guna.UI2.WinForms.Guna2Button();
            this.authorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
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
            this.guna2Panel1.Controls.Add(this.categoryLabel);
            this.guna2Panel1.Controls.Add(this.categoryComboBox);
            this.guna2Panel1.Controls.Add(this.selectPdfLabel);
            this.guna2Panel1.Controls.Add(this.selectPdfButton);
            this.guna2Panel1.Controls.Add(this.descriptionLabel);
            this.guna2Panel1.Controls.Add(this.descriptionTextBox);
            this.guna2Panel1.Controls.Add(this.bookPictureBox);
            this.guna2Panel1.Controls.Add(this.nameTextBox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.addBookButton);
            this.guna2Panel1.Controls.Add(this.authorTextBox);
            this.guna2Panel1.Controls.Add(this.authorLabel);
            this.guna2Panel1.Controls.Add(this.titleLabel);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.nameLabel);
            this.guna2Panel1.Controls.Add(this.genreComboBox);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(330, 537);
            this.guna2Panel1.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(21, 269);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(78, 15);
            this.categoryLabel.TabIndex = 54;
            this.categoryLabel.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryComboBox.BorderRadius = 17;
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.categoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryComboBox.ItemHeight = 30;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Не обязательное поле",
            "Главное",
            "Новинки",
            "Популярное"});
            this.categoryComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.categoryComboBox.Location = new System.Drawing.Point(24, 287);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(287, 36);
            this.categoryComboBox.StartIndex = 0;
            this.categoryComboBox.TabIndex = 53;
            this.categoryComboBox.TabStop = false;
            this.categoryComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // selectPdfLabel
            // 
            this.selectPdfLabel.AutoSize = true;
            this.selectPdfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectPdfLabel.ForeColor = System.Drawing.Color.White;
            this.selectPdfLabel.Location = new System.Drawing.Point(21, 425);
            this.selectPdfLabel.Name = "selectPdfLabel";
            this.selectPdfLabel.Size = new System.Drawing.Size(74, 15);
            this.selectPdfLabel.TabIndex = 52;
            this.selectPdfLabel.Text = "PDF файл";
            // 
            // selectPdfButton
            // 
            this.selectPdfButton.Animated = true;
            this.selectPdfButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectPdfButton.BorderRadius = 13;
            this.selectPdfButton.BorderThickness = 1;
            this.selectPdfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPdfButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectPdfButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectPdfButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectPdfButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectPdfButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.selectPdfButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectPdfButton.ForeColor = System.Drawing.Color.White;
            this.selectPdfButton.Image = global::Biblio.Properties.Resources.download;
            this.selectPdfButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.selectPdfButton.ImageOffset = new System.Drawing.Point(0, -1);
            this.selectPdfButton.ImageSize = new System.Drawing.Size(16, 16);
            this.selectPdfButton.Location = new System.Drawing.Point(24, 443);
            this.selectPdfButton.Name = "selectPdfButton";
            this.selectPdfButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.selectPdfButton.Size = new System.Drawing.Size(122, 28);
            this.selectPdfButton.TabIndex = 51;
            this.selectPdfButton.Text = "Выбрать файл";
            this.selectPdfButton.TextOffset = new System.Drawing.Point(10, 0);
            this.selectPdfButton.Click += new System.EventHandler(this.selectPdfButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(21, 331);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 50;
            this.descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Animated = true;
            this.descriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTextBox.BorderRadius = 10;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(24, 349);
            this.descriptionTextBox.MaxLength = 600;
            this.descriptionTextBox.MinimumSize = new System.Drawing.Size(0, 66);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.descriptionTextBox.PlaceholderText = "";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(287, 66);
            this.descriptionTextBox.TabIndex = 49;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderRadius = 13;
            this.bookPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookPictureBox.ImageRotate = 0F;
            this.bookPictureBox.Location = new System.Drawing.Point(24, 65);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(87, 131);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 41;
            this.bookPictureBox.TabStop = false;
            this.bookPictureBox.Click += new System.EventHandler(this.bookPictureBox_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.BorderRadius = 17;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(128, 90);
            this.nameTextBox.MaxLength = 200;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(183, 36);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Жанр";
            // 
            // addBookButton
            // 
            this.addBookButton.Animated = true;
            this.addBookButton.BorderRadius = 17;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBookButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.addBookButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(181, 484);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.addBookButton.Size = new System.Drawing.Size(130, 36);
            this.addBookButton.TabIndex = 37;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorTextBox.BorderRadius = 17;
            this.authorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorTextBox.DefaultText = "";
            this.authorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.authorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.authorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.authorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.authorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authorTextBox.ForeColor = System.Drawing.Color.White;
            this.authorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authorTextBox.Location = new System.Drawing.Point(128, 152);
            this.authorTextBox.MaxLength = 200;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.PlaceholderText = "";
            this.authorTextBox.SelectedText = "";
            this.authorTextBox.Size = new System.Drawing.Size(183, 36);
            this.authorTextBox.TabIndex = 36;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(125, 134);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(47, 15);
            this.authorLabel.TabIndex = 35;
            this.authorLabel.Text = "Автор";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(142, 20);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Добавить книгу";
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(125, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 15);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Название";
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.Transparent;
            this.genreComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreComboBox.BorderRadius = 17;
            this.genreComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genreComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.genreComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.genreComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genreComboBox.ForeColor = System.Drawing.Color.White;
            this.genreComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genreComboBox.ItemHeight = 30;
            this.genreComboBox.Items.AddRange(new object[] {
            "Военное дело",
            "Политика",
            "Философия",
            "Фантастика",
            "Детектив",
            "Биография",
            "Научная литература",
            "Художественная литература",
            "Роман",
            "Ужасы"});
            this.genreComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.genreComboBox.Location = new System.Drawing.Point(24, 223);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(287, 36);
            this.genreComboBox.StartIndex = 0;
            this.genreComboBox.TabIndex = 31;
            this.genreComboBox.TabStop = false;
            this.genreComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // CreateOrUpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(331, 538);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrUpdateBookForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button addBookButton;
        private Guna.UI2.WinForms.Guna2TextBox authorTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2ComboBox genreComboBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox bookPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private System.Windows.Forms.Label selectPdfLabel;
        private Guna.UI2.WinForms.Guna2Button selectPdfButton;
        private System.Windows.Forms.Label categoryLabel;
        private Guna.UI2.WinForms.Guna2ComboBox categoryComboBox;
    }
}