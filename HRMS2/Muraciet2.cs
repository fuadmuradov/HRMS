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
    public partial class Muraciet2 : Form
    {
        public Muraciet2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word Files(*.docx;)|*.docx;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = openFileDialog1.FileName;
            }
        }
        HRMSystemEntities db = new HRMSystemEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            string dt = dateTimePicker1.Value.ToString();
            String[] strlist = dt.Split(' ');
            string gender = "F";
            if (radioButton2.Checked == true) gender = "M";
            Muraciet1 mur = new Muraciet1();
            mur.Ad = textBox1.Text;
                 mur.Soyad = textBox2.Text;
                     mur.Gender = gender;
                         mur.DBT = strlist[0];
                             mur.E_mail = textBox3.Text;
                          mur.Telefon = textBox4.Text;
                     mur.Tehsil = comboBox1.SelectedItem.ToString();
                mur.Tecrube = comboBox2.SelectedItem.ToString();
            mur.Onceki_sirket = textBox5.Text;
                 mur.Vezife = textBox6.Text;
                     mur.Emekhaqqi = Convert.ToInt32(textBox7.Text);
                          db.Muraciet1.Add(mur);
                              db.SaveChanges();
            textBox1.Text = "";
                 textBox2.Text = "";
                     textBox3.Text = "";
                         textBox4.Text = "";
                             textBox5.Text = "";
                         textBox6.Text = "";
                     textBox7.Text = "";
                 textBox8.Text = "";
           
        }

      
    }
}
