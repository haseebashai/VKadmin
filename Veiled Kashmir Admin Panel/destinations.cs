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

        MySqlDataReader dr,dr2;

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
            mainform mf = new mainform(this);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void addplbtn_Click(object sender, EventArgs e)
        {
            cmd= "insert into places (`name`, `description`, `location`, `explored`) values ('"+nametxt.Text+"', '"+desctxt.Text+"', '"+loctxt.Text+"', '"+exp+"')";
            obj.nonQuery(cmd);
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
            selectbox.DisplayMember = "name";
            selectbox.DataSource = dt;

            obj.closeConnection();
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
            string selected = selectbox.Text; //this.selectbox.GetItemText(this.selectbox.SelectedItem);

            dr2 = obj.Query("select * from places where name='"+selected+"'");
            dr2.Read();
            editnametxt.Text= dr2[1].ToString();
            editdesctxt.Text = dr2[2].ToString();
            editimgtxt.Text = dr2[3].ToString();
            obj.closeConnection(); 
        } 
    }
}
