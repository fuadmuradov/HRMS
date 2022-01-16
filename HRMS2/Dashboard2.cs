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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }
        private void movesdepanel(Button btn)
        {
            panel6.Top = btn.Top;
            panel6.Height = btn.Height;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            movesdepanel(button3);
            using (Tecrube2 tc =new Tecrube2())
            {
                tc.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movesdepanel(button4);
            using (Elanlar2 tc = new Elanlar2())
            {
                tc.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movesdepanel(button5);
            using (Muraciet2 tc = new Muraciet2())
            {
                tc.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            movesdepanel(button6);
            using (payroll2 tc = new payroll2())
            {
                tc.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movesdepanel(button7);
            using (employee_add2 tc = new employee_add2())
            {
                tc.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            movesdepanel(button8);
            using (Tenzimlemeler2 tc = new Tenzimlemeler2())
            {
                tc.ShowDialog();
            }
        }

        private void işçilərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (Form1 tc = new Form1())
            {
                tc.ShowDialog();
            }
        }

        private void işçiƏlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (employee_add2 tc = new employee_add2())
            {
                tc.ShowDialog();
            }
        }

        private void işDetallarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Job_details2 tc = new Job_details2())
            {
                tc.ShowDialog();
            }
        }

        private void ödənişDetallarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (earning_details2 tc = new earning_details2())
            {
                tc.ShowDialog();
            }
        }

        private void günlükMəzuniyyətToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Mezuniyyet2 tc = new Mezuniyyet2())
            {
                tc.ShowDialog();
            }
        }

        private void aylıqMəzuniyyətToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ayliq_mezuniyet2 tc = new ayliq_mezuniyet2())
            {
                tc.ShowDialog();
            }
        }

        private void işçiÖdənişləriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (payroll2 tc = new payroll2())
            {
                tc.ShowDialog();
            }
        }

        private void müraciətToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Muraciet2 tc = new Muraciet2())
            {
                tc.ShowDialog();
            }
        }

        private void təcrübəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Tecrube2 tc = new Tecrube2())
            {
                tc.ShowDialog();
            }
        }

        private void elanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Elanlar2 tc = new Elanlar2())
            {
                tc.ShowDialog();
            }
        }

        private void tənzimləmələrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Tenzimlemeler2 tc = new Tenzimlemeler2())
            {
                tc.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Connection DataBase = new Connection(); 
        private void button9_Click(object sender, EventArgs e)
        {
            DataTable HRMS = new DataTable();
            HRMS = DataBase.SQLEXEC("Select * from compony where Ad = '" + textBox2.Text + "' and Soyad = '" + textBox1.Text + "';");
            foreach(DataRow row in HRMS.Rows)
            {
                dataGridView1.Rows.Add(row["ID"].ToString(), row["Ad"].ToString(), row["Soyad"].ToString(), row["Categori"].ToString(), row["Derece"].ToString(), row["Pers_mail"].ToString(), row["kart_number"].ToString(), row["Department"].ToString()) ;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void müracətEdənlərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Muraciet_edenler2 tc =new Muraciet_edenler2())
            {
                tc.ShowDialog();
            }
        }
    }
}
