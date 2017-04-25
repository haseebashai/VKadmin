using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veiled_Kashmir_Admin_Panel
{
    public partial class mainform : Form
    {
        private Homepage hp = null;
        public mainform(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            if (userinfo.loggedin == true)
                signout();
                changelabel("Welcome, " + userinfo.username +"");

        }

        private void desbtn_Click(object sender, EventArgs e)
        {
            destinations ds = new destinations(hp);
            ds.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(ds);
            ds.Show();
        }

        private void busbtn_Click(object sender, EventArgs e)
        {
            business bs = new business(hp);
            bs.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(bs);
            bs.Show();
        }

        private void wldbtn_Click(object sender, EventArgs e)
        {
            wildlife wl = new wildlife(hp);
            wl.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(wl);
            wl.Show();
        }

        private void culbtn_Click(object sender, EventArgs e)
        {
            culture cl = new culture(hp);
            cl.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(cl);
            cl.Show();
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            research rs = new research(hp);
            rs.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rs);
            rs.Show();
        }

        private void frmbtn_Click(object sender, EventArgs e)
        {
            forum fr = new forum(hp);
            fr.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(fr);
            fr.Show();
        }

        private void evtbtn_Click(object sender, EventArgs e)
        {
            events ev = new events(hp);
            ev.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(ev);
            ev.Show();
        }

        private void conbtn_Click(object sender, EventArgs e)
        {
            contacts cn = new contacts(hp);
            cn.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(cn);
            cn.Show();
        }

        private void revbtn_Click(object sender, EventArgs e)
        {
            reviews rv = new reviews(hp);
            rv.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rv);
            rv.Show();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profile pf = new profile(hp,this);
            pf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(pf);
            pf.Show();
        }
        public void changelabel(String welcome)
        {
            signinlbl.Text = welcome;

            signinlbl.Visible = true;

        }
        public void signout()
        {
            signoutlbl.Visible = true;
        }

        private void signoutlbl_Click(object sender, EventArgs e)
        {
            userinfo.loggedin = false;
            userinfo.username = "";           
            this.Close();
            MessageBox.Show("Logged out sucessfully.\nPlease Log in to continue");

            loginform lg = new loginform(hp,this);
            hp.mainpnl.Controls.Clear();
            lg.TopLevel = false;
            hp.mainpnl.Controls.Add(lg);
            lg.Show();
        }

        private void signoutlbl_Enter(object sender, EventArgs e)
        {
            signoutlbl.Cursor = Cursors.Hand;
        }

        private void addadminbtn_Click(object sender, EventArgs e)
        {
            admin add = new admin(hp,this);
            add.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(add);
            add.addpnl.Visible = true;
            add.Show();
        }

        private void rvmadminbtn_Click(object sender, EventArgs e)
        {
            admin rvm = new admin(hp,this);
            rvm.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rvm);
            rvm.rvmpnl.Visible = true;
            rvm.readadmins();
            rvm.Show();
        }

        private void rvmuserbtn_Click(object sender, EventArgs e)
        {
            admin rvmuser = new admin(hp, this);
            rvmuser.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rvmuser);
            rvmuser.userpnl.Visible = true;
            rvmuser.readusers();
            rvmuser.Show();
        }

        private void sendmsgbtn_Click(object sender, EventArgs e)
        {
            notification nt = new notification(this,hp);
            nt.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(nt);
            nt.Show();

        }

        private void logo_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void msgbtn_Click(object sender, EventArgs e)
        {
           messages msg = new messages(this, hp);
            msg.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(msg);
            msg.Show();
        }
    }
}
