
namespace ÖğrenciNotKayıtSistemi
{
    partial class FrmOgrenciListesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKIMLIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLUMUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIFRESIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRENCIKUTUKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayıtDataSet3 = new ÖğrenciNotKayıtSistemi.dbNotKayıtDataSet3();
            this.oGRENCI_KUTUKTableAdapter = new ÖğrenciNotKayıtSistemi.dbNotKayıtDataSet3TableAdapters.OGRENCI_KUTUKTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCIKUTUKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNODataGridViewTextBoxColumn,
            this.aDIDataGridViewTextBoxColumn,
            this.sOYADIDataGridViewTextBoxColumn,
            this.nODataGridViewTextBoxColumn,
            this.tCKIMLIKDataGridViewTextBoxColumn,
            this.bOLUMUDataGridViewTextBoxColumn,
            this.sINIFIDataGridViewTextBoxColumn,
            this.mAILDataGridViewTextBoxColumn,
            this.sIFRESIDataGridViewTextBoxColumn,
            this.aDRESIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oGRENCIKUTUKBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 688);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sNODataGridViewTextBoxColumn
            // 
            this.sNODataGridViewTextBoxColumn.DataPropertyName = "SNO";
            this.sNODataGridViewTextBoxColumn.HeaderText = "SNO";
            this.sNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNODataGridViewTextBoxColumn.Name = "sNODataGridViewTextBoxColumn";
            this.sNODataGridViewTextBoxColumn.ReadOnly = true;
            this.sNODataGridViewTextBoxColumn.Width = 125;
            // 
            // aDIDataGridViewTextBoxColumn
            // 
            this.aDIDataGridViewTextBoxColumn.DataPropertyName = "ADI";
            this.aDIDataGridViewTextBoxColumn.HeaderText = "ADI";
            this.aDIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDIDataGridViewTextBoxColumn.Name = "aDIDataGridViewTextBoxColumn";
            this.aDIDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOYADIDataGridViewTextBoxColumn
            // 
            this.sOYADIDataGridViewTextBoxColumn.DataPropertyName = "SOYADI";
            this.sOYADIDataGridViewTextBoxColumn.HeaderText = "SOYADI";
            this.sOYADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOYADIDataGridViewTextBoxColumn.Name = "sOYADIDataGridViewTextBoxColumn";
            this.sOYADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nODataGridViewTextBoxColumn
            // 
            this.nODataGridViewTextBoxColumn.DataPropertyName = "NO";
            this.nODataGridViewTextBoxColumn.HeaderText = "NO";
            this.nODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nODataGridViewTextBoxColumn.Name = "nODataGridViewTextBoxColumn";
            this.nODataGridViewTextBoxColumn.Width = 125;
            // 
            // tCKIMLIKDataGridViewTextBoxColumn
            // 
            this.tCKIMLIKDataGridViewTextBoxColumn.DataPropertyName = "TCKIMLIK";
            this.tCKIMLIKDataGridViewTextBoxColumn.HeaderText = "TCKIMLIK";
            this.tCKIMLIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCKIMLIKDataGridViewTextBoxColumn.Name = "tCKIMLIKDataGridViewTextBoxColumn";
            this.tCKIMLIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // bOLUMUDataGridViewTextBoxColumn
            // 
            this.bOLUMUDataGridViewTextBoxColumn.DataPropertyName = "BOLUMU";
            this.bOLUMUDataGridViewTextBoxColumn.HeaderText = "BOLUMU";
            this.bOLUMUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOLUMUDataGridViewTextBoxColumn.Name = "bOLUMUDataGridViewTextBoxColumn";
            this.bOLUMUDataGridViewTextBoxColumn.Width = 125;
            // 
            // sINIFIDataGridViewTextBoxColumn
            // 
            this.sINIFIDataGridViewTextBoxColumn.DataPropertyName = "SINIFI";
            this.sINIFIDataGridViewTextBoxColumn.HeaderText = "SINIFI";
            this.sINIFIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sINIFIDataGridViewTextBoxColumn.Name = "sINIFIDataGridViewTextBoxColumn";
            this.sINIFIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            this.mAILDataGridViewTextBoxColumn.HeaderText = "MAIL";
            this.mAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            this.mAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // sIFRESIDataGridViewTextBoxColumn
            // 
            this.sIFRESIDataGridViewTextBoxColumn.DataPropertyName = "SIFRESI";
            this.sIFRESIDataGridViewTextBoxColumn.HeaderText = "SIFRESI";
            this.sIFRESIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIFRESIDataGridViewTextBoxColumn.Name = "sIFRESIDataGridViewTextBoxColumn";
            this.sIFRESIDataGridViewTextBoxColumn.Visible = false;
            this.sIFRESIDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESIDataGridViewTextBoxColumn
            // 
            this.aDRESIDataGridViewTextBoxColumn.DataPropertyName = "ADRESI";
            this.aDRESIDataGridViewTextBoxColumn.HeaderText = "ADRESI";
            this.aDRESIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDRESIDataGridViewTextBoxColumn.Name = "aDRESIDataGridViewTextBoxColumn";
            this.aDRESIDataGridViewTextBoxColumn.Width = 125;
            // 
            // oGRENCIKUTUKBindingSource
            // 
            this.oGRENCIKUTUKBindingSource.DataMember = "OGRENCI_KUTUK";
            this.oGRENCIKUTUKBindingSource.DataSource = this.dbNotKayıtDataSet3;
            // 
            // dbNotKayıtDataSet3
            // 
            this.dbNotKayıtDataSet3.DataSetName = "dbNotKayıtDataSet3";
            this.dbNotKayıtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oGRENCI_KUTUKTableAdapter
            // 
            this.oGRENCI_KUTUKTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgrenciListesi";
            this.Text = "ÖĞRENCİ LİSTESİ";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCIKUTUKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbNotKayıtDataSet3 dbNotKayıtDataSet3;
        private System.Windows.Forms.BindingSource oGRENCIKUTUKBindingSource;
        private dbNotKayıtDataSet3TableAdapters.OGRENCI_KUTUKTableAdapter oGRENCI_KUTUKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKIMLIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOLUMUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINIFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIFRESIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESIDataGridViewTextBoxColumn;
    }
}