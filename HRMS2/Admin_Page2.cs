using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS2
{
    public partial class Admin_Page2 : Form
    {
        public Admin_Page2()
        {
            InitializeComponent();
        }
        Connection Database = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "insert into Login(Emp_id, Emp_pass) values(" + textBox1.Text + ", " + textBox2.Text + ");";
            Database.SQLEXEC(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Dashboard2 dt=new Dashboard2())
            {
                dt.ShowDialog();
            }

        }
    }
}
