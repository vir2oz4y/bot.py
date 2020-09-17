namespace laba1_5sem
{
    partial class Procedure4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.postavkiDataSet = new laba1_5sem.PostavkiDataSet();
            this.procedure4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedure_4TableAdapter = new laba1_5sem.PostavkiDataSetTableAdapters.procedure_4TableAdapter();
            this.namepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вКварталDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вГодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namepDataGridViewTextBoxColumn,
            this.вМесяцDataGridViewTextBoxColumn,
            this.вКварталDataGridViewTextBoxColumn,
            this.вГодDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.procedure4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // postavkiDataSet
            // 
            this.postavkiDataSet.DataSetName = "PostavkiDataSet";
            this.postavkiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procedure4BindingSource
            // 
            this.procedure4BindingSource.DataMember = "procedure_4";
            this.procedure4BindingSource.DataSource = this.postavkiDataSet;
            // 
            // procedure_4TableAdapter
            // 
            this.procedure_4TableAdapter.ClearBeforeFill = true;
            // 
            // namepDataGridViewTextBoxColumn
            // 
            this.namepDataGridViewTextBoxColumn.DataPropertyName = "namep";
            this.namepDataGridViewTextBoxColumn.HeaderText = "namep";
            this.namepDataGridViewTextBoxColumn.Name = "namepDataGridViewTextBoxColumn";
            this.namepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вМесяцDataGridViewTextBoxColumn
            // 
            this.вМесяцDataGridViewTextBoxColumn.DataPropertyName = "в месяц";
            this.вМесяцDataGridViewTextBoxColumn.HeaderText = "в месяц";
            this.вМесяцDataGridViewTextBoxColumn.Name = "вМесяцDataGridViewTextBoxColumn";
            this.вМесяцDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вКварталDataGridViewTextBoxColumn
            // 
            this.вКварталDataGridViewTextBoxColumn.DataPropertyName = "в квартал";
            this.вКварталDataGridViewTextBoxColumn.HeaderText = "в квартал";
            this.вКварталDataGridViewTextBoxColumn.Name = "вКварталDataGridViewTextBoxColumn";
            this.вКварталDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вГодDataGridViewTextBoxColumn
            // 
            this.вГодDataGridViewTextBoxColumn.DataPropertyName = "в год";
            this.вГодDataGridViewTextBoxColumn.HeaderText = "в год";
            this.вГодDataGridViewTextBoxColumn.Name = "вГодDataGridViewTextBoxColumn";
            this.вГодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Procedure4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 189);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Procedure4";
            this.Text = "Procedure4";
            this.Load += new System.EventHandler(this.Procedure4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PostavkiDataSet postavkiDataSet;
        private System.Windows.Forms.BindingSource procedure4BindingSource;
        private PostavkiDataSetTableAdapters.procedure_4TableAdapter procedure_4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вКварталDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вГодDataGridViewTextBoxColumn;
    }
}