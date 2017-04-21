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
    public partial class messages : Form
    {
        private mainform mf = null;
        private Homepage hp = null;

        public messages(Form mfcopy, Form hpcopy)
        {
            mf = mfcopy as mainform;
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }
    }
}
