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
    public partial class research : Form
    {
        DBConnect obj = new DBConnect();
        String cmd;

        MySqlDataReader dr;
        private Homepage hp = null;
        public research(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void readresearch()
        {
            dr = obj.Query("select name from research");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            resbox.DisplayMember = "name";
            resbox.DataSource = dt;
        }

        private void research_Load(object sender, EventArgs e)
        {
            readresearch();
        }

        private void rvmfdbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from research where name= '" + resbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected Research entry removed sucessfully.");
            readresearch();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            readresearch();
        }

        private void addresbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into research (`name`, `description`) values ('" + nametxt.Text + "', '" + desctxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Research entry added succesfully!");
            nametxt.Text = "";
            desctxt.Text = "";
            
            readresearch();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            desctxt.Text = "";

            readresearch();
        }

        private void resbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from research where name='" + resbox.Text + "'");
            dr.Read();
            editnametxt.Text = dr[1].ToString();
            editdesctxt.Text = dr[2].ToString();
            obj.closeConnection();
        }

        private void updateresbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update research set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "' where `name`='" + resbox.Text + "'");
            obj.nonQuery(cmd);

            MessageBox.Show("Research entry updated succesfully!");
            editnametxt.Text = "";
            editdesctxt.Text = "";
            
            readresearch();
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";

            readresearch();
        }
    }
}
