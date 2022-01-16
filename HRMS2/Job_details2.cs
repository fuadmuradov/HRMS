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
    public partial class Job_details2 : Form
    {
        public Job_details2()
        {
            InitializeComponent();
        }
        HRMSystemEntities db = new HRMSystemEntities();
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word Files(*.docx;)|*.docx;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               textBox7.Text = openFileDialog1.FileName;
            }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Is_ayrintilari isa = new Is_ayrintilari();
                 isa.is_vaxti = textBox8.Text;
                    string dt = dateTimePicker1.Value.ToString();
                        String[] strlist = dt.Split(' ');
                            isa.gorus_tarixi = strlist[0];
                         string ds = dateTimePicker2.Value.ToString();
                     String[] strlist1 = ds.Split(' ');
                 isa.muqavile_tarixi = strlist1[0];
            isa.artim = comboBox5.SelectedItem.ToString();
                 isa.sobe = comboBox9.SelectedItem.ToString();
                     isa.department = comboBox1.SelectedItem.ToString();
                         isa.vezife = comboBox7.SelectedItem.ToString();
                             isa.mudur = comboBox6.SelectedItem.ToString();
                         isa.CV = textBox7.Text;
                     isa.Emp_id =  Convert.ToInt32(textBox1.Text);
                 db.Is_ayrintilari.Add(isa);
            db.SaveChanges();
                 textBox1.Text = "";
                    textBox7.Text = "";
                        textBox8.Text = "";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            using (employee_add2 emp = new employee_add2())
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
