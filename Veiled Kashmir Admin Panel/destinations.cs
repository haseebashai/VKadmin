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
    public partial class destinations : Form
    {
        DBConnect obj = new DBConnect();
        String cmd;
        int exp;

        MySqlDataReader dr;

        private Homepage hp = null;
        public destinations(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void destinations_Load(object sender, EventArgs e)
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

        private void addplbtn_Click(object sender, EventArgs e)
        {
            cmd= "insert into places (`name`, `description`, `location`, `explored`) values ('"+nametxt.Text+"', '"+desctxt.Text+"', '"+loctxt.Text+"', '"+exp+"')";
            obj.nonQuery(cmd);
            
            MessageBox.Show("New Place added succesfully!");
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
            exbtn.Checked = false;
            unexbtn.Checked = false;

        }

        private void exbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (exbtn.Checked)
                exp = 1;
        }

        private void unexbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (unexbtn.Checked)
                exp = 0;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            addpnl.Visible = false;
            editpnl.Visible = true;
            removepnl.Visible = false;
            
            dr = obj.Query("select name from places");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox.DisplayMember = "name";
            selectbox.DataSource = dt;
            

           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            removepnl.Visible = false;
            addpnl.Visible = true;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
            addpnl.Visible = false;
            removepnl.Visible = true;

            dr = obj.Query("select name from places");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            selectbox2.DisplayMember = "name";
            selectbox2.DataSource = dt;

            obj.closeConnection();

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
            exbtn.Checked = false;
            unexbtn.Checked = false;

        }

        private void selectbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            dr = obj.Query("select * from places where name='"+selectbox.Text+"'");
            dr.Read();
                editnametxt.Text = dr[1].ToString();
                editdesctxt.Text = dr[2].ToString();
                editimgtxt.Text = dr[3].ToString();
                exp = Convert.ToInt32(dr[4]);
                if (exp == 1)
                    exbtn.Checked = true;
                else
                    unexbtn.Checked = true;

            
            obj.closeConnection(); 
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            cmd = ("update places set `name`='"+editnametxt.Text+"', `description`='"+editdesctxt.Text+"', `location`='"+editimgtxt.Text+"', `explored`='"+exp+"' where `name`='"+selectbox.Text+"';");
            obj.nonQuery(cmd);
            
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editimgtxt.Text = "";
            exbtn.Checked = false;
            unexbtn.Checked = false;
        }

        private void selectbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from places where name='" + selectbox2.Text + "'");
            dr.Read();
            placelbl.Text = dr[1].ToString();
            picbox.BackgroundImage= new Bitmap(dr[3].ToString());
            rvmpnl.Visible = true;



            obj.closeConnection();
        }
        private void rmvbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from places where name= '" + selectbox2.Text + "';");
            obj.nonQuery(cmd);

        }

        private void rvmcancel_Click(object sender, EventArgs e)
        {
            rvmpnl.Visible = false;

        }
    }
}
