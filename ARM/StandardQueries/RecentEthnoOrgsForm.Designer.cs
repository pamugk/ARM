namespace ARM.StandardQueries
{
    partial class RecentEthnoOrgsForm
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
            this.ethnoDGV = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаоснованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штабквартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоносителейязыковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этнографическиеорганизацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ethnoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.этнографическиеорганизацииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ethnoDGV
            // 
            this.ethnoDGV.AutoGenerateColumns = false;
            this.ethnoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ethnoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ethnoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.датаоснованияDataGridViewTextBoxColumn,
            this.штабквартираDataGridViewTextBoxColumn,
            this.числоносителейязыковDataGridViewTextBoxColumn});
            this.ethnoDGV.DataSource = this.этнографическиеорганизацииBindingSource;
            this.ethnoDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ethnoDGV.Location = new System.Drawing.Point(0, 0);
            this.ethnoDGV.Name = "ethnoDGV";
            this.ethnoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ethnoDGV.Size = new System.Drawing.Size(800, 450);
            this.ethnoDGV.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // датаоснованияDataGridViewTextBoxColumn
            // 
            this.датаоснованияDataGridViewTextBoxColumn.DataPropertyName = "Дата_основания";
            this.датаоснованияDataGridViewTextBoxColumn.HeaderText = "Дата основания";
            this.датаоснованияDataGridViewTextBoxColumn.Name = "датаоснованияDataGridViewTextBoxColumn";
            // 
            // штабквартираDataGridViewTextBoxColumn
            // 
            this.штабквартираDataGridViewTextBoxColumn.DataPropertyName = "Штаб_квартира";
            this.штабквартираDataGridViewTextBoxColumn.HeaderText = "Штаб-квартира";
            this.штабквартираDataGridViewTextBoxColumn.Name = "штабквартираDataGridViewTextBoxColumn";
            // 
            // числоносителейязыковDataGridViewTextBoxColumn
            // 
            this.числоносителейязыковDataGridViewTextBoxColumn.DataPropertyName = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn.HeaderText = "Число_носителей_языков";
            this.числоносителейязыковDataGridViewTextBoxColumn.Name = "числоносителейязыковDataGridViewTextBoxColumn";
            this.числоносителейязыковDataGridViewTextBoxColumn.Visible = false;
            // 
            // этнографическиеорганизацииBindingSource
            // 
            this.этнографическиеорганизацииBindingSource.DataSource = typeof(ARM.LinguisticDBModel.Этнографические_организации);
            // 
            // RecentEthnoOrgsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ethnoDGV);
            this.Name = "RecentEthnoOrgsForm";
            this.Text = "АРМ \"Лингвист\" - Этнографические организации, зарегестрированные в этом году";
            this.Load += new System.EventHandler(this.RecentEthnoOrgsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethnoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.этнографическиеорганизацииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ethnoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаоснованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штабквартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоносителейязыковDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource этнографическиеорганизацииBindingSource;
    }
}