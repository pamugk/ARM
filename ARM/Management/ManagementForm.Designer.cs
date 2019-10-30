namespace ARM.Management
{
    partial class ManagementForm
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.userContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.adminStatusStrip = new System.Windows.Forms.StatusStrip();
            this.userLoginLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaltColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdminColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RegDateColumn = new CalendarColumn.CalendarColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.userContextMenu.SuspendLayout();
            this.adminStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.usersDGV, 0, 0);
            this.mainPanel.Controls.Add(this.adminStatusStrip, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.mainPanel.Size = new System.Drawing.Size(1008, 729);
            this.mainPanel.TabIndex = 0;
            // 
            // usersDGV
            // 
            this.usersDGV.AutoGenerateColumns = false;
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDColumn,
            this.LoginColumn,
            this.HashColumn,
            this.SaltColumn,
            this.IsAdminColumn,
            this.RegDateColumn});
            this.usersDGV.ContextMenuStrip = this.userContextMenu;
            this.usersDGV.DataSource = this.пользователиBindingSource;
            this.usersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDGV.Location = new System.Drawing.Point(3, 3);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(1002, 701);
            this.usersDGV.TabIndex = 3;
            this.usersDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDGV_CellValueChanged);
            this.usersDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDGV_DataBindingComplete);
            this.usersDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.usersDGV_RowValidating);
            this.usersDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.usersDGV_UserDeletingRow);
            // 
            // userContextMenu
            // 
            this.userContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassword});
            this.userContextMenu.Name = "userContextMenu";
            this.userContextMenu.Size = new System.Drawing.Size(173, 26);
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(172, 22);
            this.changePassword.Text = "Поменять пароль";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // adminStatusStrip
            // 
            this.adminStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginLabel});
            this.adminStatusStrip.Location = new System.Drawing.Point(0, 707);
            this.adminStatusStrip.Name = "adminStatusStrip";
            this.adminStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.adminStatusStrip.TabIndex = 4;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(89, 17);
            this.userLoginLabel.Text = "Вы зашли как: ";
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.DataPropertyName = "ID";
            this.UserIDColumn.HeaderText = "ID";
            this.UserIDColumn.Name = "UserIDColumn";
            this.UserIDColumn.Visible = false;
            // 
            // LoginColumn
            // 
            this.LoginColumn.DataPropertyName = "Логин";
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            // 
            // HashColumn
            // 
            this.HashColumn.DataPropertyName = "Хэш_пароля";
            this.HashColumn.HeaderText = "Хэш_пароля";
            this.HashColumn.Name = "HashColumn";
            this.HashColumn.Visible = false;
            // 
            // SaltColumn
            // 
            this.SaltColumn.DataPropertyName = "Соль";
            this.SaltColumn.HeaderText = "Соль";
            this.SaltColumn.Name = "SaltColumn";
            this.SaltColumn.Visible = false;
            // 
            // IsAdminColumn
            // 
            this.IsAdminColumn.DataPropertyName = "Администратор";
            this.IsAdminColumn.HeaderText = "Администратор";
            this.IsAdminColumn.Name = "IsAdminColumn";
            // 
            // RegDateColumn
            // 
            this.RegDateColumn.DataPropertyName = "Дата_регистрации";
            this.RegDateColumn.HeaderText = "Дата регистрации";
            this.RegDateColumn.Name = "RegDateColumn";
            this.RegDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataSource = typeof(ARM.UsersDBModel.Пользователи);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainPanel);
            this.Name = "ManagementForm";
            this.Text = "Система управления учётными записями АРМ \"Лингвист\"";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.userContextMenu.ResumeLayout(false);
            this.adminStatusStrip.ResumeLayout(false);
            this.adminStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private System.Windows.Forms.StatusStrip adminStatusStrip;
        private System.Windows.Forms.ContextMenuStrip userContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaltColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdminColumn;
        private CalendarColumn.CalendarColumn RegDateColumn;
        private System.Windows.Forms.ToolStripStatusLabel userLoginLabel;
    }
}