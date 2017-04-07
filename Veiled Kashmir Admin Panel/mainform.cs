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
            profile pf = new profile(this,this);
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

        public void changepicture(String s)
        {
            //dp.BackgroundImage = new Bitmap(s);
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
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void signoutlbl_Enter(object sender, EventArgs e)
        {
            signoutlbl.Cursor = Cursors.Hand;
        }

    }
}
