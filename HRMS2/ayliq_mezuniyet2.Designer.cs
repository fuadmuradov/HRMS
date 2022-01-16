namespace HRMS2
{
    partial class ayliq_mezuniyet2
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunsayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sebebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyLeavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMSystemDataSet4 = new HRMS2.HRMSystemDataSet4();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.monthly_LeavesTableAdapter = new HRMS2.HRMSystemDataSet4TableAdapters.Monthly_LeavesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLeavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 46);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(454, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 45);
            this.label5.TabIndex = 65;
            this.label5.Text = "Aylıq Məzuniyyət";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(51, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 569);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.gunsayiDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.sebebDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monthlyLeavesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 213);
            this.dataGridView1.TabIndex = 67;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gunsayiDataGridViewTextBoxColumn
            // 
            this.gunsayiDataGridViewTextBoxColumn.DataPropertyName = "gun_sayi";
            this.gunsayiDataGridViewTextBoxColumn.HeaderText = "gun_sayi";
            this.gunsayiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gunsayiDataGridViewTextBoxColumn.Name = "gunsayiDataGridViewTextBoxColumn";
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "ay";
            this.ayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            // 
            // sebebDataGridViewTextBoxColumn
            // 
            this.sebebDataGridViewTextBoxColumn.DataPropertyName = "sebeb";
            this.sebebDataGridViewTextBoxColumn.HeaderText = "sebeb";
            this.sebebDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sebebDataGridViewTextBoxColumn.Name = "sebebDataGridViewTextBoxColumn";
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // monthlyLeavesBindingSource
            // 
            this.monthlyLeavesBindingSource.DataMember = "Monthly_Leaves";
            this.monthlyLeavesBindingSource.DataSource = this.hRMSystemDataSet4;
            // 
            // hRMSystemDataSet4
            // 
            this.hRMSystemDataSet4.DataSetName = "HRMSystemDataSet4";
            this.hRMSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 30);
            this.label6.TabIndex = 66;
            this.label6.Text = "Aylıq Məzuniyyət Reportu:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 147);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1049, 119);
            this.textBox3.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ümumi Gün sayı:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(604, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "İli Seçin:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.comboBox2.Location = new System.Drawing.Point(703, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 24);
            this.comboBox2.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(586, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ayı Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yanvar",
            "Fevral",
            "Mart",
            "Aprel",
            "May",
            "Iyun",
            "Iyul",
            "Avqust",
            "Sentyabr",
            "Oktyabr",
            "Noyabr",
            "Dekabr"});
            this.comboBox1.Location = new System.Drawing.Point(703, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(86, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "İş Nömrəsi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yadda Saxla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthly_LeavesTableAdapter
            // 
            this.monthly_LeavesTableAdapter.ClearBeforeFill = true;
            // 
            // ayliq_mezuniyet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1208, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ayliq_mezuniyet2";
            this.Text = "Monthly_Leave";
            this.Load += new System.EventHandler(this.ayliq_mezuniyet2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLeavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet4)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRMSystemDataSet4 hRMSystemDataSet4;
        private System.Windows.Forms.BindingSource monthlyLeavesBindingSource;
        private HRMSystemDataSet4TableAdapters.Monthly_LeavesTableAdapter monthly_LeavesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunsayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sebebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
    }
}