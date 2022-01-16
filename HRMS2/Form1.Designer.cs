namespace HRMS2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMSystemDataSet = new HRMS2.HRMSystemDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter = new HRMS2.HRMSystemDataSetTableAdapters.DepartmentTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(569, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Detaylı Axtarış";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TextBox1);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 81);
            this.panel2.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(860, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 31);
            this.button9.TabIndex = 58;
            this.button9.Text = "Axtar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müştəri Kodu:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(369, 21);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(300, 28);
            this.TextBox1.TabIndex = 16;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hRMSystemDataSet;
            // 
            // hRMSystemDataSet
            // 
            this.hRMSystemDataSet.DataSetName = "HRMSystemDataSet";
            this.hRMSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.textBox15);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.textBox14);
            this.panel3.Controls.Add(this.textBox16);
            this.panel3.Controls.Add(this.textBox17);
            this.panel3.Controls.Add(this.textBox18);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Location = new System.Drawing.Point(12, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1406, 475);
            this.panel3.TabIndex = 2;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(860, 101);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(164, 28);
            this.textBox15.TabIndex = 50;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(860, 62);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(164, 28);
            this.textBox13.TabIndex = 49;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(860, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 28);
            this.textBox4.TabIndex = 48;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 28);
            this.textBox3.TabIndex = 47;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 28);
            this.textBox2.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(818, 186);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 23);
            this.label24.TabIndex = 45;
            this.label24.Text = "Əsas Ünvan";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(560, 349);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(161, 23);
            this.label26.TabIndex = 43;
            this.label26.Text = "Telefon nömrəsi:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(589, 307);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 23);
            this.label28.TabIndex = 41;
            this.label28.Text = "Şəhər/Rayon:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(621, 270);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 40;
            this.label29.Text = "Küçə adı:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(603, 228);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(118, 23);
            this.label30.TabIndex = 39;
            this.label30.Text = "Ev Nömrəsi:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(743, 349);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(281, 28);
            this.textBox14.TabIndex = 36;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(743, 307);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(281, 28);
            this.textBox16.TabIndex = 34;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(743, 265);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(281, 28);
            this.textBox17.TabIndex = 33;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(743, 223);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(281, 28);
            this.textBox18.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(324, 186);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 23);
            this.label23.TabIndex = 31;
            this.label23.Text = "Hazırki Ünvan";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(92, 434);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 23);
            this.label22.TabIndex = 30;
            this.label22.Text = "Mobil Nömrə:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(66, 391);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 23);
            this.label21.TabIndex = 29;
            this.label21.Text = "Telefon nömrəsi:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(58, 349);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 23);
            this.label20.TabIndex = 28;
            this.label20.Text = "Şəxsiyyət nömrəsi:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(95, 307);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 23);
            this.label19.TabIndex = 27;
            this.label19.Text = "Şəhər/Rayon:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(127, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 26;
            this.label18.Text = "Küçə adı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(109, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 23);
            this.label17.TabIndex = 25;
            this.label17.Text = "Ev Nömrəsi:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(249, 433);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(281, 28);
            this.textBox12.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(249, 391);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(281, 28);
            this.textBox11.TabIndex = 22;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(249, 349);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(281, 28);
            this.textBox10.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(249, 307);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(281, 28);
            this.textBox9.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 265);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 28);
            this.textBox5.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1130, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 216);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(154, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(778, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Milliyət:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(728, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ailə Vəziyyəti:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(800, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Din:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(739, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "Qan qrupu:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(108, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 9;
            this.label15.Text = "Doğum Günü:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(154, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 23);
            this.label16.TabIndex = 8;
            this.label16.Text = "Ata adı:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(860, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 28);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(249, 223);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 28);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(249, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(262, 28);
            this.textBox8.TabIndex = 0;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1418, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "employee_add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSystemDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox1;
        private HRMSystemDataSet hRMSystemDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HRMSystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}