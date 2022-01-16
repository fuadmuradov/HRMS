using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace HRMS2
{
    public partial class Elanlar2 : Form
    {
        public Elanlar2()
        {
            InitializeComponent();
        }

        Connection DataBase = new Connection();

        SmtpClient smtpserver = new SmtpClient();
        MailMessage mail = new MailMessage();
        NetworkCredential credential = new NetworkCredential("hrmshrms2000@gmail.com", "hrms12345");
        MailAddress address = new MailAddress("hrmshrms2000@gmail.com");
        private void button1_Click(object sender, EventArgs e)
        {
            smtpserver.Credentials = credential;
            smtpserver.EnableSsl = true;
            smtpserver.Port = 587;
            smtpserver.Host = "smtp.gmail.com";



            DataTable HRMS1 = new DataTable();
           
            HRMS1 = DataBase.SQLEXEC("select * from Emp_company where EMP_ID = " + textBox1.Text + ";");


            foreach (DataRow row in HRMS1.Rows)
            {
                mail.To.Add(row["pers_e_mail"].ToString());
                break;
            }

            mail.From = address;
            mail.Body = textBox3.Text;
            mail.Subject = textBox2.Text;
            smtpserver.Send(mail);
            MessageBox.Show("Mail Göndərildi");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

       
    }
}
