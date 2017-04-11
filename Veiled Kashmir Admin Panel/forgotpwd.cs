using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class forgotpwd : Form
    {
        DBConnect obj = new DBConnect();

        public forgotpwd()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            int i;
            i = obj.Count("Select Count(*) from admin where email='" + emailtxt.Text + "';");
            if (i == 1)
            {
                MySqlDataReader dr;
                dr = obj.Query("Select * from admin where email='" + emailtxt.Text + "';");
                dr.Read();

                MailMessage mail = new MailMessage();
                SmtpClient Smtpobj = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("veiledkashmir@gmail.com");
                mail.To.Add(emailtxt.Text);
                mail.Subject = "Veiled Kashmir Password Recovery Mail";
                mail.Body = "Hi, Your Password is " + dr[4].ToString() + Environment.NewLine + "If you didn't initiate the request, kindly ignore this mail" + Environment.NewLine + "Contact Veiled Kashmir Team for Further Details";

                Smtpobj.Port = 587;
                Smtpobj.Credentials = new System.Net.NetworkCredential("veiledkashmir@gmail.com", "1forrest1");
                Smtpobj.EnableSsl = true;

                Smtpobj.Send(mail);
                MessageBox.Show("Please check your mail for further instructions.");
                this.Close();
            }
            else
            {
                error.Visible = true;
                emailtxt.Text = "";
            }
        }
    }
}
