namespace ARM.Authentication
{
    partial class AuthenticationForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.secondTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.auxillaryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.enterButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.finishButton = new System.Windows.Forms.Button();
            this.forgotPasswordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.helpButton = new System.Windows.Forms.Button();
            this.registrationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.changeModeButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.userPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.guestPanel = new System.Windows.Forms.TableLayoutPanel();
            this.guestCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainTableLayout.SuspendLayout();
            this.secondTableLayout.SuspendLayout();
            this.auxillaryTableLayout.SuspendLayout();
            this.enterButtonTableLayout.SuspendLayout();
            this.forgotPasswordTableLayout.SuspendLayout();
            this.registrationTableLayout.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.loginTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.passwordTableLayout.SuspendLayout();
            this.guestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainTableLayout.ColumnCount = 3;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayout.Controls.Add(this.secondTableLayout, 1, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayout.Size = new System.Drawing.Size(624, 441);
            this.mainTableLayout.TabIndex = 0;
            // 
            // secondTableLayout
            // 
            this.secondTableLayout.ColumnCount = 1;
            this.secondTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.secondTableLayout.Controls.Add(this.headlineLabel, 0, 0);
            this.secondTableLayout.Controls.Add(this.auxillaryTableLayout, 0, 3);
            this.secondTableLayout.Controls.Add(this.userPanel, 0, 1);
            this.secondTableLayout.Controls.Add(this.guestPanel, 0, 2);
            this.secondTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondTableLayout.Location = new System.Drawing.Point(34, 25);
            this.secondTableLayout.Name = "secondTableLayout";
            this.secondTableLayout.RowCount = 4;
            this.secondTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.secondTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.secondTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.secondTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.secondTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.secondTableLayout.Size = new System.Drawing.Size(555, 390);
            this.secondTableLayout.TabIndex = 0;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headlineLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headlineLabel.Location = new System.Drawing.Point(3, 0);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(549, 87);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // auxillaryTableLayout
            // 
            this.auxillaryTableLayout.ColumnCount = 1;
            this.auxillaryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.auxillaryTableLayout.Controls.Add(this.enterButtonTableLayout, 0, 1);
            this.auxillaryTableLayout.Controls.Add(this.forgotPasswordTableLayout, 0, 2);
            this.auxillaryTableLayout.Controls.Add(this.registrationTableLayout, 0, 3);
            this.auxillaryTableLayout.Controls.Add(this.loginTextBox, 0, 0);
            this.auxillaryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auxillaryTableLayout.Location = new System.Drawing.Point(3, 235);
            this.auxillaryTableLayout.Name = "auxillaryTableLayout";
            this.auxillaryTableLayout.RowCount = 5;
            this.auxillaryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.auxillaryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.auxillaryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.auxillaryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.auxillaryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.auxillaryTableLayout.Size = new System.Drawing.Size(549, 152);
            this.auxillaryTableLayout.TabIndex = 7;
            // 
            // enterButtonTableLayout
            // 
            this.enterButtonTableLayout.ColumnCount = 3;
            this.enterButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.enterButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.enterButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.enterButtonTableLayout.Controls.Add(this.finishButton, 1, 0);
            this.enterButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterButtonTableLayout.Location = new System.Drawing.Point(3, 10);
            this.enterButtonTableLayout.Name = "enterButtonTableLayout";
            this.enterButtonTableLayout.RowCount = 1;
            this.enterButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.enterButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.enterButtonTableLayout.Size = new System.Drawing.Size(543, 39);
            this.enterButtonTableLayout.TabIndex = 1;
            // 
            // finishButton
            // 
            this.finishButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishButton.Enabled = false;
            this.finishButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishButton.Location = new System.Drawing.Point(111, 3);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(319, 33);
            this.finishButton.TabIndex = 1;
            this.finishButton.UseVisualStyleBackColor = true;
            // 
            // forgotPasswordTableLayout
            // 
            this.forgotPasswordTableLayout.ColumnCount = 3;
            this.forgotPasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.forgotPasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.forgotPasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.forgotPasswordTableLayout.Controls.Add(this.helpButton, 1, 0);
            this.forgotPasswordTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPasswordTableLayout.Location = new System.Drawing.Point(3, 55);
            this.forgotPasswordTableLayout.Name = "forgotPasswordTableLayout";
            this.forgotPasswordTableLayout.RowCount = 1;
            this.forgotPasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.forgotPasswordTableLayout.Size = new System.Drawing.Size(543, 39);
            this.forgotPasswordTableLayout.TabIndex = 2;
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(111, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(319, 33);
            this.helpButton.TabIndex = 2;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // registrationTableLayout
            // 
            this.registrationTableLayout.ColumnCount = 4;
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.registrationTableLayout.Controls.Add(this.changeModeButton, 2, 0);
            this.registrationTableLayout.Controls.Add(this.questionLabel, 1, 0);
            this.registrationTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationTableLayout.Location = new System.Drawing.Point(3, 100);
            this.registrationTableLayout.Name = "registrationTableLayout";
            this.registrationTableLayout.RowCount = 1;
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registrationTableLayout.Size = new System.Drawing.Size(543, 39);
            this.registrationTableLayout.TabIndex = 3;
            // 
            // changeModeButton
            // 
            this.changeModeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeModeButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeModeButton.Location = new System.Drawing.Point(274, 3);
            this.changeModeButton.Name = "changeModeButton";
            this.changeModeButton.Size = new System.Drawing.Size(211, 33);
            this.changeModeButton.TabIndex = 3;
            this.changeModeButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(57, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(211, 39);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(3, 3);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(268, 35);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.WordWrap = false;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // userPanel
            // 
            this.userPanel.ColumnCount = 1;
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userPanel.Controls.Add(this.loginTableLayout, 0, 0);
            this.userPanel.Controls.Add(this.passwordTableLayout, 0, 1);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(3, 90);
            this.userPanel.Name = "userPanel";
            this.userPanel.RowCount = 2;
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.Size = new System.Drawing.Size(549, 91);
            this.userPanel.TabIndex = 8;
            // 
            // loginTableLayout
            // 
            this.loginTableLayout.ColumnCount = 3;
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginTableLayout.Controls.Add(this.loginLabel, 0, 0);
            this.loginTableLayout.Controls.Add(this.usersComboBox, 1, 0);
            this.loginTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTableLayout.Location = new System.Drawing.Point(3, 3);
            this.loginTableLayout.Name = "loginTableLayout";
            this.loginTableLayout.RowCount = 1;
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginTableLayout.Size = new System.Drawing.Size(543, 39);
            this.loginTableLayout.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(3, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(211, 39);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersComboBox
            // 
            this.usersComboBox.DataSource = this.пользователиBindingSource;
            this.usersComboBox.DisplayMember = "Логин";
            this.usersComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(220, 3);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(265, 35);
            this.usersComboBox.TabIndex = 1;
            this.usersComboBox.ValueMember = "ID";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataSource = typeof(ARM.UsersDBModel.Пользователи);
            // 
            // passwordTableLayout
            // 
            this.passwordTableLayout.ColumnCount = 3;
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.passwordTableLayout.Controls.Add(this.passwordTextBox, 1, 0);
            this.passwordTableLayout.Controls.Add(this.passwordLabel, 0, 0);
            this.passwordTableLayout.Controls.Add(this.showPasswordButton, 2, 0);
            this.passwordTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTableLayout.Location = new System.Drawing.Point(3, 48);
            this.passwordTableLayout.Name = "passwordTableLayout";
            this.passwordTableLayout.RowCount = 1;
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordTableLayout.Size = new System.Drawing.Size(543, 40);
            this.passwordTableLayout.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(220, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(265, 35);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.WordWrap = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(211, 40);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPasswordButton.Location = new System.Drawing.Point(491, 3);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(49, 34);
            this.showPasswordButton.TabIndex = 0;
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // guestPanel
            // 
            this.guestPanel.ColumnCount = 3;
            this.guestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.guestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guestPanel.Controls.Add(this.guestCheckBox, 1, 0);
            this.guestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestPanel.Location = new System.Drawing.Point(3, 187);
            this.guestPanel.Name = "guestPanel";
            this.guestPanel.RowCount = 1;
            this.guestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.guestPanel.Size = new System.Drawing.Size(549, 42);
            this.guestPanel.TabIndex = 9;
            // 
            // guestCheckBox
            // 
            this.guestCheckBox.AutoSize = true;
            this.guestCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestCheckBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestCheckBox.Location = new System.Drawing.Point(112, 3);
            this.guestCheckBox.Name = "guestCheckBox";
            this.guestCheckBox.Size = new System.Drawing.Size(323, 36);
            this.guestCheckBox.TabIndex = 0;
            this.guestCheckBox.Text = "Произвести гостевой вход";
            this.guestCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guestCheckBox.UseVisualStyleBackColor = true;
            this.guestCheckBox.CheckedChanged += new System.EventHandler(this.guestCheckBox_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "AuthenticationForm";
            this.ShowIcon = false;
            this.mainTableLayout.ResumeLayout(false);
            this.secondTableLayout.ResumeLayout(false);
            this.secondTableLayout.PerformLayout();
            this.auxillaryTableLayout.ResumeLayout(false);
            this.auxillaryTableLayout.PerformLayout();
            this.enterButtonTableLayout.ResumeLayout(false);
            this.forgotPasswordTableLayout.ResumeLayout(false);
            this.registrationTableLayout.ResumeLayout(false);
            this.registrationTableLayout.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.loginTableLayout.ResumeLayout(false);
            this.loginTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.passwordTableLayout.ResumeLayout(false);
            this.passwordTableLayout.PerformLayout();
            this.guestPanel.ResumeLayout(false);
            this.guestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel secondTableLayout;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.TableLayoutPanel auxillaryTableLayout;
        private System.Windows.Forms.TableLayoutPanel enterButtonTableLayout;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TableLayoutPanel forgotPasswordTableLayout;
        private System.Windows.Forms.TableLayoutPanel registrationTableLayout;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private System.Windows.Forms.TableLayoutPanel userPanel;
        private System.Windows.Forms.TableLayoutPanel loginTableLayout;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button changeModeButton;
        private System.Windows.Forms.TableLayoutPanel passwordTableLayout;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.TableLayoutPanel guestPanel;
        private System.Windows.Forms.CheckBox guestCheckBox;
    }
}