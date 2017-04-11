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

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class business : Form
    {
        DBConnect obj = new DBConnect();
        String cmd,s;
        bool status, nametxtok, desctxtok, editnametxtok, editdesctxtok;
        MySqlDataReader dr,dr2;

        private Homepage hp = null;
        public business(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void business_Load(object sender, EventArgs e)
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

        private void addbusbtn_Click(object sender, EventArgs e)
        {
            if (nametxtok && desctxtok && status == true)
            {
                cmd = "insert into business (`name`, `description`, `pic`) values ('" + nametxt.Text + "', '" + desctxt.Text + "', 'C:\\Vkashmir\\business\\" + nametxt.Text + ".jpg')";
                dpbox.BackgroundImage.Save("C:\\Vkashmir\\business\\" + nametxt.Text + ".jpg");
                obj.nonQuery(cmd);

                MessageBox.Show("New Business added succesfully!");
                nametxt.Text = "";
                desctxt.Text = "";
                dpbox.BackgroundImage = null;
            }
            else
                inclbl.Visible = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            removepnl.Visible = false;
            addpnl.Visible = true;
            shoppnl.Visible = false;
        }

        private void readbusiness()
        {
            dr = obj.Query("select name from business");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox.DisplayMember = "name";
            selectbox.DataSource = dt;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = true;
            removepnl.Visible = false;
            addpnl.Visible = false;
            shoppnl.Visible = false;

            readbusiness();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            removepnl.Visible = true;
            addpnl.Visible = false;
            shoppnl.Visible = false;

            dr = obj.Query("select name from business");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox2.DisplayMember = "name";
            selectbox2.DataSource = dt;

            obj.closeConnection();
        }
        private void readshops()
        {
            dr2 = obj.Query("select name from businessdetails where bid ='" + bidlbl.Text + "'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            shopbox.DisplayMember = "name";
            shopbox.DataSource = dt;
        }

        private void selectbox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dr = obj.Query("select * from business where name='" + selectbox3.Text + "'");
            dr.Read();
            
            bidlbl.Text = dr[0].ToString();
            inclbls.Visible = false;
            addshoppnl.Visible = true;

            obj.closeConnection();

            readshops();

        }
        private void addshopdetbtn_Click(object sender, EventArgs e)
        {
            if (shopnametxt.Text.Contains("'") || shopnametxt.Text.Contains("\\") || shopnotxt.Text.Contains("'") || shopnotxt.Text.Contains("\\") || shopaddtxt.Text.Contains("'") || shopaddtxt.Text.Contains("\\") || shopemailtxt.Text.Contains("'") || shopemailtxt.Text.Contains("\\"))
            {
                MessageBox.Show("Details cannot contain ' & \\");

            }
            else
            {
                if (shopnametxt.Text != "" && shopnotxt.Text != "" && shopaddtxt.Text != "" && shopemailtxt.Text != "")
                {
                    cmd = "insert into businessdetails (`bid`, `name`, `location`, `phone`, `email`) values ('" + bidlbl.Text + "', '" + shopnametxt.Text + "', '" + shopaddtxt.Text + "', '" + shopnotxt.Text + "', '" + shopemailtxt.Text + "')";
                    obj.nonQuery(cmd);

                    MessageBox.Show("New Shop added succesfully!");
                    shopnametxt.Text = "";
                    shopaddtxt.Text = "";
                    shopnotxt.Text = "";
                    shopemailtxt.Text = "";
                    readshops();
                }
                else
                    inclbls.Visible = true;
            }
        }

        private void shopbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr2 = obj.Query("select * from businessdetails where name='" + shopbox.Text + "'");
            dr2.Read();
            shopeditnametxt.Text = dr2[2].ToString();
            shopeditaddresstxt.Text = dr2[3].ToString();
            shopeditnotxt.Text = dr2[4].ToString();
            shopeditemailtxt.Text = dr2[5].ToString();
            bideditlbl.Text = dr2[1].ToString();
            rvmpnl.Visible = true;



            obj.closeConnection();
        }

        private void addshopbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            removepnl.Visible = false;
            addpnl.Visible = false;
            shoppnl.Visible = true;

            dr = obj.Query("select name from business");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox3.DisplayMember = "name";
            selectbox3.DataSource = dt;
        }

        private void selectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from business where name='" + selectbox.Text + "'");
            dr.Read();
            editpanel.Visible = true;
            editnametxt.Text = dr[1].ToString();
            editdesctxt.Text = dr[2].ToString();
            edpbox.BackgroundImage = new Bitmap(dr[3].ToString());
            inclbl2.Visible = false;
            
            obj.closeConnection();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (editnametxt.Text.Contains("'") || editnametxt.Text.Contains("\\"))
                MessageBox.Show("Name cannot contain ' & \\");
            else
            {
                if (agree.Checked && editnametxtok && editdesctxtok == true)
                {
                    if (status == true)
                    {
                        cmd = ("update business set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "', `pic`='C:\\Vkashmir\\business\\" + editnametxt.Text + ".jpg' where `name`='" + selectbox.Text + "';");
                        dpbox.BackgroundImage.Save("C:\\Vkashmir\\business\\" + editnametxt.Text + ".jpg");

                    }
                    else
                    {
                        cmd = ("update business set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "' where `name`='" + selectbox.Text + "';");

                    }
                    obj.nonQuery(cmd);
                    MessageBox.Show("Details updated for the selected business.");
                    editnametxt.Text = "";
                    editdesctxt.Text = "";
                    agree.Checked = false;
                    readbusiness();
                }
                else
                {
                    inclbl2.Visible = true;
                }
            }
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";
            edpbox.BackgroundImage = null;
            agree.Checked = false;
            

        }

        private void selectbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from business where name='" + selectbox2.Text + "'");
            dr.Read();
            buslbl.Text = dr[1].ToString();
            picbox.BackgroundImage = new Bitmap(dr[3].ToString());
            rvmpnl.Visible = true;



            obj.closeConnection();
        }

        private void rmvbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from business where name= '" + selectbox2.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected business removed sucessfully.");
            rvmpnl.Visible = false;
            readbusiness();
           
        }

        private void shoprvmbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from businessdetails where name= '" + shopbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected shop removed sucessfully.");
                shopeditnametxt.Text = "";
                shopeditnotxt.Text = "";
                shopeditaddresstxt.Text = "";
                shopeditemailtxt.Text = "";
            readshops();
            


        }

        private void updateshopbtn_Click(object sender, EventArgs e)
        {
            if (shopeditnametxt.Text.Contains("'") || shopeditnametxt.Text.Contains("\\") || shopeditnotxt.Text.Contains("'") || shopeditnotxt.Text.Contains("\\") || shopeditaddresstxt.Text.Contains("'") || shopeditaddresstxt.Text.Contains("\\") || shopeditemailtxt.Text.Contains("'") || shopeditemailtxt.Text.Contains("\\"))
            {
                MessageBox.Show("Details cannot contain ' & \\");
            }
            else
            {
                if (shopeditnametxt.Text != "" && shopeditnotxt.Text != "" && shopeditaddresstxt.Text != "" && shopeditemailtxt.Text != "")
                {
                    cmd = ("update businessdetails set `bid`='" + bideditlbl.Text + "', `name`='" + shopeditnametxt.Text + "', `location`='" + shopeditaddresstxt.Text + "', `phone`='" + shopeditnotxt.Text + "', `email`='" + shopeditemailtxt.Text + "' where `name`='" + shopbox.Text + "'");
                    obj.nonQuery(cmd);
                    MessageBox.Show("Details updated for the selected shop.");
                    shopeditnametxt.Text = "";
                    shopeditnotxt.Text = "";
                    shopeditaddresstxt.Text = "";
                    shopeditemailtxt.Text = "";
                    readshops();
                }
                else
                    inclbles.Visible = true;

            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            desctxt.Text = "";
            dpbox.BackgroundImage = null;
        }

        private void shopcancelbtn_Click(object sender, EventArgs e)
        {
            shopnametxt.Text = "";
            shopnotxt.Text = "";
            shopaddtxt.Text = ""; 
            shopemailtxt.Text = "";
            inclbls.Visible = false;
            phnlbl.Visible = false;
        }

        private void editshopcancelbtn_Click(object sender, EventArgs e)
        {
            shopeditnametxt.Text = "";
            shopeditnotxt.Text = "";
            shopeditaddresstxt.Text = "";
            shopeditemailtxt.Text = "";
            bideditlbl.Visible = false;
            phnelbl.Visible = false;
        }

        private void edpbox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                Image myimage = new Bitmap(s);
                dpbox.BackgroundImage = myimage;
                dpbox.BackgroundImageLayout = ImageLayout.Stretch;
                status = true;

            }
        }

        private void shopeditnotxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(shopeditnotxt.Text, @"^[0-9]{10}$"))
            {

                phnelbl.Visible = true;
                shopeditnotxt.Text = "";
            }
        }

        private void editnametxt_Leave(object sender, EventArgs e)
        {
            if (editnametxt.Text.Contains("\\") || editnametxt.Text.Contains("'"))
            {
                MessageBox.Show("Name cannot contain special characters");
                editnametxt.Text = "";
                editnametxt.Focus();
            }

        }

        private void agree_CheckedChanged(object sender, EventArgs e)
        {
            if (editnametxt.Text == "" && editdesctxt.Text == "")
            {
                editnametxtok = false;
                editdesctxtok = false;
            }
            else
            {
                editnametxtok = true;
                editdesctxtok = true;
            }
        }

        private void nametxt_Leave(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
                nametxtok = false;
            else
                nametxtok = true;
            if (nametxt.Text.Contains("\\") || nametxt.Text.Contains("'"))
            {
                MessageBox.Show("Name cannot contain special characters");
                nametxt.Text = "";
                nametxt.Focus();
            }

        }

        private void desctxt_Leave(object sender, EventArgs e)
        {
            if (desctxt.Text == "")
                desctxtok = false;
            else
                desctxtok = true;
        }

        private void dpbox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                Image myimage = new Bitmap(s);
                dpbox.BackgroundImage = myimage;
                dpbox.BackgroundImageLayout = ImageLayout.Stretch;
                status = true;

            }
        }

        private void shopnotxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(shopnotxt.Text, @"^[0-9]{10}$"))
            {
               
                phnlbl.Visible = true;
                shopnotxt.Text = "";
            }
        }

        private void rvmcancel_Click(object sender, EventArgs e)
        {
            rvmpnl.Visible = false;
        }

        
        

}
}
