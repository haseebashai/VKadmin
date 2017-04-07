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
    public partial class events : Form
    {
        DBConnect obj = new DBConnect();
        String cmd;

        MySqlDataReader dr;
        private Homepage hp = null;

        public events(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }


        private void readevents()
        {
            dr = obj.Query("select name from events");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            eventbox.DisplayMember = "name";
            eventbox.DataSource = dt;
        }
        private void addevbtn_Click(object sender, EventArgs e)
        {

            StringBuilder s = new StringBuilder(nametxt.Text);
            s.Replace("'", "\\'");
            s = new StringBuilder(loctxt.Text);
            s.Replace("'", "\\'");
            cmd = "Insert into events(name, location, eventstart, eventend, user) values ('" + nametxt.Text + "','" + loctxt.Text + "','" + eventstart.Value.ToString("yyyy-MM-dd HH:mm") + "','" + eventend.Value.ToString("yyyy-MM-dd HH:mm") + "','Admin')";
            obj.nonQuery(cmd);
            MessageBox.Show("Event added sucessfully.");

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            loctxt.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void addeventbtn_Click(object sender, EventArgs e)
        {
            addevpnl.Visible = true;
            editevpnl.Visible = false;

        }

        private void eventbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from events where name='" + eventbox.Text + "'");
            dr.Read();
            editeventtxt.Text = dr[1].ToString();
            editeventloctxt.Text = dr[2].ToString();
            userlbl.Text = "by " + dr[5].ToString();
            editpnl.Visible = true;
            obj.closeConnection();
        }

        private void updatevbtn_Click(object sender, EventArgs e)
        {
            string admin = " - edited by admin";
            StringBuilder s1 = new StringBuilder(editeventtxt.Text);
            s1.Replace("'", "\\'");
            s1 = new StringBuilder(editeventloctxt.Text);
            s1.Replace("'", "\\'");
            cmd = ("update events set `name`='" + editeventtxt.Text + admin + "', `location`='" + editeventloctxt.Text + "', `eventstart`='" + editdatestart.Value.ToString("yyyy-MM-dd HH:mm") + "', `eventend`='" + editdateend.Value.ToString("yyyy-MM-dd HH:mm") + "' where `name`='" + eventbox.Text + "'");
            obj.nonQuery(cmd);

            MessageBox.Show("Event updated succesfully!");
            editeventtxt.Text = "";
            editeventloctxt.Text = "";

            readevents();
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editeventtxt.Text = "";
            editeventloctxt.Text = "";
        }

        private void rvmevbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from events where name= '" + eventbox.Text + "'");
            obj.nonQuery(cmd);
            MessageBox.Show("selected Event removed sucessfully.");
        }

        private void editeventbtn_Click(object sender, EventArgs e)
        {
            addevpnl.Visible = false;
            editevpnl.Visible = true;
            readevents();
        }

        

        private void events_Load(object sender, EventArgs e)
        {
            eventstart.Format = DateTimePickerFormat.Custom;
            eventstart.CustomFormat = "MM/dd/yyyy hh:mm";
            eventend.Format = DateTimePickerFormat.Custom;
            eventend.CustomFormat = "MM/dd/yyyy hh:mm";

           
        }
    }
}
