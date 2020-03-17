namespace Haberdashery_course
{
    partial class WorkingPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingPanel));
            this.Menu = new System.Windows.Forms.TabControl();
            this.applicationsPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canselSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.searchSurnameTextBox = new System.Windows.Forms.TextBox();
            this.applicationsGrid = new System.Windows.Forms.DataGridView();
            this.numberOfApplictionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextApplicationsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закритиЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsOperationsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.clientIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsOperationsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.editClient = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.productPage = new System.Windows.Forms.TabPage();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsOperationsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.editNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.extraProductsInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.material = new System.Windows.Forms.ToolStripMenuItem();
            this.priceList = new System.Windows.Forms.TabPage();
            this.priceListGrid = new System.Windows.Forms.DataGridView();
            this.priceListIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceListMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addService = new System.Windows.Forms.ToolStripMenuItem();
            this.delService = new System.Windows.Forms.ToolStripMenuItem();
            this.changeServiceCost = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.applicationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsGrid)).BeginInit();
            this.contextApplicationsMenu.SuspendLayout();
            this.applicationsOperationsMenuStrip.SuspendLayout();
            this.clientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.clientsOperationsMenuStrip.SuspendLayout();
            this.productPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.productsOperationsMenuStrip.SuspendLayout();
            this.priceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListGrid)).BeginInit();
            this.priceListMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Controls.Add(this.applicationsPage);
            this.Menu.Controls.Add(this.clientsPage);
            this.Menu.Controls.Add(this.productPage);
            this.Menu.Controls.Add(this.priceList);
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.HotTrack = true;
            this.Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Menu.Location = new System.Drawing.Point(-4, -2);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1047, 457);
            this.Menu.TabIndex = 0;
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            // 
            // applicationsPage
            // 
            this.applicationsPage.BackColor = System.Drawing.Color.White;
            this.applicationsPage.BackgroundImage = global::Haberdashery_course.Properties.Resources.BD_157_Teal_1_550x5504;
            this.applicationsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationsPage.Controls.Add(this.label2);
            this.applicationsPage.Controls.Add(this.label1);
            this.applicationsPage.Controls.Add(this.canselSearchButton);
            this.applicationsPage.Controls.Add(this.searchButton);
            this.applicationsPage.Controls.Add(this.searchIDTextBox);
            this.applicationsPage.Controls.Add(this.searchSurnameTextBox);
            this.applicationsPage.Controls.Add(this.applicationsGrid);
            this.applicationsPage.Controls.Add(this.applicationsOperationsMenuStrip);
            this.applicationsPage.Location = new System.Drawing.Point(4, 24);
            this.applicationsPage.Name = "applicationsPage";
            this.applicationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.applicationsPage.Size = new System.Drawing.Size(1039, 429);
            this.applicationsPage.TabIndex = 0;
            this.applicationsPage.Text = "Заявки на ремонт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(587, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер заявки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Прізвище:";
            // 
            // canselSearchButton
            // 
            this.canselSearchButton.BackgroundImage = global::Haberdashery_course.Properties.Resources.cansel_icon1;
            this.canselSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.canselSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canselSearchButton.Location = new System.Drawing.Point(967, 377);
            this.canselSearchButton.Name = "canselSearchButton";
            this.canselSearchButton.Size = new System.Drawing.Size(25, 21);
            this.canselSearchButton.TabIndex = 5;
            this.canselSearchButton.UseVisualStyleBackColor = true;
            this.canselSearchButton.Click += new System.EventHandler(this.canselSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::Haberdashery_course.Properties.Resources.search_icon1;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(967, 344);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(25, 21);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.Location = new System.Drawing.Point(755, 377);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(185, 21);
            this.searchIDTextBox.TabIndex = 3;
            this.searchIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchIDTextBox_KeyPress);
            // 
            // searchSurnameTextBox
            // 
            this.searchSurnameTextBox.Location = new System.Drawing.Point(755, 344);
            this.searchSurnameTextBox.Name = "searchSurnameTextBox";
            this.searchSurnameTextBox.Size = new System.Drawing.Size(185, 21);
            this.searchSurnameTextBox.TabIndex = 2;
            this.searchSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchSurnameTextBox_KeyPress);
            // 
            // applicationsGrid
            // 
            this.applicationsGrid.AllowUserToAddRows = false;
            this.applicationsGrid.AllowUserToDeleteRows = false;
            this.applicationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.applicationsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applicationsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.applicationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfApplictionCol,
            this.clientCol,
            this.productCol,
            this.aplCategory,
            this.descriptionCol,
            this.typeCol,
            this.costCol,
            this.stateCol,
            this.checkoutDateCol,
            this.completionDateCol});
            this.applicationsGrid.ContextMenuStrip = this.contextApplicationsMenu;
            this.applicationsGrid.Location = new System.Drawing.Point(16, 30);
            this.applicationsGrid.Name = "applicationsGrid";
            this.applicationsGrid.ReadOnly = true;
            this.applicationsGrid.RowHeadersWidth = 51;
            this.applicationsGrid.Size = new System.Drawing.Size(976, 300);
            this.applicationsGrid.TabIndex = 1;
            this.applicationsGrid.SelectionChanged += new System.EventHandler(this.applicationsGrid_SelectionChanged);
            // 
            // numberOfApplictionCol
            // 
            this.numberOfApplictionCol.HeaderText = "№";
            this.numberOfApplictionCol.MinimumWidth = 6;
            this.numberOfApplictionCol.Name = "numberOfApplictionCol";
            this.numberOfApplictionCol.ReadOnly = true;
            this.numberOfApplictionCol.Width = 44;
            // 
            // clientCol
            // 
            this.clientCol.HeaderText = "Замовник";
            this.clientCol.MinimumWidth = 6;
            this.clientCol.Name = "clientCol";
            this.clientCol.ReadOnly = true;
            this.clientCol.Width = 90;
            // 
            // productCol
            // 
            this.productCol.HeaderText = "Виріб";
            this.productCol.MinimumWidth = 6;
            this.productCol.Name = "productCol";
            this.productCol.ReadOnly = true;
            this.productCol.Width = 64;
            // 
            // aplCategory
            // 
            this.aplCategory.HeaderText = "Категорія";
            this.aplCategory.MinimumWidth = 6;
            this.aplCategory.Name = "aplCategory";
            this.aplCategory.ReadOnly = true;
            this.aplCategory.Width = 90;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Опис несправностей";
            this.descriptionCol.MinimumWidth = 6;
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            this.descriptionCol.Width = 140;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Тип послуги";
            this.typeCol.MinimumWidth = 6;
            this.typeCol.Name = "typeCol";
            this.typeCol.ReadOnly = true;
            this.typeCol.Width = 92;
            // 
            // costCol
            // 
            this.costCol.HeaderText = "Вартість послуги";
            this.costCol.MinimumWidth = 6;
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            this.costCol.Width = 120;
            // 
            // stateCol
            // 
            this.stateCol.HeaderText = "Стан";
            this.stateCol.MinimumWidth = 6;
            this.stateCol.Name = "stateCol";
            this.stateCol.ReadOnly = true;
            this.stateCol.Width = 61;
            // 
            // checkoutDateCol
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.checkoutDateCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkoutDateCol.HeaderText = "Дата оформлення";
            this.checkoutDateCol.MinimumWidth = 6;
            this.checkoutDateCol.Name = "checkoutDateCol";
            this.checkoutDateCol.ReadOnly = true;
            this.checkoutDateCol.Width = 129;
            // 
            // completionDateCol
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.completionDateCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.completionDateCol.HeaderText = "Дата виконання";
            this.completionDateCol.MinimumWidth = 6;
            this.completionDateCol.Name = "completionDateCol";
            this.completionDateCol.ReadOnly = true;
            this.completionDateCol.Width = 116;
            // 
            // contextApplicationsMenu
            // 
            this.contextApplicationsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextApplicationsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закритиЗаявкуToolStripMenuItem});
            this.contextApplicationsMenu.Name = "contextMenuStrip1";
            this.contextApplicationsMenu.Size = new System.Drawing.Size(158, 26);
            // 
            // закритиЗаявкуToolStripMenuItem
            // 
            this.закритиЗаявкуToolStripMenuItem.Name = "закритиЗаявкуToolStripMenuItem";
            this.закритиЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.закритиЗаявкуToolStripMenuItem.Text = "Закрити заявку";
            this.закритиЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.закритиЗаявкуToolStripMenuItem_Click);
            // 
            // applicationsOperationsMenuStrip
            // 
            this.applicationsOperationsMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.applicationsOperationsMenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.applicationsOperationsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.applicationsOperationsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addApplication,
            this.editApplication,
            this.deleteApplication});
            this.applicationsOperationsMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.applicationsOperationsMenuStrip.Margin = new System.Windows.Forms.Padding(1);
            this.applicationsOperationsMenuStrip.Name = "applicationsOperationsMenuStrip";
            this.applicationsOperationsMenuStrip.Size = new System.Drawing.Size(1031, 24);
            this.applicationsOperationsMenuStrip.TabIndex = 0;
            this.applicationsOperationsMenuStrip.Text = "menuStrip1";
            // 
            // addApplication
            // 
            this.addApplication.Name = "addApplication";
            this.addApplication.Size = new System.Drawing.Size(132, 20);
            this.addApplication.Text = "Створити заявку";
            this.addApplication.Click += new System.EventHandler(this.addApplication_Click);
            // 
            // editApplication
            // 
            this.editApplication.Name = "editApplication";
            this.editApplication.Size = new System.Drawing.Size(96, 20);
            this.editApplication.Text = "Редагувати";
            this.editApplication.Click += new System.EventHandler(this.editApplication_Click);
            // 
            // deleteApplication
            // 
            this.deleteApplication.Name = "deleteApplication";
            this.deleteApplication.Size = new System.Drawing.Size(132, 20);
            this.deleteApplication.Text = "Видалити заявку";
            this.deleteApplication.Click += new System.EventHandler(this.deleteApplication_Click);
            // 
            // clientsPage
            // 
            this.clientsPage.BackgroundImage = global::Haberdashery_course.Properties.Resources.BD_157_Teal_1_550x5503;
            this.clientsPage.Controls.Add(this.clientsGrid);
            this.clientsPage.Controls.Add(this.clientsOperationsMenuStrip);
            this.clientsPage.Location = new System.Drawing.Point(4, 24);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsPage.Size = new System.Drawing.Size(1039, 429);
            this.clientsPage.TabIndex = 1;
            this.clientsPage.Text = "Інформація про замовників";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            this.clientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDCol,
            this.surnameCol,
            this.nameCol,
            this.fathernameCol,
            this.mailCol,
            this.phoneNumberCol});
            this.clientsGrid.Location = new System.Drawing.Point(77, 30);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersWidth = 51;
            this.clientsGrid.Size = new System.Drawing.Size(584, 196);
            this.clientsGrid.TabIndex = 1;
            this.clientsGrid.SelectionChanged += new System.EventHandler(this.clientsGrid_SelectionChanged);
            // 
            // clientIDCol
            // 
            this.clientIDCol.HeaderText = "ID";
            this.clientIDCol.MinimumWidth = 6;
            this.clientIDCol.Name = "clientIDCol";
            this.clientIDCol.ReadOnly = true;
            this.clientIDCol.Visible = false;
            this.clientIDCol.Width = 43;
            // 
            // surnameCol
            // 
            this.surnameCol.HeaderText = "Прізвище";
            this.surnameCol.MinimumWidth = 6;
            this.surnameCol.Name = "surnameCol";
            this.surnameCol.ReadOnly = true;
            this.surnameCol.Width = 87;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Ім\'я";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 54;
            // 
            // fathernameCol
            // 
            this.fathernameCol.HeaderText = "По-батькові";
            this.fathernameCol.MinimumWidth = 6;
            this.fathernameCol.Name = "fathernameCol";
            this.fathernameCol.ReadOnly = true;
            this.fathernameCol.Width = 103;
            // 
            // mailCol
            // 
            this.mailCol.HeaderText = "Електронна адреса";
            this.mailCol.MinimumWidth = 6;
            this.mailCol.Name = "mailCol";
            this.mailCol.ReadOnly = true;
            this.mailCol.Width = 133;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.HeaderText = "Номер телефону";
            this.phoneNumberCol.MinimumWidth = 6;
            this.phoneNumberCol.Name = "phoneNumberCol";
            this.phoneNumberCol.ReadOnly = true;
            this.phoneNumberCol.Width = 121;
            // 
            // clientsOperationsMenuStrip
            // 
            this.clientsOperationsMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.clientsOperationsMenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsOperationsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientsOperationsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClient,
            this.editClient,
            this.deleteClient});
            this.clientsOperationsMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.clientsOperationsMenuStrip.Name = "clientsOperationsMenuStrip";
            this.clientsOperationsMenuStrip.Size = new System.Drawing.Size(1033, 24);
            this.clientsOperationsMenuStrip.TabIndex = 0;
            this.clientsOperationsMenuStrip.Text = "menuStrip1";
            // 
            // addNewClient
            // 
            this.addNewClient.Name = "addNewClient";
            this.addNewClient.Size = new System.Drawing.Size(246, 20);
            this.addNewClient.Text = "Зареєструвати нового замовника";
            this.addNewClient.Click += new System.EventHandler(this.addNewClient_Click);
            // 
            // editClient
            // 
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(284, 20);
            this.editClient.Text = "Редагувати інформацію про замовника";
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(160, 20);
            this.deleteClient.Text = "Видалити замовника";
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // productPage
            // 
            this.productPage.BackColor = System.Drawing.Color.Transparent;
            this.productPage.BackgroundImage = global::Haberdashery_course.Properties.Resources.BD_157_Teal_1_550x5502;
            this.productPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productPage.Controls.Add(this.productsGrid);
            this.productPage.Controls.Add(this.productsOperationsMenuStrip);
            this.productPage.Location = new System.Drawing.Point(4, 24);
            this.productPage.Name = "productPage";
            this.productPage.Size = new System.Drawing.Size(1039, 429);
            this.productPage.TabIndex = 2;
            this.productPage.Text = "Інформація про вироби, що підлягають ремонту";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDCol,
            this.productNameCol,
            this.categoryCol,
            this.materialCol});
            this.productsGrid.Location = new System.Drawing.Point(109, 27);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(444, 220);
            this.productsGrid.TabIndex = 1;
            this.productsGrid.SelectionChanged += new System.EventHandler(this.productsGrid_SelectionChanged);
            // 
            // productIDCol
            // 
            this.productIDCol.HeaderText = "ID";
            this.productIDCol.MinimumWidth = 6;
            this.productIDCol.Name = "productIDCol";
            this.productIDCol.ReadOnly = true;
            this.productIDCol.Visible = false;
            this.productIDCol.Width = 43;
            // 
            // productNameCol
            // 
            this.productNameCol.HeaderText = "Назва виробу";
            this.productNameCol.MinimumWidth = 6;
            this.productNameCol.Name = "productNameCol";
            this.productNameCol.ReadOnly = true;
            this.productNameCol.Width = 111;
            // 
            // categoryCol
            // 
            this.categoryCol.HeaderText = "Категорія";
            this.categoryCol.MinimumWidth = 6;
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.ReadOnly = true;
            this.categoryCol.Width = 90;
            // 
            // materialCol
            // 
            this.materialCol.HeaderText = "Матеріал";
            this.materialCol.MinimumWidth = 6;
            this.materialCol.Name = "materialCol";
            this.materialCol.ReadOnly = true;
            this.materialCol.Width = 88;
            // 
            // productsOperationsMenuStrip
            // 
            this.productsOperationsMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.productsOperationsMenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.productsOperationsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productsOperationsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProduct,
            this.editNewProduct,
            this.deleteNewProduct,
            this.extraProductsInformation});
            this.productsOperationsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.productsOperationsMenuStrip.Name = "productsOperationsMenuStrip";
            this.productsOperationsMenuStrip.Size = new System.Drawing.Size(1039, 24);
            this.productsOperationsMenuStrip.TabIndex = 0;
            this.productsOperationsMenuStrip.Text = "menuStrip2";
            // 
            // addNewProduct
            // 
            this.addNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(204, 20);
            this.addNewProduct.Text = "Зареєструвати новий виріб";
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // editNewProduct
            // 
            this.editNewProduct.Name = "editNewProduct";
            this.editNewProduct.Size = new System.Drawing.Size(100, 20);
            this.editNewProduct.Text = "Редагувати ";
            this.editNewProduct.Click += new System.EventHandler(this.editNewProduct_Click);
            // 
            // deleteNewProduct
            // 
            this.deleteNewProduct.Name = "deleteNewProduct";
            this.deleteNewProduct.Size = new System.Drawing.Size(124, 20);
            this.deleteNewProduct.Text = "Видалити виріб";
            this.deleteNewProduct.Click += new System.EventHandler(this.deleteNewProduct_Click);
            // 
            // extraProductsInformation
            // 
            this.extraProductsInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.category,
            this.material});
            this.extraProductsInformation.Name = "extraProductsInformation";
            this.extraProductsInformation.Size = new System.Drawing.Size(174, 20);
            this.extraProductsInformation.Text = "Додаткова інформація";
            // 
            // category
            // 
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(146, 22);
            this.category.Text = "Категорії";
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // material
            // 
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(146, 22);
            this.material.Text = "Матеріали";
            this.material.Click += new System.EventHandler(this.material_Click);
            // 
            // priceList
            // 
            this.priceList.BackgroundImage = global::Haberdashery_course.Properties.Resources.BD_157_Teal_1_550x5501;
            this.priceList.Controls.Add(this.priceListGrid);
            this.priceList.Controls.Add(this.priceListMenuStrip);
            this.priceList.Location = new System.Drawing.Point(4, 24);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(1039, 429);
            this.priceList.TabIndex = 3;
            this.priceList.Text = "Прейскурант";
            this.priceList.UseVisualStyleBackColor = true;
            // 
            // priceListGrid
            // 
            this.priceListGrid.AllowUserToAddRows = false;
            this.priceListGrid.AllowUserToDeleteRows = false;
            this.priceListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.priceListGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceListIDCol,
            this.serviceName,
            this.minCost,
            this.maxCost});
            this.priceListGrid.Location = new System.Drawing.Point(73, 27);
            this.priceListGrid.Name = "priceListGrid";
            this.priceListGrid.ReadOnly = true;
            this.priceListGrid.RowHeadersWidth = 51;
            this.priceListGrid.Size = new System.Drawing.Size(526, 234);
            this.priceListGrid.TabIndex = 1;
            this.priceListGrid.SelectionChanged += new System.EventHandler(this.priceListGrid_SelectionChanged);
            // 
            // priceListIDCol
            // 
            this.priceListIDCol.HeaderText = "ID";
            this.priceListIDCol.MinimumWidth = 6;
            this.priceListIDCol.Name = "priceListIDCol";
            this.priceListIDCol.ReadOnly = true;
            this.priceListIDCol.Visible = false;
            this.priceListIDCol.Width = 43;
            // 
            // serviceName
            // 
            this.serviceName.HeaderText = "Назва послуги";
            this.serviceName.MinimumWidth = 6;
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            this.serviceName.Width = 105;
            // 
            // minCost
            // 
            this.minCost.HeaderText = "Вартість від";
            this.minCost.MinimumWidth = 6;
            this.minCost.Name = "minCost";
            this.minCost.ReadOnly = true;
            this.minCost.Width = 96;
            // 
            // maxCost
            // 
            this.maxCost.HeaderText = "Вартість до";
            this.maxCost.MinimumWidth = 6;
            this.maxCost.Name = "maxCost";
            this.maxCost.ReadOnly = true;
            this.maxCost.Width = 93;
            // 
            // priceListMenuStrip
            // 
            this.priceListMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.priceListMenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.priceListMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.priceListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addService,
            this.delService,
            this.changeServiceCost});
            this.priceListMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.priceListMenuStrip.Margin = new System.Windows.Forms.Padding(2);
            this.priceListMenuStrip.Name = "priceListMenuStrip";
            this.priceListMenuStrip.Size = new System.Drawing.Size(1039, 24);
            this.priceListMenuStrip.TabIndex = 0;
            this.priceListMenuStrip.Text = "menuStrip1";
            // 
            // addService
            // 
            this.addService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addService.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(156, 20);
            this.addService.Text = "Додати нову послугу";
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // delService
            // 
            this.delService.Name = "delService";
            this.delService.Size = new System.Drawing.Size(138, 20);
            this.delService.Text = "Прибрати послугу";
            this.delService.Click += new System.EventHandler(this.delService_Click);
            // 
            // changeServiceCost
            // 
            this.changeServiceCost.Name = "changeServiceCost";
            this.changeServiceCost.Size = new System.Drawing.Size(192, 20);
            this.changeServiceCost.Text = "Змінити вартість послуги";
            this.changeServiceCost.Click += new System.EventHandler(this.changeServiceCost_Click);
            // 
            // WorkingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1027, 432);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.applicationsOperationsMenuStrip;
            this.MaximizeBox = false;
            this.Name = "WorkingPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель адміністратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkingPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkingPanel_FormClosed);
            this.Load += new System.EventHandler(this.WorkingPanel_Load);
            this.Menu.ResumeLayout(false);
            this.applicationsPage.ResumeLayout(false);
            this.applicationsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsGrid)).EndInit();
            this.contextApplicationsMenu.ResumeLayout(false);
            this.applicationsOperationsMenuStrip.ResumeLayout(false);
            this.applicationsOperationsMenuStrip.PerformLayout();
            this.clientsPage.ResumeLayout(false);
            this.clientsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.clientsOperationsMenuStrip.ResumeLayout(false);
            this.clientsOperationsMenuStrip.PerformLayout();
            this.productPage.ResumeLayout(false);
            this.productPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.productsOperationsMenuStrip.ResumeLayout(false);
            this.productsOperationsMenuStrip.PerformLayout();
            this.priceList.ResumeLayout(false);
            this.priceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListGrid)).EndInit();
            this.priceListMenuStrip.ResumeLayout(false);
            this.priceListMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage applicationsPage;
        private System.Windows.Forms.MenuStrip applicationsOperationsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addApplication;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.ToolStripMenuItem editApplication;
        private System.Windows.Forms.DataGridView applicationsGrid;
        private System.Windows.Forms.MenuStrip clientsOperationsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewClient;
        private System.Windows.Forms.ToolStripMenuItem editClient;
        private System.Windows.Forms.ToolStripMenuItem deleteClient;
        private System.Windows.Forms.MenuStrip productsOperationsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewProduct;
        private System.Windows.Forms.ToolStripMenuItem editNewProduct;
        private System.Windows.Forms.ToolStripMenuItem deleteNewProduct;
        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.ToolStripMenuItem extraProductsInformation;
        private System.Windows.Forms.TabPage priceList;
        private System.Windows.Forms.MenuStrip priceListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addService;
        private System.Windows.Forms.ToolStripMenuItem delService;
        private System.Windows.Forms.ToolStripMenuItem changeServiceCost;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridView priceListGrid;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem material;
        private System.Windows.Forms.ContextMenuStrip contextApplicationsMenu;
        private System.Windows.Forms.ToolStripMenuItem закритиЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceListIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCost;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.TextBox searchSurnameTextBox;
        private System.Windows.Forms.Button canselSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfApplictionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateCol;
    }
}