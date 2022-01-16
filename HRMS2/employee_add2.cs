using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRMS2
{
    public partial class employee_add2 : Form
    {
        public employee_add2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        Connection DataBase = new Connection();
        private void employee_add2_Load(object sender, EventArgs e)
        {
       
            // TODO: This line of code loads data into the 'hRMSystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hRMSystemDataSet.Department);

        }

        private void button8_Click(object sender, EventArgs e)
        {

            DataTable StudentTable = new DataTable();
            StudentTable = DataBase.SQLEXEC("SELECT * FROM Emp_company WHERE Ad='" + TextBox1.Text + "'");
            string k="";
            foreach (DataRow row in StudentTable.Rows)
            {
                
                k=row["EMP_ID"].ToString();
}
                    
            MessageBox.Show(k);

            Emp_main c_main = new Emp_main();
       
            c_main.ata_adi = textBox8.Text;
            c_main.Qan_qrupu = comboBox6.SelectedItem.ToString();
            c_main.Din = comboBox9.SelectedItem.ToString();
            c_main.aile_durumu = comboBox5.SelectedItem.ToString();
            c_main.milliyet = textBox6.Text;
            c_main.Gender = comboBox8.SelectedItem.ToString();

            DateTime iDate;
            iDate = dateTimePicker1.Value;
            string dt = dateTimePicker1.Value.ToString();
            String[] strlist = dt.Split(' ');

            c_main.DBT = strlist[0];
            c_main.photo = textBox19.Text;

            
            c_main.Emp_number = Convert.ToInt32(k);
            db.Emp_main.Add(c_main);
            db.SaveChanges();


            Emp_Adress emp = new Emp_Adress();
            emp.Ev_number = Convert.ToInt32( textBox7.Text);
            emp.kuce_adi = textBox5.Text;
            emp.Seher = textBox9.Text;
            emp.Sexsiyyet_num = textBox10.Text;
            emp.phone_num = textBox11.Text;
            emp.mobil_num = textBox12.Text;
            emp.main_ev = textBox18.Text;
            emp.main_kuce = textBox17.Text;
            emp.main_seher = textBox16.Text;
            emp.main_phone = textBox14.Text;
            emp.Emp_id = Convert.ToInt32(k);

            db.Emp_Adress.Add(emp);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter= "Image Files(*.jpg; *.jpeg; *.gif; *.bmp *.png)|*.jpg; *.jpeg; *.gif; *.bmp *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

            textBox19.Text = openFileDialog1.FileName;
            }

        private void button9_Click(object sender, EventArgs e)
        {
            string str = "" ;
            str = "insert into compony(Ad, Soyad, muraciet_kod, Categori, Derece, Pers_mail, kart_number, Department) Values('"+
                                                                        TextBox1.Text + "','" + textBox4.Text + "'," +
                                                                        textBox2.Text + ", '" + comboBox3.SelectedItem.ToString() + "', '" +
                                                                        comboBox4.SelectedItem.ToString() + "', '" + textBox20.Text + "', '" +
                                                                        textBox15.Text + "', '" + comboBox1.SelectedItem.ToString() + "');";
            
            DataBase.SQLEXEC(str);

            Emp_company comp = new Emp_company();
            comp.Ad = TextBox1.Text;
            comp.Soyad = textBox4.Text;
            comp.muraciet_kod = Convert.ToInt32(textBox2.Text);
            comp.categoriya = comboBox3.SelectedItem.ToString();
            comp.Derece = Convert.ToInt32(comboBox4.SelectedItem.ToString());
            comp.department = Convert.ToInt32(comboBox1.SelectedIndex)+1;
            comp.pers_e_mail = textBox20.Text;
            comp.kart_number = textBox15.Text;
            db.Emp_company.Add(comp);
            db.SaveChanges();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (Form1 f =new Form1())
            {
                f.ShowDialog();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Form1 f=new Form1())
            {
                f.ShowDialog();

            }
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            using (Job_details2 j = new Job_details2())
            {
                j.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (earning_details2 ea= new earning_details2())
            {
                ea.ShowDialog();
            }
        }

       
    }
}
