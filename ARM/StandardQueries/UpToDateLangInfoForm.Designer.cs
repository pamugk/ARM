namespace ARM.StandardQueries
{
    partial class UpToDateLangInfoForm
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
            this.langsInfoDGV = new System.Windows.Forms.DataGridView();
            this.LangFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EthnoOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.langsInfoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // langsInfoDGV
            // 
            this.langsInfoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.langsInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langsInfoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LangFam,
            this.LangName,
            this.DateColumn,
            this.CountColumn,
            this.EthnoOrg});
            this.langsInfoDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langsInfoDGV.Location = new System.Drawing.Point(0, 0);
            this.langsInfoDGV.Name = "langsInfoDGV";
            this.langsInfoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.langsInfoDGV.Size = new System.Drawing.Size(1008, 729);
            this.langsInfoDGV.TabIndex = 0;
            // 
            // LangFam
            // 
            this.LangFam.HeaderText = "Языковая семья";
            this.LangFam.Name = "LangFam";
            // 
            // LangName
            // 
            this.LangName.HeaderText = "Название языка";
            this.LangName.Name = "LangName";
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата подсчёта";
            this.DateColumn.Name = "DateColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Число  носителей";
            this.CountColumn.Name = "CountColumn";
            // 
            // EthnoOrg
            // 
            this.EthnoOrg.HeaderText = "По версии организации";
            this.EthnoOrg.Name = "EthnoOrg";
            // 
            // UpToDateLangInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.langsInfoDGV);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpToDateLangInfoForm";
            this.Text = "АРМ \"Лингвист\" - Сводка по последней информации об известных языках мира";
            this.Load += new System.EventHandler(this.UpToDateLangInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.langsInfoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView langsInfoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EthnoOrg;
    }
}