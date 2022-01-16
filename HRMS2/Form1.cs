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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        Connection DataBase = new Connection();
        private void button9_Click(object sender, EventArgs e)
        {
            DataTable EMP_TABLE = new DataTable();
            EMP_TABLE = DataBase.SQLEXEC("select * from Emp_Adress where Emp_id = " + Convert.ToInt32(TextBox1.Text) + ";");
            foreach (DataRow row in EMP_TABLE.Rows)
            {

                textBox7.Text = row["Ev_number"].ToString();
                textBox5.Text = row["kuce_adi"].ToString();
                textBox9.Text = row["Seher"].ToString();
                textBox10.Text = row["Sexsiyyet_num"].ToString();
                textBox11.Text = row["phone_num"].ToString();
                textBox12.Text = row["mobil_num"].ToString();
                textBox18.Text = row["main_ev"].ToString();
                textBox17.Text = row["main_kuce"].ToString();
                textBox16.Text = row["main_seher"].ToString();
                textBox14.Text = row["main_phone"].ToString();
            }




            DataTable EMP_TABLE1 = new DataTable();
            EMP_TABLE1 = DataBase.SQLEXEC("select * from Emp_main where Emp_number = " + Convert.ToInt32(TextBox1.Text) + ";");
            foreach (DataRow row in EMP_TABLE1.Rows)
            {

                textBox8.Text = row["ata_adi"].ToString();
                textBox2.Text = row["DBT"].ToString();
                textBox3.Text = row["Gender"].ToString();
                textBox4.Text = row["Qan_qrupu"].ToString();
               
                textBox13.Text = row["Din"].ToString();
                textBox15.Text = row["aile_durumu"].ToString();
                textBox6.Text = row["milliyet"].ToString();
                
                Bitmap img = new Bitmap((row["photo"].ToString()));

                pictureBox1.Image = img;
            }
        }

       
    }
}
