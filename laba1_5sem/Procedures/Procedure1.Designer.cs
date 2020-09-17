namespace laba1_5sem
{
    partial class Procedure1
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
            this.fullitogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_itogTableAdapter = new laba1_5sem.PostavkiDataSetTableAdapters.full_itogTableAdapter();
            this.nametDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullitogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nametDataGridViewTextBoxColumn,
            this.namepDataGridViewTextBoxColumn,
            this.gorodDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn1,
            this.vDataGridViewTextBoxColumn1,
            this.sDataGridViewTextBoxColumn2,
            this.vDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.fullitogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // postavkiDataSet
            // 
            this.postavkiDataSet.DataSetName = "PostavkiDataSet";
            this.postavkiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullitogBindingSource
            // 
            this.fullitogBindingSource.DataMember = "full_itog";
            this.fullitogBindingSource.DataSource = this.postavkiDataSet;
            // 
            // full_itogTableAdapter
            // 
            this.full_itogTableAdapter.ClearBeforeFill = true;
            // 
            // nametDataGridViewTextBoxColumn
            // 
            this.nametDataGridViewTextBoxColumn.DataPropertyName = "namet";
            this.nametDataGridViewTextBoxColumn.HeaderText = "namet";
            this.nametDataGridViewTextBoxColumn.Name = "nametDataGridViewTextBoxColumn";
            this.nametDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namepDataGridViewTextBoxColumn
            // 
            this.namepDataGridViewTextBoxColumn.DataPropertyName = "namep";
            this.namepDataGridViewTextBoxColumn.HeaderText = "namep";
            this.namepDataGridViewTextBoxColumn.Name = "namepDataGridViewTextBoxColumn";
            this.namepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gorodDataGridViewTextBoxColumn
            // 
            this.gorodDataGridViewTextBoxColumn.DataPropertyName = "gorod";
            this.gorodDataGridViewTextBoxColumn.HeaderText = "gorod";
            this.gorodDataGridViewTextBoxColumn.Name = "gorodDataGridViewTextBoxColumn";
            this.gorodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "2018 v";
            this.vDataGridViewTextBoxColumn.HeaderText = "2018 v";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "2018 s";
            this.sDataGridViewTextBoxColumn.HeaderText = "2018 s";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "2018 v1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "2018 v1";
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            this.v1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDataGridViewTextBoxColumn1
            // 
            this.sDataGridViewTextBoxColumn1.DataPropertyName = "2019 s";
            this.sDataGridViewTextBoxColumn1.HeaderText = "2019 s";
            this.sDataGridViewTextBoxColumn1.Name = "sDataGridViewTextBoxColumn1";
            this.sDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vDataGridViewTextBoxColumn1
            // 
            this.vDataGridViewTextBoxColumn1.DataPropertyName = "2019 v";
            this.vDataGridViewTextBoxColumn1.HeaderText = "2019 v";
            this.vDataGridViewTextBoxColumn1.Name = "vDataGridViewTextBoxColumn1";
            this.vDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sDataGridViewTextBoxColumn2
            // 
            this.sDataGridViewTextBoxColumn2.DataPropertyName = "2020 s";
            this.sDataGridViewTextBoxColumn2.HeaderText = "2020 s";
            this.sDataGridViewTextBoxColumn2.Name = "sDataGridViewTextBoxColumn2";
            this.sDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // vDataGridViewTextBoxColumn2
            // 
            this.vDataGridViewTextBoxColumn2.DataPropertyName = "2020 v";
            this.vDataGridViewTextBoxColumn2.HeaderText = "2020 v";
            this.vDataGridViewTextBoxColumn2.Name = "vDataGridViewTextBoxColumn2";
            this.vDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Procedure1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Procedure1";
            this.Text = "Procedure1";
            this.Load += new System.EventHandler(this.Procedure1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullitogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PostavkiDataSet postavkiDataSet;
        private System.Windows.Forms.BindingSource fullitogBindingSource;
        private PostavkiDataSetTableAdapters.full_itogTableAdapter full_itogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn2;
    }
}