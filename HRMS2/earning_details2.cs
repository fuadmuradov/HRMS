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
    public partial class earning_details2 : Form
    {
        public earning_details2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        private void button6_Click(object sender, EventArgs e)
        {
            Earning_details ear = new Earning_details();
            ear.emekhaqqi = Convert.ToInt32(textBox6.Text);
            ear.gunluk_haqq = Convert.ToInt32(textBox5.Text);
            ear.vergi = Convert.ToInt32(comboBox5.SelectedItem.ToString());
            ear.hefte_is_gunu = Convert.ToInt32(textBox2.Text);
            ear.ayliq_is_gunu = Convert.ToInt32(textBox3.Text);
            ear.Emp_id = Convert.ToInt32(textBox1.Text);
            db.Earning_details.Add(ear);
            db.SaveChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (employee_add2 emp= new employee_add2())
            {
                emp.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Job_details2 emp = new Job_details2())
            {
                emp.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (earning_details2 emp = new earning_details2())
            {
                emp.ShowDialog();
            }
        }

       
    }
}
