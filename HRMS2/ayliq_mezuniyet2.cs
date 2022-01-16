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
    public partial class ayliq_mezuniyet2 : Form
    {
        public ayliq_mezuniyet2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            Monthly_Leaves mon = new Monthly_Leaves();
            mon.Emp_id = Convert.ToInt32(textBox1.Text);
            mon.gun_sayi = Convert.ToInt32(textBox2.Text);
            mon.sebeb = textBox3.Text;
            mon.ay = comboBox1.SelectedItem.ToString();
            mon.il =  Convert.ToInt32(comboBox2.SelectedItem.ToString());
            db.Monthly_Leaves.Add(mon);
            db.SaveChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        

        private void ayliq_mezuniyet2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSystemDataSet4.Monthly_Leaves' table. You can move, or remove it, as needed.
            this.monthly_LeavesTableAdapter.Fill(this.hRMSystemDataSet4.Monthly_Leaves);

        }

       
    }
}
