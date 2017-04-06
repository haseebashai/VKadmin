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

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class business : Form
    {
        DBConnect obj = new DBConnect();
        String cmd;

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
            cmd = "insert into business (`name`, `description`, `pic`) values ('" + nametxt.Text + "', '" + desctxt.Text + "', '" + loctxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Business added succesfully!");
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            removepnl.Visible = false;
            addpnl.Visible = true;
            shoppnl.Visible = false;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = true;
            removepnl.Visible = false;
            addpnl.Visible = false;
            shoppnl.Visible = false;

            dr = obj.Query("select name from business");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox.DisplayMember = "name";
            selectbox.DataSource = dt;
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

        private void selectbox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dr = obj.Query("select * from business where name='" + selectbox3.Text + "'");
            dr.Read();
            
            bidlbl.Text = dr[0].ToString();
            addshoppnl.Visible = true;

            obj.closeConnection();

            dr2 = obj.Query("select name from businessdetails where bid ='"+bidlbl.Text+"'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            shopbox.DisplayMember = "name";
            shopbox.DataSource = dt;

        }
        private void addshopdetbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into businessdetails (`bid`, `name`, `location`, `phone`, `email`) values ('" + bidlbl.Text + "', '" + shopnametxt.Text + "', '" + shopaddtxt.Text + "', '" + shopnotxt.Text+"', '" + shopemailtxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Shop added succesfully!");
            shopnametxt.Text = "";
            shopaddtxt.Text = "";
            shopnotxt.Text = "";
            shopemailtxt.Text = "";
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
            editimgtxt.Text = dr[3].ToString();
            
            obj.closeConnection();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            cmd = ("update business set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "', `pic`='" + editimgtxt.Text + "' where `name`='" + selectbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected business.");
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editimgtxt.Text = "";
            
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editimgtxt.Text = "";
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
           
        }

        private void shoprvmbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from businessdetails where name= '" + shopbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected shop removed sucessfully.");
            editshoppnl.Refresh();
        }

        private void updateshopbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update businessdetails set `bid`='" + bideditlbl.Text + "', `name`='" + shopeditnametxt.Text + "', `location`='" + shopeditaddresstxt.Text + "', `phone`='" + shopeditnotxt.Text + "', `email`='" + shopeditemailtxt.Text + "' where `name`='" + shopbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected shop.");
        }

        private void rvmcancel_Click(object sender, EventArgs e)
        {
            rvmpnl.Visible = false;
        }

        

        
    }
}
