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
using System.Text.RegularExpressions;
using System.IO;

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class profile : Form
    {
        bool fnameok = true, lnameok = true, emailok = true, passwordok = true, confirmok = true, phoneok = true, dobok = true;
        DBConnect obj = new DBConnect();
        
        MySqlDataReader dr;
        private Homepage hp = null;
        private mainform mf = null;

        

        public profile(Form hpcopy, Form mfcopy)
        {
            hp = hpcopy as Homepage;
            mf = mfcopy as mainform;

            InitializeComponent();
            MySqlDataReader dr;
            dr = obj.Query("Select * from admin where username='" + userinfo.username + "';");
            dr.Read();
            fnametxt.Text = dr[1].ToString();
            lnametxt.Text = dr[2].ToString();
            emailtxt.Text = dr[3].ToString();
            pwdtxt.Text = dr[4].ToString();
            confirmtxt.Text = dr[4].ToString();
            phonetxt.Text = dr[5].ToString();
            String temp = dr[6].ToString();
            daytxt.Text = temp.Substring(0, 2);
            montxt.Text = temp.Substring(3, 2);
            yeartxt.Text = temp.Substring(6, 4);
            usrlbl.Text = userinfo.username;

            obj.closeConnection();
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }
        private void fnametxt_Leave(object sender, EventArgs e)
        {
            flbl.Visible = false;
            fnameok = true;
            if (Regex.IsMatch(fnametxt.Text, @"[0-9]"))
            {
                flbl.Text = "That can't possibly be your first name";
                flbl.Visible = true;
                fnameok = false;
            }
            if (fnametxt.Text.Length > 25 || fnametxt.Text.Length < 2)

            {
                flbl.Text = "Thats not even a name";
                flbl.Visible = true;
                fnameok = false;
            }
            if (fnametxt.Text.Contains("'"))
            {

                flbl.Text = "Don't try to trick me";
                flbl.Visible = true;
                fnameok = false;
            }

        }

        private void lnametxt_Leave(object sender, EventArgs e)
        {
            llbl.Visible = false;
            lnameok = true;
            if (Regex.IsMatch(lnametxt.Text, @"[0-9]"))
            {
                llbl.Text = "Write your real last name";
                llbl.Visible = true;
                lnameok = false;
            }
            if (lnametxt.Text.Length > 25 || lnametxt.Text.Length < 2)

            {
                llbl.Text = "I don't believe it";
                llbl.Visible = true;
                lnameok = false;
            }
            if (lnametxt.Text.Contains("'"))
            {

                llbl.Text = "Enter a valid last name";
                llbl.Visible = true;
                lnameok = false;
            }
        }

       

        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (fnameok && lnameok && emailok && passwordok && confirmok && phoneok && dobok == true)
            {
                String cmd;
                inclbl.Visible = false;
                cmd = "Update admin set fname='" + fnametxt.Text + "',lname='" + lnametxt.Text + "',email='" + emailtxt.Text + "',password='" + pwdtxt.Text + "',contact='" + phonetxt.Text + "',DOB='" + yeartxt.Text + "//" + montxt.Text + "//" + daytxt.Text + "' where username='" + userinfo.username + "';";
                obj.nonQuery(cmd);
                MessageBox.Show("Details Successfully Updated.");

                 }
            else
                      {
                            inclbl.Visible = true;
                      } 
                }
            
        

        private void daytxt_Leave(object sender, EventArgs e)
        {
            dlbl.Visible = false;
            dobok = true;
            DateTime dt;
            if (!DateTime.TryParse(daytxt.Text + "/" + montxt.Text + "/" + yeartxt.Text, new System.Globalization.CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt))
            {
                dlbl.Visible = true;
                dobok = false;
            }
            if (dt > System.DateTime.Today)
            {
                dlbl.Visible = true;
                dobok = false;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

       

        private void montxt_Leave(object sender, EventArgs e)
        {
            dlbl.Visible = false;
            dobok = true;
            DateTime dt;
            if (!DateTime.TryParse(daytxt.Text + "/" + montxt.Text + "/" + yeartxt.Text, new System.Globalization.CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt))
            {
                dlbl.Visible = true;
                dobok = false;
            }
            if (dt > System.DateTime.Today)
            {
                dlbl.Visible = true;
                dobok = false;
            }
        }

        private void yeartxt_Leave(object sender, EventArgs e)
        {
            dlbl.Visible = false;
            dobok = true;
            DateTime dt;
            if (!DateTime.TryParse(daytxt.Text + "/" + montxt.Text + "/" + yeartxt.Text, new System.Globalization.CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt))
            {
                dlbl.Visible = true;
                dobok = false;
            }
            if (dt > System.DateTime.Today)
            {
                dlbl.Visible = true;
                dobok = false;
            }
        }

        private void pwdtxt_Leave(object sender, EventArgs e)
        {
            passlbl.Visible = false;
            passwordok = true;
            if (!Regex.IsMatch(pwdtxt.Text, @"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{8,15})$"))
            {

                passlbl.Visible = true;
                passwordok = false;
            }

            if (!pwdtxt.Text.Equals(confirmtxt.Text))

            {
                if (!confirmtxt.Text.Equals(""))
                {
                    confirmlbl.Visible = true;
                    confirmok = false;
                }
            }
            else
            {
                confirmlbl.Visible = false;
                confirmok = true;
            }
            if (pwdtxt.Text.Contains("'"))
            {

                passlbl.Visible = true;
                passwordok = false;
            }
        }

        private void confirmtxt_Leave(object sender, EventArgs e)
        {
            confirmlbl.Visible = false;
            confirmok = true;
            if (!pwdtxt.Text.Equals(confirmtxt.Text))
            {
                confirmlbl.Visible = true;
                confirmok = false;
            }
        }

        private void phonetxt_Leave(object sender, EventArgs e)
        {
            plbl.Visible = false;
            phoneok = true;
            if (!Regex.IsMatch(phonetxt.Text, @"^[0-9]{10}$"))
            {
                plbl.Text = "I won't call, I promise";
                plbl.Visible = true;
                phoneok = false;
            }
        }


        private void emailtxt_Leave(object sender, EventArgs e)
        {
            elbl.Visible = false;
            emailok = true;
            if (!Regex.IsMatch(emailtxt.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$"))
            {

                elbl.Visible = true;
                emailok = false;
            }
            else
            {
                int i = obj.Count("Select Count(*) from admin where email='" + emailtxt.Text + "';");
                if (i != 0)
                {
                    dr = obj.Query("Select * from admin where email='" + emailtxt.Text + "';");
                    dr.Read();
                    if (!dr[0].ToString().Equals(userinfo.username))
                    {
                        elbl.Text = "Email already exists";
                        elbl.Visible = true;
                        emailok = false;
                    }
                    obj.closeConnection();
                }
            }
        }
    }
}
