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
    public partial class culture : Form
    {
        DBConnect obj = new DBConnect();
        String cmd;

        MySqlDataReader dr, dr2, dr3;
        private Homepage hp = null;
        public culture(Form hpcopy)
        {
            hp = hpcopy as Homepage;
            InitializeComponent();
        }

        private void readfood()
        {
            dr = obj.Query("select name from food");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            foodbox.DisplayMember = "name";
            foodbox.DataSource = dt;
        }

        private void readwords()
        {
            dr2 = obj.Query("select name from wildlife where class='2'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr2);
            obj.closeConnection();
            wordbox.DisplayMember = "name";
            wordbox.DataSource = dt;
        }

        private void readphrases()
        {
            dr3 = obj.Query("select name from wildlife where class='1'");
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Load(dr3);
            obj.closeConnection();
            phrasebox.DisplayMember = "name";
            phrasebox.DataSource = dt;
        }

        private void foodbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from food where name='" + foodbox.Text + "'");
            dr.Read();
            editnametxt.Text = dr[1].ToString();
            editdesctxt.Text = dr[2].ToString();
            editloctxt.Text = dr[3].ToString();
            obj.closeConnection();
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            foodpnl.Visible = true;
            wordspnl.Visible = false;
            phrasespnl.Visible = false;

            readfood();
        }

        private void addwordsbtn_Click(object sender, EventArgs e)
        {
            foodpnl.Visible = false;
            wordspnl.Visible = true;
            phrasespnl.Visible = false;

            readwords();
        }

        private void addphrasesbtn_Click(object sender, EventArgs e)
        {
            foodpnl.Visible = false;
            wordspnl.Visible = false;
            phrasespnl.Visible = true;

            readphrases();
        }

        private void addfdbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into food (`name`, `description`, `location`) values ('" + nametxt.Text + "', '" + desctxt.Text + "', '" + loctxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Food item added succesfully!");
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";
            readfood();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            desctxt.Text = "";
            loctxt.Text = "";

        }

        private void updatefdbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update food set `name`='" + editnametxt.Text + "', `description`='" + editdesctxt.Text + "', `pic`='" + editloctxt.Text + "' where `name`='" + foodbox.Text + "';");
            obj.nonQuery(cmd);

            MessageBox.Show("Food item updated succesfully!");
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editloctxt.Text = "";
            readfood();
        }

        private void editcancelbtn_Click(object sender, EventArgs e)
        {
            editnametxt.Text = "";
            editdesctxt.Text = "";
            editloctxt.Text = "";

            readfood();
        }

        private void rvmfdbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from food where name= '" + foodbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected food item removed sucessfully.");
            readfood();
        }

        private void addwordbtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into dictionary (`keyword`, `meaning`) values ('" + wordtxt.Text + "', '" + meaningtxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Word entry added succesfully!");
            wordtxt.Text = "";
            meaningtxt.Text = "";

            readwords();
        }

        private void wordcancelbtn_Click(object sender, EventArgs e)
        {
            wordtxt.Text = "";
            meaningtxt.Text = "";

            readwords();
        }

        private void wordbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from dictionary where keyword='" + wordbox.Text + "'");
            dr.Read();
            editwordtxt.Text = dr[0].ToString();
            editmeaningtxt.Text = dr[1].ToString();
            obj.closeConnection();
        }

        private void updatewordbtn_Click(object sender, EventArgs e)
        {
            cmd = ("update dictionary set `keyword`='" + editwordtxt.Text + "', `meaning`='" + editmeaningtxt.Text + "' where `keyword`='" + wordbox.Text + "'");
            obj.nonQuery(cmd);

            MessageBox.Show("Word entry updated succesfully!");
            editwordtxt.Text = "";
            editmeaningtxt.Text = "";
            
            readwords();
        }

        private void rvmwordbtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from dictionary where keyword= '" + wordbox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected Word removed sucessfully.");
            readwords();
        }

        private void addphrasebtn_Click(object sender, EventArgs e)
        {
            cmd = "insert into phrases (`phrases`, `meaning`) values ('" + phrasetxt.Text + "', '" + phraseentxt.Text + "')";
            obj.nonQuery(cmd);

            MessageBox.Show("New Phrase added succesfully!");
            phrasetxt.Text = "";
            phraseentxt.Text = "";

            readphrases();
        }

        private void phrasecancelbtn_Click(object sender, EventArgs e)
        {
            phrasetxt.Text = "";
            phraseentxt.Text = "";

            readphrases();
        }

        private void phrasebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = obj.Query("select * from phrases where phrases='" + phrasebox.Text + "'");
            dr.Read();
            editphrasetxt.Text = dr[1].ToString();
            editphraseentxt.Text = dr[2].ToString();
            obj.closeConnection();
        }

        private void updatephrasebtn_Click(object sender, EventArgs e)
        {
            cmd = ("update phrases set `phrases`='" + editphrasetxt.Text + "', `meaning`='" + editphraseentxt.Text + "' where `phrases`='" + phrasebox.Text + "'");
            obj.nonQuery(cmd);

            MessageBox.Show("Phrase updated succesfully!");
            editphrasetxt.Text = "";
            editphraseentxt.Text = "";

            readphrases();
        }

        private void editphrasecancelbtn_Click(object sender, EventArgs e)
        {
            editphrasetxt.Text = "";
            editphraseentxt.Text = "";

            readphrases();
        }

        private void rvmphrasebtn_Click(object sender, EventArgs e)
        {
            cmd = ("delete from phrases where phrases= '" + phrasebox.Text + "';");
            obj.nonQuery(cmd);
            MessageBox.Show("selected Phrase removed sucessfully.");
            readphrases();
        }

        private void culture_Load(object sender, EventArgs e)
        {
            readfood();
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
