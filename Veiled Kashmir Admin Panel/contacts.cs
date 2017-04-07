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
    public partial class contacts : Form
    {

        DBConnect obj = new DBConnect();
        String cmd;

        MySqlDataReader dr,dr2,dr3,dr4,dr5;

        private Homepage hp = null;
        public contacts(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void readcontacts()
        {
            dr = obj.Query("select name from contacts");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            deptbox.DisplayMember = "name";
            deptbox.DataSource = dt;
        }

        private void readoffices()
        {

            dr2 = obj.Query("select name from contactdetails where id ='" + deptlbl.Text + "'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            officebox.DisplayMember = "name";
            officebox.DataSource = dt;

        /*    dr2 = obj.Query("select name from contactdetails");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            officebox.DisplayMember = "name";
            officebox.DataSource = dt; */
        }

        private void contacts_Load(object sender, EventArgs e)
        {
            readcontacts();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void adddptbtn_Click(object sender, EventArgs e)
        {
            deptpnl.Visible = true;
            officepnl.Visible = false;
            readcontacts();

        }

        private void addofficebtn_Click(object sender, EventArgs e)
        {
            deptpnl.Visible = false;
            officepnl.Visible = true;

            dr3 = obj.Query("select name from contacts");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr3);
            obj.closeConnection();
            deptbox2.DisplayMember = "name";
            deptbox2.DataSource = dt;
        }

        private void adddeptbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into contacts (`name`) values ('" + deptnametxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Department added succesfully!");
            deptnametxt.Text = "";
            readcontacts();
        }

        private void updatedeptbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update contacts set `name`='" + editdepttxt.Text + "' where `name`='" + deptbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected department.");
            editdepttxt.Text = "";
            readcontacts();
        }

        private void editdeptcancelbtn_Click(object sender, EventArgs e)
        {
            editdepttxt.Text = "";
            
        }

        private void rvmdeptbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from contacts where name= '" + deptbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected department removed sucessfully.");
            readcontacts();
        }

        private void deptbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from contacts where name='" + deptbox2.Text + "'");
            dr.Read();

            deptlbl.Text = dr[0].ToString();
            
            obj.closeConnection();

            dr2 = obj.Query("select name from contactdetails where id ='" + deptlbl.Text + "'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            officebox.DisplayMember = "name";
            officebox.DataSource = dt;
        }

        private void officebox_SelectedIndexChanged(object sender, EventArgs e)
        {

            dr4 = obj.Query("select * from contactdetails where name='" + officebox.Text + "'");
            dr4.Read();
            officenametxt.Text = dr4[1].ToString();
            officenumbertxt.Text = dr4[2].ToString();
            dptlbl.Text = dr4[0].ToString();
            dptlbl.Visible = true;
            obj.closeConnection();
        }

        private void updateoffbtn_Click(object sender, EventArgs e)
        {

            cmd = ("update contactdetails set `id`='"+ dptlbl.Text + "', `name`='" + officenametxt.Text + "', `phonenumber`='" + officenumbertxt.Text + "' where `name`='" + officebox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("Details updated for the selected office.");
            officenametxt.Text = "";
            officenumbertxt.Text = "";
            dptlbl.Visible = false;
            readcontacts();
        }

        private void updatecancelbtn_Click(object sender, EventArgs e)
        {
            officenametxt.Text = "";
            officenumbertxt.Text = "";
            dptlbl.Visible = false;
            
        }

        private void deptcancelbtn_Click(object sender, EventArgs e)
        {
            deptnametxt.Text = "";
        }

        private void rvmsofficebtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from contactdetails where name= '" + officebox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected office removed sucessfully.");
            readoffices();
        }


        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editnumbertxt.Text = "";
        }

        private void addoffbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into contactdetails (`id`, `name`, `phonenumber`) values ('"+ deptlbl.Text + "', '" + editnametxt.Text + "', '" + editnumbertxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Office added succesfully!");
            editnametxt.Text = "";
            editnumbertxt.Text = "";
            readoffices();
        }

        

        private void deptbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr5 = obj.Query("select * from contacts where name='" + deptbox.Text + "'");
            dr5.Read();
            editdepttxt.Text = dr5[1].ToString();
            obj.closeConnection();
        }
    }
}
