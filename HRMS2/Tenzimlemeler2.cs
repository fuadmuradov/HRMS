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
    public partial class Tenzimlemeler2 : Form
    {

        public Tenzimlemeler2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        private void button9_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            dp.department1 = textBox1.Text;
            db.Departments.Add(dp);
            db.SaveChanges();
            MessageBox.Show("Department əlavə olundu");
            data_load1();
           
        }
        public void data_load1()
        {
            DataTable HRMS3 = new DataTable();
            HRMS3 = DataBase.SQLEXEC("select * from Department");
            dataGridView1.DataSource = HRMS3;

        }

        private void Tenzimlemeler2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSystemDataSet6.compony' table. You can move, or remove it, as needed.
            this.componyTableAdapter.Fill(this.hRMSystemDataSet6.compony);
            // TODO: This line of code loads data into the 'hRMSystemDataSet3.Emp_company' table. You can move, or remove it, as needed.
            this.emp_companyTableAdapter.Fill(this.hRMSystemDataSet3.Emp_company);
            // TODO: This line of code loads data into the 'hRMSystemDataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hRMSystemDataSet2.Department);
         

        }
        Connection DataBase = new Connection();
        private void button3_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM compony where ID = " + textBox2.Text +";";
            DataBase.SQLEXEC(str);
            string str1 = "DELETE FROM Emp_Adress where Emp_id = " + textBox2.Text + ";";
            DataBase.SQLEXEC(str1);
            string str2 = "DELETE FROM Earning_details where Emp_id = " + textBox2.Text + ";";
            DataBase.SQLEXEC(str2);

            string str3 = "DELETE FROM Emp_main where Emp_number = " + textBox2.Text + ";";
            DataBase.SQLEXEC(str3);
            string str4 = "DELETE FROM Is_ayrintilari where Emp_id = " + textBox2.Text + ";";
            DataBase.SQLEXEC(str4);
            data_load();


        }

        public void data_load()
        {
            DataTable HRMS3 = new DataTable();
            HRMS3 = DataBase.SQLEXEC("select * from compony");
            dataGridView1.DataSource = HRMS3;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable HRMS = new DataTable();
            HRMS = DataBase.SQLEXEC("select * from Login where Emp_id = " + textBox3.Text +";");
            foreach (DataRow row in HRMS.Rows)
            {
                if (Convert.ToInt32(textBox4.Text) == Convert.ToInt32(row["Emp_pass"].ToString()))
                {
                    if (Convert.ToInt32(textBox5.Text) == Convert.ToInt32(textBox6.Text))
                    {
                        string str6 = "Update Login set emp_pass = " + textBox6.Text + " where Emp_id = " + textBox3.Text + ";";
                        DataBase.SQLEXEC(str6);
                        MessageBox.Show("Şifrə Yeniləndi");
                    }
                    else MessageBox.Show("Uygunsuzluq Var");
                }
                else MessageBox.Show("Şifrə Yanlışdır");

                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }

       
    }
}
