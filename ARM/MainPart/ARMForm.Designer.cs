namespace ARM.MainPart
{
    partial class ArmForm
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
            this.interfacePanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.changeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.standardQueriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.recentEthnoOrgsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.upToDateLangInfoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.userStrip = new System.Windows.Forms.StatusStrip();
            this.userLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.userRoleStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablesControl = new System.Windows.Forms.TabControl();
            this.ethnoPage = new System.Windows.Forms.TabPage();
            this.ethnoOrgsDGV = new System.Windows.Forms.DataGridView();
            this.langCountPage = new System.Windows.Forms.TabPage();
            this.langsCountDGV = new System.Windows.Forms.DataGridView();
            this.langsPage = new System.Windows.Forms.TabPage();
            this.langsDGV = new System.Windows.Forms.DataGridView();
            this.langFamsPage = new System.Windows.Forms.TabPage();
            this.langFamsDGV = new System.Windows.Forms.DataGridView();
            this.EthnoOrgIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EthnoOrgNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EthnoOrgHQColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EthnoOrgDateColumn = new CalendarColumn.CalendarColumn();
            this.числоносителейязыковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnoOrgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EthnoColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LangColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.langsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateColumn = new CalendarColumn.CalendarColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этнографическиеорганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langsCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LangIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangsFamColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.langFamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.числоносителейязыковDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языковыесемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangFamIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangFamNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangFamMacroColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.langMacroFamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.языкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языковыемакросемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interfacePanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.userStrip.SuspendLayout();
            this.tablesControl.SuspendLayout();
            this.ethnoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethnoOrgsDGV)).BeginInit();
            this.langCountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.langsCountDGV)).BeginInit();
            this.langsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.langsDGV)).BeginInit();
            this.langFamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.langFamsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethnoOrgsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langsCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langFamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langMacroFamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // interfacePanel
            // 
            this.interfacePanel.ColumnCount = 1;
            this.interfacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.interfacePanel.Controls.Add(this.mainMenu, 0, 0);
            this.interfacePanel.Controls.Add(this.userStrip, 0, 2);
            this.interfacePanel.Controls.Add(this.tablesControl, 0, 1);
            this.interfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interfacePanel.Location = new System.Drawing.Point(0, 0);
            this.interfacePanel.Name = "interfacePanel";
            this.interfacePanel.RowCount = 3;
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.interfacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.interfacePanel.Size = new System.Drawing.Size(1008, 729);
            this.interfacePanel.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUser,
            this.standardQueriesButton,
            this.usersManagement});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 21);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // changeUser
            // 
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(157, 17);
            this.changeUser.Text = "Сменить учётную запись";
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // standardQueriesButton
            // 
            this.standardQueriesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentEthnoOrgsButton,
            this.upToDateLangInfoButton});
            this.standardQueriesButton.Name = "standardQueriesButton";
            this.standardQueriesButton.Size = new System.Drawing.Size(205, 17);
            this.standardQueriesButton.Text = "Стандартные поисковые запросы";
            // 
            // recentEthnoOrgsButton
            // 
            this.recentEthnoOrgsButton.Name = "recentEthnoOrgsButton";
            this.recentEthnoOrgsButton.Size = new System.Drawing.Size(431, 22);
            this.recentEthnoOrgsButton.Text = "Зарегестрированные в этом году этнографические организации";
            this.recentEthnoOrgsButton.Click += new System.EventHandler(this.recentEthnoOrgsButton_Click);
            // 
            // upToDateLangInfoButton
            // 
            this.upToDateLangInfoButton.Name = "upToDateLangInfoButton";
            this.upToDateLangInfoButton.Size = new System.Drawing.Size(431, 22);
            this.upToDateLangInfoButton.Text = "Актуальная информация об известных языках мира";
            this.upToDateLangInfoButton.Click += new System.EventHandler(this.upToDateLangInfoButton_Click);
            // 
            // usersManagement
            // 
            this.usersManagement.Name = "usersManagement";
            this.usersManagement.Size = new System.Drawing.Size(200, 17);
            this.usersManagement.Text = "Управление учётными записями";
            this.usersManagement.Click += new System.EventHandler(this.usersManagement_Click);
            // 
            // userStrip
            // 
            this.userStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginStatus,
            this.userRoleStatus});
            this.userStrip.Location = new System.Drawing.Point(0, 707);
            this.userStrip.Name = "userStrip";
            this.userStrip.Size = new System.Drawing.Size(1008, 22);
            this.userStrip.TabIndex = 0;
            this.userStrip.Text = "statusStrip1";
            // 
            // userLoginStatus
            // 
            this.userLoginStatus.Name = "userLoginStatus";
            this.userLoginStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // userRoleStatus
            // 
            this.userRoleStatus.Name = "userRoleStatus";
            this.userRoleStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tablesControl
            // 
            this.tablesControl.Controls.Add(this.ethnoPage);
            this.tablesControl.Controls.Add(this.langCountPage);
            this.tablesControl.Controls.Add(this.langsPage);
            this.tablesControl.Controls.Add(this.langFamsPage);
            this.tablesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesControl.Location = new System.Drawing.Point(3, 24);
            this.tablesControl.Name = "tablesControl";
            this.tablesControl.SelectedIndex = 0;
            this.tablesControl.Size = new System.Drawing.Size(1002, 679);
            this.tablesControl.TabIndex = 2;
            // 
            // ethnoPage
            // 
            this.ethnoPage.Controls.Add(this.ethnoOrgsDGV);
            this.ethnoPage.Location = new System.Drawing.Point(4, 30);
            this.ethnoPage.Name = "ethnoPage";
            this.ethnoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ethnoPage.Size = new System.Drawing.Size(994, 645);
            this.ethnoPage.TabIndex = 0;
            this.ethnoPage.Text = "Этнографические организации";
            this.ethnoPage.UseVisualStyleBackColor = true;
            // 
            // ethnoOrgsDGV
            // 
            this.ethnoOrgsDGV.AutoGenerateColumns = false;
            this.ethnoOrgsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ethnoOrgsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ethnoOrgsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ethnoOrgsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EthnoOrgIDColumn,
            this.EthnoOrgNameColumn,
            this.EthnoOrgHQColumn,
            this.EthnoOrgDateColumn,
            this.числоносителейязыковDataGridViewTextBoxColumn});
            this.ethnoOrgsDGV.DataSource = this.ethnoOrgsBindingSource;
            this.ethnoOrgsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ethnoOrgsDGV.Location = new System.Drawing.Point(3, 3);
            this.ethnoOrgsDGV.Name = "ethnoOrgsDGV";
            this.ethnoOrgsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ethnoOrgsDGV.Size = new System.Drawing.Size(988, 639);
            this.ethnoOrgsDGV.TabIndex = 0;
            this.ethnoOrgsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ethnoOrgDGV_CellValueChanged);
            this.ethnoOrgsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ethnoOrgDGV_DataBindingComplete);
            this.ethnoOrgsDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ethnoOrgDGV_RowValidating);
            this.ethnoOrgsDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ethnoOrgDGV_UserDeletingRow);
            // 
            // langCountPage
            // 
            this.langCountPage.Controls.Add(this.langsCountDGV);
            this.langCountPage.Location = new System.Drawing.Point(4, 30);
            this.langCountPage.Name = "langCountPage";
            this.langCountPage.Padding = new System.Windows.Forms.Padding(3);
            this.langCountPage.Size = new System.Drawing.Size(994, 645);
            this.langCountPage.TabIndex = 1;
            this.langCountPage.Text = "Число носителей языков";
            this.langCountPage.UseVisualStyleBackColor = true;
            // 
            // langsCountDGV
            // 
            this.langsCountDGV.AutoGenerateColumns = false;
            this.langsCountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.langsCountDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.langsCountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langsCountDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EthnoColumn,
            this.LangColumn,
            this.DateColumn,
            this.CountColumn,
            this.этнографическиеорганизацииDataGridViewTextBoxColumn,
            this.LangsColumn});
            this.langsCountDGV.DataSource = this.langsCountBindingSource;
            this.langsCountDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langsCountDGV.Location = new System.Drawing.Point(3, 3);
            this.langsCountDGV.Name = "langsCountDGV";
            this.langsCountDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.langsCountDGV.Size = new System.Drawing.Size(988, 647);
            this.langsCountDGV.TabIndex = 0;
            this.langsCountDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.langsCountDGV_CellValueChanged);
            this.langsCountDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.langsCountDGV_DataBindingComplete);
            this.langsCountDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.langsCountDGV_RowValidating);
            this.langsCountDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.langsCountDGV_UserDeletingRow);
            // 
            // langsPage
            // 
            this.langsPage.Controls.Add(this.langsDGV);
            this.langsPage.Location = new System.Drawing.Point(4, 30);
            this.langsPage.Name = "langsPage";
            this.langsPage.Size = new System.Drawing.Size(994, 645);
            this.langsPage.TabIndex = 2;
            this.langsPage.Text = "Языки";
            this.langsPage.UseVisualStyleBackColor = true;
            // 
            // langsDGV
            // 
            this.langsDGV.AutoGenerateColumns = false;
            this.langsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.langsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.langsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LangIDColumn,
            this.LangNameColumn,
            this.LangsFamColumn,
            this.числоносителейязыковDataGridViewTextBoxColumn1,
            this.языковыесемьиDataGridViewTextBoxColumn});
            this.langsDGV.DataSource = this.langsBindingSource;
            this.langsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langsDGV.Location = new System.Drawing.Point(0, 0);
            this.langsDGV.Name = "langsDGV";
            this.langsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.langsDGV.Size = new System.Drawing.Size(994, 653);
            this.langsDGV.TabIndex = 0;
            this.langsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.langsDGV_CellValueChanged);
            this.langsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.langsDGV_DataBindingComplete);
            this.langsDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.langsDGV_RowValidating);
            this.langsDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.langsDGV_UserDeletingRow);
            // 
            // langFamsPage
            // 
            this.langFamsPage.Controls.Add(this.langFamsDGV);
            this.langFamsPage.Location = new System.Drawing.Point(4, 30);
            this.langFamsPage.Name = "langFamsPage";
            this.langFamsPage.Size = new System.Drawing.Size(994, 645);
            this.langFamsPage.TabIndex = 3;
            this.langFamsPage.Text = "Языковые семьи";
            this.langFamsPage.UseVisualStyleBackColor = true;
            // 
            // langFamsDGV
            // 
            this.langFamsDGV.AutoGenerateColumns = false;
            this.langFamsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.langFamsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.langFamsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langFamsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LangFamIDColumn,
            this.LangFamNameColumn,
            this.LangFamMacroColumn,
            this.языкиDataGridViewTextBoxColumn1,
            this.языковыемакросемьиDataGridViewTextBoxColumn});
            this.langFamsDGV.DataSource = this.langFamsBindingSource;
            this.langFamsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langFamsDGV.Location = new System.Drawing.Point(0, 0);
            this.langFamsDGV.Name = "langFamsDGV";
            this.langFamsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.langFamsDGV.Size = new System.Drawing.Size(994, 645);
            this.langFamsDGV.TabIndex = 0;
            this.langFamsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.langFamsDGV_CellValueChanged);
            this.langFamsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.langFamsDGV_DataBindingComplete);
            this.langFamsDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.langFamsDGV_RowValidating);
            this.langFamsDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.langFamsDGV_UserDeletingRow);
            // 
            // EthnoOrgIDColumn
            // 
            this.EthnoOrgIDColumn.DataPropertyName = "ID";
            this.EthnoOrgIDColumn.HeaderText = "ID";
            this.EthnoOrgIDColumn.Name = "EthnoOrgIDColumn";
            this.EthnoOrgIDColumn.Visible = false;
            // 
            // EthnoOrgNameColumn
            // 
            this.EthnoOrgNameColumn.DataPropertyName = "Название";
            this.EthnoOrgNameColumn.HeaderText = "Название";
            this.EthnoOrgNameColumn.Name = "EthnoOrgNameColumn";
            // 
            // EthnoOrgHQColumn
            // 
            this.EthnoOrgHQColumn.DataPropertyName = "Штаб_квартира";
            this.EthnoOrgHQColumn.HeaderText = "Штаб-квартира";
            this.EthnoOrgHQColumn.Name = "EthnoOrgHQColumn";
            // 
            // EthnoOrgDateColumn
            // 
            this.EthnoOrgDateColumn.DataPropertyName = "Дата_основания";
            this.EthnoOrgDateColumn.HeaderText = "Дата основания";
            this.EthnoOrgDateColumn.Name = "EthnoOrgDateColumn";
            this.EthnoOrgDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EthnoOrgDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // числоносителейязыковDataGridViewTextBoxColumn
            // 
            this.числоносителейязыковDataGridViewTextBoxColumn.DataPropertyName = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn.HeaderText = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn.Name = "числоносителейязыковDataGridViewTextBoxColumn";
            this.числоносителейязыковDataGridViewTextBoxColumn.Visible = false;
            // 
            // ethnoOrgsBindingSource
            // 
            this.ethnoOrgsBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Этнографические_организации);
            // 
            // EthnoColumn
            // 
            this.EthnoColumn.DataPropertyName = "ID_организации__производившей_подсчет";
            this.EthnoColumn.DataSource = this.ethnoOrgsBindingSource;
            this.EthnoColumn.DisplayMember = "Название";
            this.EthnoColumn.HeaderText = "Организация, производившая подсчёт";
            this.EthnoColumn.Name = "EthnoColumn";
            this.EthnoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EthnoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EthnoColumn.ValueMember = "ID";
            // 
            // LangColumn
            // 
            this.LangColumn.DataPropertyName = "ID_языка";
            this.LangColumn.DataSource = this.langsBindingSource;
            this.LangColumn.DisplayMember = "Название";
            this.LangColumn.HeaderText = "Язык";
            this.LangColumn.Name = "LangColumn";
            this.LangColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LangColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LangColumn.ValueMember = "ID";
            // 
            // langsBindingSource
            // 
            this.langsBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Языки);
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Дата_подсчёта";
            this.DateColumn.HeaderText = "Дата подсчёта";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CountColumn
            // 
            this.CountColumn.DataPropertyName = "Число_носителей";
            this.CountColumn.HeaderText = "Число носителей";
            this.CountColumn.Name = "CountColumn";
            // 
            // этнографическиеорганизацииDataGridViewTextBoxColumn
            // 
            this.этнографическиеорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Этнографические_организации";
            this.этнографическиеорганизацииDataGridViewTextBoxColumn.HeaderText = "Этнографические_организации";
            this.этнографическиеорганизацииDataGridViewTextBoxColumn.Name = "этнографическиеорганизацииDataGridViewTextBoxColumn";
            this.этнографическиеорганизацииDataGridViewTextBoxColumn.Visible = false;
            // 
            // LangsColumn
            // 
            this.LangsColumn.DataPropertyName = "Языки";
            this.LangsColumn.HeaderText = "Языки";
            this.LangsColumn.Name = "LangsColumn";
            this.LangsColumn.Visible = false;
            // 
            // langsCountBindingSource
            // 
            this.langsCountBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Число_носителей_языков);
            // 
            // LangIDColumn
            // 
            this.LangIDColumn.DataPropertyName = "ID";
            this.LangIDColumn.HeaderText = "ID";
            this.LangIDColumn.Name = "LangIDColumn";
            this.LangIDColumn.Visible = false;
            // 
            // LangNameColumn
            // 
            this.LangNameColumn.DataPropertyName = "Название";
            this.LangNameColumn.HeaderText = "Название";
            this.LangNameColumn.Name = "LangNameColumn";
            // 
            // LangsFamColumn
            // 
            this.LangsFamColumn.DataPropertyName = "ID_языковой_семьи";
            this.LangsFamColumn.DataSource = this.langFamsBindingSource;
            this.LangsFamColumn.DisplayMember = "Название";
            this.LangsFamColumn.HeaderText = "Языковая семья";
            this.LangsFamColumn.Name = "LangsFamColumn";
            this.LangsFamColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LangsFamColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LangsFamColumn.ValueMember = "ID";
            // 
            // langFamsBindingSource
            // 
            this.langFamsBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Языковые_семьи);
            // 
            // числоносителейязыковDataGridViewTextBoxColumn1
            // 
            this.числоносителейязыковDataGridViewTextBoxColumn1.DataPropertyName = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn1.HeaderText = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn1.Name = "числоносителейязыковDataGridViewTextBoxColumn1";
            this.числоносителейязыковDataGridViewTextBoxColumn1.Visible = false;
            // 
            // языковыесемьиDataGridViewTextBoxColumn
            // 
            this.языковыесемьиDataGridViewTextBoxColumn.DataPropertyName = "Языковые_семьи";
            this.языковыесемьиDataGridViewTextBoxColumn.HeaderText = "Языковые_семьи";
            this.языковыесемьиDataGridViewTextBoxColumn.Name = "языковыесемьиDataGridViewTextBoxColumn";
            this.языковыесемьиDataGridViewTextBoxColumn.Visible = false;
            // 
            // LangFamIDColumn
            // 
            this.LangFamIDColumn.DataPropertyName = "ID";
            this.LangFamIDColumn.HeaderText = "ID";
            this.LangFamIDColumn.Name = "LangFamIDColumn";
            this.LangFamIDColumn.Visible = false;
            // 
            // LangFamNameColumn
            // 
            this.LangFamNameColumn.DataPropertyName = "Название";
            this.LangFamNameColumn.HeaderText = "Название";
            this.LangFamNameColumn.Name = "LangFamNameColumn";
            // 
            // LangFamMacroColumn
            // 
            this.LangFamMacroColumn.DataPropertyName = "ID_языковой_макросемьи";
            this.LangFamMacroColumn.DataSource = this.langMacroFamsBindingSource;
            this.LangFamMacroColumn.DisplayMember = "Название";
            this.LangFamMacroColumn.HeaderText = "Языковая макросемья";
            this.LangFamMacroColumn.Name = "LangFamMacroColumn";
            this.LangFamMacroColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LangFamMacroColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LangFamMacroColumn.ValueMember = "ID";
            // 
            // langMacroFamsBindingSource
            // 
            this.langMacroFamsBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Языковые_макросемьи);
            // 
            // языкиDataGridViewTextBoxColumn1
            // 
            this.языкиDataGridViewTextBoxColumn1.DataPropertyName = "Языки";
            this.языкиDataGridViewTextBoxColumn1.HeaderText = "Языки";
            this.языкиDataGridViewTextBoxColumn1.Name = "языкиDataGridViewTextBoxColumn1";
            this.языкиDataGridViewTextBoxColumn1.Visible = false;
            // 
            // языковыемакросемьиDataGridViewTextBoxColumn
            // 
            this.языковыемакросемьиDataGridViewTextBoxColumn.DataPropertyName = "Языковые_макросемьи";
            this.языковыемакросемьиDataGridViewTextBoxColumn.HeaderText = "Языковые_макросемьи";
            this.языковыемакросемьиDataGridViewTextBoxColumn.Name = "языковыемакросемьиDataGridViewTextBoxColumn";
            this.языковыемакросемьиDataGridViewTextBoxColumn.Visible = false;
            // 
            // ArmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.interfacePanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ArmForm";
            this.Text = "Автоматизированное рабочее место \"Лингвист\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArmForm_FormClosing);
            this.Load += new System.EventHandler(this.ARMForm_Load);
            this.interfacePanel.ResumeLayout(false);
            this.interfacePanel.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.userStrip.ResumeLayout(false);
            this.userStrip.PerformLayout();
            this.tablesControl.ResumeLayout(false);
            this.ethnoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ethnoOrgsDGV)).EndInit();
            this.langCountPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.langsCountDGV)).EndInit();
            this.langsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.langsDGV)).EndInit();
            this.langFamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.langFamsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethnoOrgsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langsCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langFamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langMacroFamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel interfacePanel;
        private System.Windows.Forms.StatusStrip userStrip;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem changeUser;
        private System.Windows.Forms.TabControl tablesControl;
        private System.Windows.Forms.TabPage ethnoPage;
        private System.Windows.Forms.TabPage langCountPage;
        private System.Windows.Forms.TabPage langsPage;
        private System.Windows.Forms.TabPage langFamsPage;
        private System.Windows.Forms.DataGridView ethnoOrgsDGV;
        private System.Windows.Forms.BindingSource ethnoOrgsBindingSource;
        private System.Windows.Forms.DataGridView langsCountDGV;
        private System.Windows.Forms.BindingSource langsBindingSource;
        private System.Windows.Forms.BindingSource langsCountBindingSource;
        private System.Windows.Forms.DataGridView langsDGV;
        private System.Windows.Forms.BindingSource langFamsBindingSource;
        private System.Windows.Forms.DataGridView langFamsDGV;
        private System.Windows.Forms.BindingSource langMacroFamsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem usersManagement;
        private System.Windows.Forms.ToolStripStatusLabel userLoginStatus;
        private System.Windows.Forms.ToolStripStatusLabel userRoleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangFamIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangFamNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn LangFamMacroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn языковыемакросемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EthnoOrgIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EthnoOrgNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EthnoOrgHQColumn;
        private CalendarColumn.CalendarColumn EthnoOrgDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоносителейязыковDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn EthnoColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn LangColumn;
        private CalendarColumn.CalendarColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этнографическиеорганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangsColumn;
        private System.Windows.Forms.ToolStripMenuItem standardQueriesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn LangsFamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоносителейязыковDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn языковыесемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem recentEthnoOrgsButton;
        private System.Windows.Forms.ToolStripMenuItem upToDateLangInfoButton;
    }
}