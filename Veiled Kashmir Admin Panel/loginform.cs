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
    public partial class loginform : Form
    {
        private Homepage hp = null;
        public loginform(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }



        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void usrtxt_Enter(object sender, EventArgs e)
        {
            usrtxt.Text = "";
        }

        private void pwdtxt_Enter(object sender, EventArgs e)
        {
            pwdtxt.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }
    }
}
