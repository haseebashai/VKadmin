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
    public partial class wildlife : Form
    {

        DBConnect obj = new DBConnect();
        String cmd;

        MySqlDataReader dr,dr2,dr3;
        private Homepage hp = null;
        public wildlife(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void readanimals()
        {
            dr = obj.Query("select name from animals");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            animalbox.DisplayMember = "name";
            animalbox.DataSource = dt;
        }

        private void readparks()
        {
            dr2 = obj.Query("select name from wildlife where class='2'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            parkbox.DisplayMember = "name";
            parkbox.DataSource = dt;
        }

        private void readsanc()
        {
            dr3 = obj.Query("select name from wildlife where class='1'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr3);
            obj.closeConnection();
            sancbox.DisplayMember = "name";
            sancbox.DataSource = dt;
        }

        private void wildlife_Load(object sender, EventArgs e)
        {
            readanimals();
        }

        private void addanimalsbtn_Click(object sender, EventArgs e)
        {
            animalpnl.Visible = true;
            parkpnl.Visible = false;
            sancpnl.Visible = false;

            readanimals();


        }

        private void addparksbtn_Click(object sender, EventArgs e)
        {
            animalpnl.Visible = false;
            parkpnl.Visible = true;
            sancpnl.Visible = false;

            readparks();

        }

        private void addsanctuarybtn_Click(object sender, EventArgs e)
        {
            animalpnl.Visible = false;
            parkpnl.Visible = false;
            sancpnl.Visible = true;

            readsanc();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void addanbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into animals (`name`, `description`, `pic`) values ('" + nametxt.Text + "', '" + desctxt.Text + "', '" + loctxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Animal added succesfully!");
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
        }

        private void animalbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from animals where name='" + animalbox.Text + "'");
            dr.Read();
            editnametxt.Text = dr[1].ToString();
            editdesctxt.Text = dr[2].ToString();
            editloctxt.Text = dr[3].ToString();
            obj.closeConnection();
        }

        private void updateanbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update animals set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "', `pic`='" + editloctxt.Text + "' where `name`='" + animalbox.Text + "';");
            obj.nonQuery(cmd);

            MessageBox.Show("Animal updated succesfully!");
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editloctxt.Text = "";
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editloctxt.Text = "";
        }

        private void rvmanbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from animals where name= '" + animalbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected animal removed sucessfully.");
        }

        private void parkbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            dr2 = obj.Query("select * from wildlife where name='" + parkbox.Text + "'");
            dr2.Read();
    
            editparktxt.Text = dr2[1].ToString();
            editparkdesctxt.Text = dr2[2].ToString();
            editparkloctxt.Text = dr2[3].ToString();
            obj.closeConnection();
        }

        private void rvmparkbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from wildlife where name= '" + parkbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected park removed sucessfully.");
            readparks();
        }

        private void updateparkbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update wildlife set `name`='" + editparktxt.Text + "', `description`='" + editparkdesctxt.Text + "', `pic`='" + editparkloctxt.Text + "', `class`='2' where `name`='" + parkbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected park.");
            editparktxt.Text = "";
            editparkdesctxt.Text = "";
            editparkloctxt.Text = "";
        }

        private void parkcancelbtn_Click(object sender, EventArgs e)
        {
            parknametxt.Text = "";
            parkdesctxt.Text = "";
            parkloctxt.Text = "";
        }

        private void addsancbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into wildlife (`name`, `description`, `pic`, `class`) values ('" + sancnametxt.Text + "', '" + sancdesctxt.Text + "', '" + sancloctxt.Text + "', '1')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Sanctuary added succesfully!");
            sancnametxt.Text = "";
            sancdesctxt.Text = "";
            sancloctxt.Text = "";
            readsanc();
        }

        private void sanccancelbtn_Click(object sender, EventArgs e)
        {
            sancnametxt.Text = "";
            sancdesctxt.Text = "";
            sancloctxt.Text = "";
        }

        private void sancrvmbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from wildlife where name= '" + sancbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected sanctuary removed sucessfully.");
            readsanc();
        }

        private void sancbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr3 = obj.Query("select * from wildlife where name='" + sancbox.Text + "'");
            dr3.Read();

            editsanctnametxt.Text = dr3[1].ToString();
            editsancdesctxt.Text = dr3[2].ToString();
            editsancloctxt.Text = dr3[3].ToString();
            obj.closeConnection();
        }

        private void updatesancbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update wildlife set `name`='" + editsanctnametxt.Text + "', `description`='" + editsancdesctxt.Text + "', `pic`='" + editsancloctxt.Text + "', `class`='1' where `name`='" + sancbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected sanctuary.");
            editsanctnametxt.Text = "";
            editsancdesctxt.Text = "";
            editsancloctxt.Text = "";
        }

        private void sanceditcancelbtn_Click(object sender, EventArgs e)
        {
            editsanctnametxt.Text = "";
            editsancdesctxt.Text = "";
            editsancloctxt.Text = "";
        }

        private void editparkcancelbtn_Click(object sender, EventArgs e)
        {
            editparktxt.Text = "";
            editparkdesctxt.Text = "";
            editparkloctxt.Text = "";
        }

        private void addparkbtn_Click(object sender, EventArgs e)
        {

            cmd = "insert into wildlife (`name`, `description`, `pic`, `class`) values ('" + parknametxt.Text + "', '" + parkdesctxt.Text + "', '" + parkloctxt.Text + "', '2')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Park added succesfully!");
            parknametxt.Text = "";
            parkdesctxt.Text = "";
            parkloctxt.Text = "";
            readparks();
        }
    }
}
