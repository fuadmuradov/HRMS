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


namespace HRMS2
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }
        SmtpClient smtpserver = new SmtpClient();
        MailMessage mail = new MailMessage();
        NetworkCredential credential = new NetworkCredential("hrmshrms2000@gmail.com", "hrms12345");
        MailAddress address = new MailAddress("hrmshrms2000@gmail.com");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Connection DataBase = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable HRMS = new DataTable();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                HRMS = DataBase.SQLEXEC("select * from Login where Emp_id = " + textBox1.Text + ";");
                foreach (DataRow row in HRMS.Rows)
                {
                    if(Convert.ToInt32(textBox1.Text)==1 && Convert.ToInt32(textBox2.Text) == Convert.ToInt32(row["Emp_pass"].ToString()))
                    {
                        using (Admin_Page2 ad=new Admin_Page2())
                        {
                            ad.ShowDialog();
                        }
                    }

                    else

                    if (Convert.ToInt32(textBox2.Text) == Convert.ToInt32(row["Emp_pass"].ToString()))
                    {
                        using (Dashboard2 tz = new Dashboard2())
                        {

                            tz.ShowDialog();
                            this.Close();
                        }

                    }
                    else MessageBox.Show("Şifrə Düzgün Deyil");

                }
                textBox2.Text = "";

            }

            else MessageBox.Show("İş nömrəsi və Şifrəni daxil edin!!!");
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            smtpserver.Credentials = credential;
            smtpserver.EnableSsl = true;
            smtpserver.Port = 587;
            smtpserver.Host = "smtp.gmail.com";
            
            DataTable HRMS = new DataTable();
            DataTable HRMS1 = new DataTable();
            HRMS = DataBase.SQLEXEC("select * from Login where Emp_id = " + textBox1.Text + ";");
            HRMS1 = DataBase.SQLEXEC("select * from Emp_company where EMP_ID = " + textBox1.Text + ";");
            int new_pass = 0;
            string str = "";
            foreach (DataRow row in HRMS.Rows)
            {
                new_pass = Convert.ToInt32(row["Emp_pass"].ToString());
               
            }
            new_pass = new_pass + 1;
            str = "Update Login set Emp_pass = " + new_pass.ToString() + "where Emp_id = " + textBox1.Text + ";";
          
            
            DataBase.SQLEXEC(str);



            foreach (DataRow row in HRMS1.Rows)
            {
                mail.To.Add(row["pers_e_mail"].ToString());
                break;
            }

                mail.From = address;
                mail.Body = new_pass.ToString();
                mail.Subject = " Yeni Şifrə";
                smtpserver.Send(mail);
            MessageBox.Show("Yeni Şifrə Şirkıt mailinizə göndərildi.");

        }
    }
}
