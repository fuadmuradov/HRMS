namespace HRMS2
{
    partial class Muraciet_edenler2
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hRMSystemDataSet5 = new HRMS2.HRMSystemDataSet5();
            this.muraciet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muraciet1TableAdapter = new HRMS2.HRMSystemDataSet5TableAdapters.Muraciet1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tehsilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecrubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekisirketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emekhaqqiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muraciet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 56);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(306, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(500, 45);
            this.label13.TabIndex = 71;
            this.label13.Text = "Müraciət Edənlərin Siyahısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(46, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 554);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dBTDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.tehsilDataGridViewTextBoxColumn,
            this.tecrubeDataGridViewTextBoxColumn,
            this.oncekisirketDataGridViewTextBoxColumn,
            this.vezifeDataGridViewTextBoxColumn,
            this.emekhaqqiDataGridViewTextBoxColumn,
            this.cVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.muraciet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // hRMSystemDataSet5
            // 
            this.hRMSystemDataSet5.DataSetName = "HRMSystemDataSet5";
            this.hRMSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muraciet1BindingSource
            // 
            this.muraciet1BindingSource.DataMember = "Muraciet1";
            this.muraciet1BindingSource.DataSource = this.hRMSystemDataSet5;
            // 
            // muraciet1TableAdapter
            // 
            this.muraciet1TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBTDataGridViewTextBoxColumn
            // 
            this.dBTDataGridViewTextBoxColumn.DataPropertyName = "DBT";
            this.dBTDataGridViewTextBoxColumn.HeaderText = "DBT";
            this.dBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dBTDataGridViewTextBoxColumn.Name = "dBTDataGridViewTextBoxColumn";
            this.dBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E_mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tehsilDataGridViewTextBoxColumn
            // 
            this.tehsilDataGridViewTextBoxColumn.DataPropertyName = "Tehsil";
            this.tehsilDataGridViewTextBoxColumn.HeaderText = "Tehsil";
            this.tehsilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tehsilDataGridViewTextBoxColumn.Name = "tehsilDataGridViewTextBoxColumn";
            this.tehsilDataGridViewTextBoxColumn.Width = 125;
            // 
            // tecrubeDataGridViewTextBoxColumn
            // 
            this.tecrubeDataGridViewTextBoxColumn.DataPropertyName = "Tecrube";
            this.tecrubeDataGridViewTextBoxColumn.HeaderText = "Tecrube";
            this.tecrubeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecrubeDataGridViewTextBoxColumn.Name = "tecrubeDataGridViewTextBoxColumn";
            this.tecrubeDataGridViewTextBoxColumn.Width = 125;
            // 
            // oncekisirketDataGridViewTextBoxColumn
            // 
            this.oncekisirketDataGridViewTextBoxColumn.DataPropertyName = "Onceki_sirket";
            this.oncekisirketDataGridViewTextBoxColumn.HeaderText = "Onceki_sirket";
            this.oncekisirketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oncekisirketDataGridViewTextBoxColumn.Name = "oncekisirketDataGridViewTextBoxColumn";
            this.oncekisirketDataGridViewTextBoxColumn.Width = 125;
            // 
            // vezifeDataGridViewTextBoxColumn
            // 
            this.vezifeDataGridViewTextBoxColumn.DataPropertyName = "Vezife";
            this.vezifeDataGridViewTextBoxColumn.HeaderText = "Vezife";
            this.vezifeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vezifeDataGridViewTextBoxColumn.Name = "vezifeDataGridViewTextBoxColumn";
            this.vezifeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emekhaqqiDataGridViewTextBoxColumn
            // 
            this.emekhaqqiDataGridViewTextBoxColumn.DataPropertyName = "Emekhaqqi";
            this.emekhaqqiDataGridViewTextBoxColumn.HeaderText = "Emekhaqqi";
            this.emekhaqqiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emekhaqqiDataGridViewTextBoxColumn.Name = "emekhaqqiDataGridViewTextBoxColumn";
            this.emekhaqqiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cVDataGridViewTextBoxColumn
            // 
            this.cVDataGridViewTextBoxColumn.DataPropertyName = "CV";
            this.cVDataGridViewTextBoxColumn.HeaderText = "CV";
            this.cVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cVDataGridViewTextBoxColumn.Name = "cVDataGridViewTextBoxColumn";
            this.cVDataGridViewTextBoxColumn.Width = 125;
            // 
            // Muraciet_edenler2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1106, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Muraciet_edenler2";
            this.Text = "Elanlar";
            this.Load += new System.EventHandler(this.Muraciet_edenler2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muraciet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRMSystemDataSet5 hRMSystemDataSet5;
        private System.Windows.Forms.BindingSource muraciet1BindingSource;
        private HRMSystemDataSet5TableAdapters.Muraciet1TableAdapter muraciet1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tehsilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecrubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncekisirketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emekhaqqiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVDataGridViewTextBoxColumn;
    }
}