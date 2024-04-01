namespace DOANCUOIKI
{
    partial class treatmentList
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
            this.nHAKHOADataSet1 = new DOANCUOIKI.NHAKHOADataSet1();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new DOANCUOIKI.NHAKHOADataSet1TableAdapters.TreatmentTableAdapter();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAKHOADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDoctorDataGridViewTextBoxColumn,
            this.dichvuDataGridViewTextBoxColumn,
            this.namePatientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.treatmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // nHAKHOADataSet1
            // 
            this.nHAKHOADataSet1.DataSetName = "NHAKHOADataSet1";
            this.nHAKHOADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.nHAKHOADataSet1;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDoctorDataGridViewTextBoxColumn
            // 
            this.nameDoctorDataGridViewTextBoxColumn.DataPropertyName = "nameDoctor";
            this.nameDoctorDataGridViewTextBoxColumn.HeaderText = "nameDoctor";
            this.nameDoctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDoctorDataGridViewTextBoxColumn.Name = "nameDoctorDataGridViewTextBoxColumn";
            this.nameDoctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dichvuDataGridViewTextBoxColumn
            // 
            this.dichvuDataGridViewTextBoxColumn.DataPropertyName = "Dichvu";
            this.dichvuDataGridViewTextBoxColumn.HeaderText = "Dichvu";
            this.dichvuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dichvuDataGridViewTextBoxColumn.Name = "dichvuDataGridViewTextBoxColumn";
            this.dichvuDataGridViewTextBoxColumn.Width = 125;
            // 
            // namePatientDataGridViewTextBoxColumn
            // 
            this.namePatientDataGridViewTextBoxColumn.DataPropertyName = "namePatient";
            this.namePatientDataGridViewTextBoxColumn.HeaderText = "namePatient";
            this.namePatientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namePatientDataGridViewTextBoxColumn.Name = "namePatientDataGridViewTextBoxColumn";
            this.namePatientDataGridViewTextBoxColumn.Width = 125;
            // 
            // treatmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "treatmentList";
            this.Text = "treatmentList";
            this.Load += new System.EventHandler(this.treatmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAKHOADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NHAKHOADataSet1 nHAKHOADataSet1;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private NHAKHOADataSet1TableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dichvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePatientDataGridViewTextBoxColumn;
    }
}