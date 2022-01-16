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
    public partial class Tecrube2 : Form
    {
        public Tecrube2()
        {
            InitializeComponent();
        }

        private void Tecrube2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSystemDataSet1.Tecrube' table. You can move, or remove it, as needed.
            this.tecrubeTableAdapter.Fill(this.hRMSystemDataSet1.Tecrube);

        }
        Connection DataBase = new Connection();
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable HRMS = new DataTable();
            string str = "INSERT INTO Tecrube(Basliq, Program, Isci_nomresi, Unvan, Status) VALUES('" + textBox1.Text +
                                                                       "', '" + textBox2.Text + "', " + textBox3.Text +
                                                                       ", '" + textBox4.Text + "', '" + textBox5.Text + "');";
            DataBase.SQLEXEC(str);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        
        HRMSystemEntities db = new HRMSystemEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable HRMS3 = new DataTable();
            HRMS3 = DataBase.SQLEXEC("select * from Tecrube");
            dataGridView1.DataSource = HRMS3;
        }
    }
}
