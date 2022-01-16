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
    public partial class Mezuniyyet2 : Form
    {
        public Mezuniyyet2()
        {
            InitializeComponent();
        }

        
        HRMSystemEntities db =new HRMSystemEntities();
        Connection DataBase = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            DataTable HRMS = new DataTable();
            DataTable HRMS1 = new DataTable();
           
            HRMS = DataBase.SQLEXEC("select * from Emp_company where EMP_ID = " + Convert.ToInt32(textBox1.Text) + ";");
            foreach(DataRow row in HRMS.Rows)
            {
                label5.Text = row["Ad"].ToString() + " " + row["Soyad"].ToString();
                k = Convert.ToInt32(row["department"].ToString());
                if (k == 0) textBox2.Text = "IT";
                else
                    if (k == 1) textBox2.Text = "HR";
                else
                            if (k == 2) textBox2.Text = "Muhasibat";
                else textBox2.Text = "Mexanika";


                textBox5.Text = row["categoriya"].ToString();
                textBox3.Text = row["pers_e_mail"].ToString(); 

                break;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dt = dateTimePicker1.Value.ToString();
            String[] strlist = dt.Split(' ');
            string ds = dateTimePicker2.Value.ToString();
            String[] strlist1 = dt.Split(' ');
            int tam_gun = 0;
            int yarim_gun = 0;
            int tetil = 0;
            if (radioButton1.Checked == true) tam_gun = 1;
            if (radioButton6.Checked == true) yarim_gun = 1;
            if (radioButton5.Checked == true) yarim_gun = 2;
            if (checkBox1.Checked == true) tetil = 1;
            string str = "INSERT INTO Leaves(Ay, start_date, end_date, date_count, tam_gun," +
                           " gunun_yarisi, Emp_id, Sebeb, tetil_gunu) VALUES ('" + comboBox1.SelectedItem.ToString() +
                                                       "', '" + strlist[0] + "', '" + strlist1[0] +
                                                       "', " + textBox4.Text +
                                                       ", " + tam_gun.ToString() + ", " + yarim_gun.ToString() +
                                                       ", " + textBox1.Text +
                                                       ", '" + textBox6.Text + "', " + tetil.ToString() + ");";
            DataBase.SQLEXEC(str);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label5.Text = "_________";
        }

       
    }
}
