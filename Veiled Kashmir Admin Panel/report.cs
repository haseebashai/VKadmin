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
    public partial class report : Form
    {
        private Homepage hp = null;
        public report(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(hp);
            mf.TopLevel = false;
            hp.mainpnl.Controls.Clear();
            hp.mainpnl.Controls.Add(mf);
            mf.Show();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = false;
            reportViewer1.Visible = true;
            reportViewer3.Visible = false;
            using(vkashmirEntities1 db=new vkashmirEntities1())
            {
                placeBindingSource.DataSource = db.places.ToList();
                reportViewer1.RefreshReport();
            }
        }

        private void usrbtn_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer2.Visible = true;
            reportViewer3.Visible = false;
            using(vkashmirEntities2 db2=new vkashmirEntities2())
            {
                userBindingSource.DataSource = db2.users.ToList();
                reportViewer2.RefreshReport();
            }
        }

        private void shpbtn_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
            reportViewer3.Visible = true;
            using(vkashmirEntities3 db3=new vkashmirEntities3())
            {
                businessdetailBindingSource.DataSource = db3.businessdetails.ToList();
                reportViewer3.RefreshReport();
            }
        }

        
    }
}
