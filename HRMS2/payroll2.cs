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
    public partial class payroll2 : Form
    {
        public payroll2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        Connection DataBase = new Connection();
        private void button2_Click(object sender, EventArgs e)
        {
            Payroll pay = new Payroll();
            pay.ay = comboBox1.SelectedItem.ToString();
            pay.il = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            pay.diger_odenis = Convert.ToInt32(textBox2.Text);
            pay.ayliq_odenis = Convert.ToInt32(textBox3.Text);
            pay.yekun_odenis = Convert.ToInt32(textBox6.Text);
            pay.Emp_id = Convert.ToInt32(textBox1.Text);
            db.Payrolls.Add(pay);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable HRMS = new DataTable();
            HRMS = DataBase.SQLEXEC("select * from Emp_company where EMP_ID = " + Convert.ToInt32(textBox1.Text) + ";");
            foreach (DataRow row in HRMS.Rows)
            {
                label10.Text = row["Ad"].ToString();
                label11.Text = row["Soyad"].ToString();
                break;
            }




            DataTable HRMS1 = new DataTable();
            HRMS1 = DataBase.SQLEXEC("select * from Earning_details where Emp_id = " + Convert.ToInt32(textBox1.Text) + ";");
            foreach (DataRow row in HRMS1.Rows)
            {
                label16.Text = row["emekhaqqi"].ToString();
                label15.Text = row["gunluk_haqq"].ToString();
                label12.Text = "30";

                break;
            }

            DataTable HRMS2 = new DataTable();
            HRMS2 = DataBase.SQLEXEC("select * from Leaves where Emp_id = " + Convert.ToInt32(textBox1.Text) + ";");
            foreach (DataRow row in HRMS2.Rows)
            {
                label13.Text = row["tetil_gunu"].ToString();
                label14.Text = row["date_count"].ToString();
                

                break;
            }


        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(label14.Text);
            int m = Convert.ToInt32(label15.Text);
            int ay = Convert.ToInt32(textBox3.Text);
            int diger = Convert.ToInt32(textBox2.Text);
            int vergi = Convert.ToInt32(textBox4.Text);
            int yekun = ay - (n * m) + diger - vergi;
            textBox6.Text = yekun.ToString();
        }

        
    }
}
