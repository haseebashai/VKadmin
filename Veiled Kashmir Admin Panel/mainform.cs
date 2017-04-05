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
            destinations ds = new destinations(this);
            ds.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(ds);
            ds.Show();
        }

        private void busbtn_Click(object sender, EventArgs e)
        {
            business bs = new business(this);
            bs.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(bs);
            bs.Show();
        }

        private void wldbtn_Click(object sender, EventArgs e)
        {
            wildlife wl = new wildlife(this);
            wl.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(wl);
            wl.Show();
        }

        private void culbtn_Click(object sender, EventArgs e)
        {
            culture cl = new culture(this);
            cl.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(cl);
            cl.Show();
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            research rs = new research(this);
            rs.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rs);
            rs.Show();
        }

        private void frmbtn_Click(object sender, EventArgs e)
        {
            forum fr = new forum(this);
            fr.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(fr);
            fr.Show();
        }

        private void evtbtn_Click(object sender, EventArgs e)
        {
            events ev = new events(this);
            ev.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(ev);
            ev.Show();
        }

        private void conbtn_Click(object sender, EventArgs e)
        {
            contacts cn = new contacts(this);
            cn.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(cn);
            cn.Show();
        }

        private void revbtn_Click(object sender, EventArgs e)
        {
            reviews rv = new reviews(this);
            rv.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(rv);
            rv.Show();
        }
    }
}
