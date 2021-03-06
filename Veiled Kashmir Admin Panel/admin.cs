﻿using System;
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

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class admin : Form
    {
        MySqlDataReader dr,dr2;
        DBConnect obj = new DBConnect();
        bool fnameok, lnameok, usernameok, emailok, passwordok, confirmok, phoneok, dobok;
        private mainform mf = null;
        private Homepage hp = null;
        public admin(Form hpcopy,Form mfcopy)
        {
            hp = hpcopy as Homepage;
            mf = mfcopy as mainform;
            InitializeComponent();
        }
        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (fnameok && lnameok && usernameok && emailok && passwordok && confirmok && phoneok && dobok && tcbox.Checked == true)
            {
                String cmd;
                inclbl.Visible = false;
                cmd = "Insert into admin values ('" + usernametxt.Text + "','" + fnametxt.Text + "','" + lnametxt.Text + "','" + emailtxt.Text + "','" + pwdtxt.Text + "','" + phonetxt.Text + "','" + yeartxt.Text + "//" + montxt.Text + "//" + daytxt.Text + "',null)";
                obj.nonQuery(cmd);

                MySqlDataReader dr;
                dr = obj.Query("select * from admin where username='" + usernametxt.Text + "'");
                dr.Read();
                MessageBox.Show("Registration Successful.\nAdmin created with the Username: " +dr[0].ToString()+"");
                obj.closeConnection();
                this.Close();
                mainform mf = new mainform(hp);
                hp.mainpnl.Controls.Clear();
                mf.TopLevel = false;
                hp.mainpnl.Controls.Add(mf);
                mf.Show();
            }
            else
            {
                inclbl.Visible = true;
            }
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

                flbl.Text = "Don't try to trick me with '";
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

                llbl.Text = "Don't try to trick me with '";
                llbl.Visible = true;
                lnameok = false;
            }
        }

        private void usernametxt_Leave(object sender, EventArgs e)
        {

            ulbl.Visible = false;
            usernameok = true;
            if (!Regex.IsMatch(usernametxt.Text, @"^[a-zA-Z0-9_-]+$"))
            {
                ulbl.Text = "Only _ and - special characters allowed";
                ulbl.Visible = true;
                usernameok = false;
                tick.Visible = false;
            }
            else if (usernametxt.Text.Length > 25)
            {
                ulbl.Text = "Username is too long";
                ulbl.Visible = true;
                usernameok = false;
                tick.Visible = false;
            }
            else if (usernametxt.Text.Length < 5)
            {
                ulbl.Text = "Username is too short";
                ulbl.Visible = true;
                usernameok = false;
                tick.Visible = false;
            }
            else
            {
                int i = obj.Count("Select Count(*) from admin where username='" + usernametxt.Text + "';");
                if (i != 0)
                {
                    ulbl.Text = "Username already exists";
                    ulbl.Visible = true;
                    usernameok = false;
                    tick.Visible = false;
                }
                else
                {
                    tick.Visible = true;
                }
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
                    elbl.Text = "Email already exists";
                    elbl.Visible = true;
                    emailok = false;
                }
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            readadmins();
            rvmpnl1.Visible = false;
            cnfrvmbtn.Visible = false;
            cnfpwdtxt.Visible = false;
            rvmbtn.Visible = true;

        }

        private void adminbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dr = obj.Query("select * from admin where username='"+adminbox.Text+"'");
            dr.Read();
            fname.Text = dr[1].ToString();
            lname.Text = dr[2].ToString();
            username.Text = "@ "+dr[0].ToString()+"";
            email.Text = dr[3].ToString();
            obj.closeConnection();
            rvmpnl1.Visible = true;
            cnfrvmbtn.Visible = false;
            cnfpwdtxt.Visible = false;
            rvmbtn.Visible = true;

        }

        private void rvmbtn_Click(object sender, EventArgs e)
        {
            if (adminbox.Items.Count == 1)
                MessageBox.Show("Atleast one admin necessary.");


            else
            {

                rvmbtn.Visible = false;
                cnfrvmbtn.Visible = true;
                cnfpwdtxt.Visible = true;
            }
        }

        public void readadmins()
        {


            dr = obj.Query("select username from admin");
            DataTable dt = new DataTable();
            dt.Columns.Add("username", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            adminbox.DisplayMember = "username";
            adminbox.DataSource = dt;
        }

        public void readusers()
        {
            dr = obj.Query("select username from users");
            DataTable dt = new DataTable();
            dt.Columns.Add("username", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            userlist.DisplayMember = "username";
            userlist.DataSource = dt;
        }

        private void admin_Load(object sender, EventArgs e)
        {
          
        }

        private void userlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from users where username='" + userlist.Text + "'");
            dr.Read();
            userfname.Text = dr[1].ToString();
            userlname.Text = dr[2].ToString();
            userusername.Text = "@ "+dr[0].ToString()+"";
            useremail.Text = dr[3].ToString();
            obj.closeConnection();
            cnfrvmuserbtn.Visible = false;
            cnfusertxt.Visible = false;
            cnfusertxt.Text = "";
            rvmuser.Visible = true;
            delpnl.Visible = true;
        }

        private void usercancelbtn_Click(object sender, EventArgs e)
        {
            readusers();
            delpnl.Visible = false;
            cnfrvmuserbtn.Visible = false;
            cnfusertxt.Visible = false;
            rvmuser.Visible = true;
        }

        private void rvmuser_Click(object sender, EventArgs e)
        {
            rvmuser.Visible = false;
            cnfrvmuserbtn.Visible = true;
            cnfusertxt.Visible = true;
        }

        private void cnfrvmuserbtn_Click(object sender, EventArgs e)
        {
            dr2 = obj.Query("Select * from admin where username='" + userinfo.username + "';");
            dr2.Read();

            if (dr2[4].Equals(cnfusertxt.Text))
            {
                obj.closeConnection();
                string cmd;
                cmd = ("delete from users where username= '" + userlist.Text + "'");
                obj.nonQuery(cmd);
                MessageBox.Show("User removed sucessfully.");
                readusers();

                delpnl.Visible = false;
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD");
                cnfusertxt.Text = "";
            }
            obj.closeConnection();
        }

        private void addcancelbtn_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void cnfrvmbtn_Click(object sender, EventArgs e)
        {
            
                dr2 = obj.Query("Select * from admin where username='" + userinfo.username + "';");
                dr2.Read();

                if (dr2[4].Equals(cnfpwdtxt.Text))
                {
                    obj.closeConnection();
                    string cmd;
                    cmd = ("delete from admin where username= '" + adminbox.Text + "'");
                    obj.nonQuery(cmd);
                    MessageBox.Show("Admin removed sucessfully.");
                    readadmins();

                    rvmpnl1.Visible = false;
                }
                else
                {
                    MessageBox.Show("WRONG PASSWORD");
                    cnfpwdtxt.Text = "";
                }
                obj.closeConnection();
            

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

        private void daytxt_Click(object sender, EventArgs e)
        {
            daytxt.Text = "";
        }

        private void montxt_Click(object sender, EventArgs e)
        {
            montxt.Text = "";
        }

        private void yeartxt_Click(object sender, EventArgs e)
        {
            yeartxt.Text = "";
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

        private void passlbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password should be 8-15 characters long and must contain at least 1 letter and 1 number");
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
    }
}
