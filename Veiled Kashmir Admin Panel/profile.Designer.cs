namespace Veiled_Kashmir_Admin_Panel
{
    partial class profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inclbl = new System.Windows.Forms.Label();
            this.usrlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updatebtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dlbl = new System.Windows.Forms.Label();
            this.plbl = new System.Windows.Forms.Label();
            this.confirmlbl = new System.Windows.Forms.Label();
            this.elbl = new System.Windows.Forms.Label();
            this.confirmtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.yeartxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.montxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.daytxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.phonetxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phonelbl = new MaterialSkin.Controls.MaterialLabel();
            this.pwdtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lnametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pwdlbl = new MaterialSkin.Controls.MaterialLabel();
            this.emaillbl = new MaterialSkin.Controls.MaterialLabel();
            this.usernamelbl = new MaterialSkin.Controls.MaterialLabel();
            this.lnamelbl = new MaterialSkin.Controls.MaterialLabel();
            this.fnametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fnamelbl = new MaterialSkin.Controls.MaterialLabel();
            this.llbl = new System.Windows.Forms.Label();
            this.flbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpbox = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // inclbl
            // 
            this.inclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclbl.ForeColor = System.Drawing.Color.Red;
            this.inclbl.Location = new System.Drawing.Point(694, 418);
            this.inclbl.Name = "inclbl";
            this.inclbl.Size = new System.Drawing.Size(122, 13);
            this.inclbl.TabIndex = 121;
            this.inclbl.Text = "Form Incomplete";
            this.inclbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inclbl.Visible = false;
            // 
            // usrlbl
            // 
            this.usrlbl.AutoSize = true;
            this.usrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlbl.ForeColor = System.Drawing.Color.Gray;
            this.usrlbl.Location = new System.Drawing.Point(332, 205);
            this.usrlbl.Name = "usrlbl";
            this.usrlbl.Size = new System.Drawing.Size(85, 13);
            this.usrlbl.TabIndex = 120;
            this.usrlbl.Text = "Static Username";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Depth = 0;
            this.cancelbtn.Location = new System.Drawing.Point(597, 434);
            this.cancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Primary = true;
            this.cancelbtn.Size = new System.Drawing.Size(92, 31);
            this.cancelbtn.TabIndex = 119;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Depth = 0;
            this.updatebtn.Location = new System.Drawing.Point(697, 434);
            this.updatebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Primary = true;
            this.updatebtn.Size = new System.Drawing.Size(119, 31);
            this.updatebtn.TabIndex = 118;
            this.updatebtn.Text = "update details";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // dlbl
            // 
            this.dlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlbl.ForeColor = System.Drawing.Color.Red;
            this.dlbl.Location = new System.Drawing.Point(691, 322);
            this.dlbl.Name = "dlbl";
            this.dlbl.Size = new System.Drawing.Size(122, 13);
            this.dlbl.TabIndex = 116;
            this.dlbl.Text = "Enter Valid Date";
            this.dlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dlbl.Visible = false;
            // 
            // plbl
            // 
            this.plbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plbl.ForeColor = System.Drawing.Color.Red;
            this.plbl.Location = new System.Drawing.Point(307, 317);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(192, 14);
            this.plbl.TabIndex = 115;
            this.plbl.Text = "Number incorrect";
            this.plbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plbl.Visible = false;
            // 
            // confirmlbl
            // 
            this.confirmlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmlbl.ForeColor = System.Drawing.Color.Red;
            this.confirmlbl.Location = new System.Drawing.Point(663, 266);
            this.confirmlbl.Name = "confirmlbl";
            this.confirmlbl.Size = new System.Drawing.Size(152, 12);
            this.confirmlbl.TabIndex = 113;
            this.confirmlbl.Text = "Password does not match";
            this.confirmlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmlbl.Visible = false;
            // 
            // elbl
            // 
            this.elbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elbl.ForeColor = System.Drawing.Color.Red;
            this.elbl.Location = new System.Drawing.Point(591, 219);
            this.elbl.Name = "elbl";
            this.elbl.Size = new System.Drawing.Size(222, 10);
            this.elbl.TabIndex = 112;
            this.elbl.Text = "email ID not valid";
            this.elbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elbl.Visible = false;
            // 
            // confirmtxt
            // 
            this.confirmtxt.Depth = 0;
            this.confirmtxt.Hint = "";
            this.confirmtxt.Location = new System.Drawing.Point(654, 244);
            this.confirmtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.PasswordChar = '*';
            this.confirmtxt.SelectedText = "";
            this.confirmtxt.SelectionLength = 0;
            this.confirmtxt.SelectionStart = 0;
            this.confirmtxt.Size = new System.Drawing.Size(162, 23);
            this.confirmtxt.TabIndex = 102;
            this.confirmtxt.UseSystemPasswordChar = false;
            this.confirmtxt.Leave += new System.EventHandler(this.confirmtxt_Leave);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(577, 248);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 18);
            this.materialLabel4.TabIndex = 93;
            this.materialLabel4.Text = "Retype";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(756, 300);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(12, 18);
            this.materialLabel3.TabIndex = 94;
            this.materialLabel3.Text = "/";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(713, 300);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(12, 18);
            this.materialLabel2.TabIndex = 95;
            this.materialLabel2.Text = "/";
            // 
            // yeartxt
            // 
            this.yeartxt.Depth = 0;
            this.yeartxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.yeartxt.Hint = "";
            this.yeartxt.Location = new System.Drawing.Point(771, 299);
            this.yeartxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.PasswordChar = '\0';
            this.yeartxt.SelectedText = "";
            this.yeartxt.SelectionLength = 0;
            this.yeartxt.SelectionStart = 0;
            this.yeartxt.Size = new System.Drawing.Size(42, 23);
            this.yeartxt.TabIndex = 107;
            this.yeartxt.Text = "YYYY";
            this.yeartxt.UseSystemPasswordChar = false;
            this.yeartxt.Leave += new System.EventHandler(this.yeartxt_Leave);
            // 
            // montxt
            // 
            this.montxt.Depth = 0;
            this.montxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.montxt.Hint = "";
            this.montxt.Location = new System.Drawing.Point(729, 299);
            this.montxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.montxt.Name = "montxt";
            this.montxt.PasswordChar = '\0';
            this.montxt.SelectedText = "";
            this.montxt.SelectionLength = 0;
            this.montxt.SelectionStart = 0;
            this.montxt.Size = new System.Drawing.Size(27, 23);
            this.montxt.TabIndex = 106;
            this.montxt.Text = "MM";
            this.montxt.UseSystemPasswordChar = false;
            this.montxt.Leave += new System.EventHandler(this.montxt_Leave);
            // 
            // daytxt
            // 
            this.daytxt.BackColor = System.Drawing.Color.White;
            this.daytxt.Depth = 0;
            this.daytxt.ForeColor = System.Drawing.Color.Black;
            this.daytxt.Hint = "";
            this.daytxt.Location = new System.Drawing.Point(689, 299);
            this.daytxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.daytxt.Name = "daytxt";
            this.daytxt.PasswordChar = '\0';
            this.daytxt.SelectedText = "";
            this.daytxt.SelectionLength = 0;
            this.daytxt.SelectionStart = 0;
            this.daytxt.Size = new System.Drawing.Size(21, 23);
            this.daytxt.TabIndex = 105;
            this.daytxt.Text = "DD";
            this.daytxt.UseSystemPasswordChar = false;
            this.daytxt.Leave += new System.EventHandler(this.daytxt_Leave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(593, 300);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 18);
            this.materialLabel1.TabIndex = 97;
            this.materialLabel1.Text = "DOB";
            // 
            // phonetxt
            // 
            this.phonetxt.Depth = 0;
            this.phonetxt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.phonetxt.Hint = "";
            this.phonetxt.Location = new System.Drawing.Point(332, 295);
            this.phonetxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.PasswordChar = '\0';
            this.phonetxt.SelectedText = "";
            this.phonetxt.SelectionLength = 0;
            this.phonetxt.SelectionStart = 0;
            this.phonetxt.Size = new System.Drawing.Size(166, 23);
            this.phonetxt.TabIndex = 104;
            this.phonetxt.UseSystemPasswordChar = false;
            this.phonetxt.Leave += new System.EventHandler(this.phonetxt_Leave);
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Depth = 0;
            this.phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phonelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phonelbl.Location = new System.Drawing.Point(206, 298);
            this.phonelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(108, 18);
            this.phonelbl.TabIndex = 87;
            this.phonelbl.Text = "Phone Number";
            // 
            // pwdtxt
            // 
            this.pwdtxt.Depth = 0;
            this.pwdtxt.Hint = "";
            this.pwdtxt.Location = new System.Drawing.Point(333, 244);
            this.pwdtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.SelectedText = "";
            this.pwdtxt.SelectionLength = 0;
            this.pwdtxt.SelectionStart = 0;
            this.pwdtxt.Size = new System.Drawing.Size(167, 23);
            this.pwdtxt.TabIndex = 101;
            this.pwdtxt.UseSystemPasswordChar = false;
            this.pwdtxt.Leave += new System.EventHandler(this.pwdtxt_Leave);
            // 
            // emailtxt
            // 
            this.emailtxt.Depth = 0;
            this.emailtxt.Hint = "";
            this.emailtxt.Location = new System.Drawing.Point(654, 197);
            this.emailtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.SelectedText = "";
            this.emailtxt.SelectionLength = 0;
            this.emailtxt.SelectionStart = 0;
            this.emailtxt.Size = new System.Drawing.Size(162, 23);
            this.emailtxt.TabIndex = 100;
            this.emailtxt.UseSystemPasswordChar = false;
            this.emailtxt.Leave += new System.EventHandler(this.emailtxt_Leave);
            // 
            // lnametxt
            // 
            this.lnametxt.Depth = 0;
            this.lnametxt.Hint = "";
            this.lnametxt.Location = new System.Drawing.Point(334, 145);
            this.lnametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.PasswordChar = '\0';
            this.lnametxt.SelectedText = "";
            this.lnametxt.SelectionLength = 0;
            this.lnametxt.SelectionStart = 0;
            this.lnametxt.Size = new System.Drawing.Size(252, 23);
            this.lnametxt.TabIndex = 99;
            this.lnametxt.UseSystemPasswordChar = false;
            this.lnametxt.Leave += new System.EventHandler(this.lnametxt_Leave);
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Depth = 0;
            this.pwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwdlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pwdlbl.Location = new System.Drawing.Point(237, 248);
            this.pwdlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(75, 18);
            this.pwdlbl.TabIndex = 96;
            this.pwdlbl.Text = "Password";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Depth = 0;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emaillbl.Location = new System.Drawing.Point(566, 201);
            this.emaillbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(63, 18);
            this.emaillbl.TabIndex = 91;
            this.emaillbl.Text = "Email ID";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Depth = 0;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usernamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernamelbl.Location = new System.Drawing.Point(235, 201);
            this.usernamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(77, 18);
            this.usernamelbl.TabIndex = 90;
            this.usernamelbl.Text = "Username";
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Depth = 0;
            this.lnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lnamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnamelbl.Location = new System.Drawing.Point(230, 150);
            this.lnamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(80, 18);
            this.lnamelbl.TabIndex = 89;
            this.lnamelbl.Text = "Last Name";
            // 
            // fnametxt
            // 
            this.fnametxt.Depth = 0;
            this.fnametxt.Hint = "";
            this.fnametxt.Location = new System.Drawing.Point(332, 101);
            this.fnametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.PasswordChar = '\0';
            this.fnametxt.SelectedText = "";
            this.fnametxt.SelectionLength = 0;
            this.fnametxt.SelectionStart = 0;
            this.fnametxt.Size = new System.Drawing.Size(253, 23);
            this.fnametxt.TabIndex = 98;
            this.fnametxt.UseSystemPasswordChar = false;
            this.fnametxt.Leave += new System.EventHandler(this.fnametxt_Leave);
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Depth = 0;
            this.fnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fnamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fnamelbl.Location = new System.Drawing.Point(229, 105);
            this.fnamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(81, 18);
            this.fnamelbl.TabIndex = 88;
            this.fnamelbl.Text = "First Name";
            // 
            // llbl
            // 
            this.llbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl.ForeColor = System.Drawing.Color.Red;
            this.llbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbl.Location = new System.Drawing.Point(407, 163);
            this.llbl.Name = "llbl";
            this.llbl.Size = new System.Drawing.Size(180, 22);
            this.llbl.TabIndex = 111;
            this.llbl.Text = "Last Name cannot contain Numbers";
            this.llbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbl.Visible = false;
            // 
            // flbl
            // 
            this.flbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flbl.ForeColor = System.Drawing.Color.Red;
            this.flbl.Location = new System.Drawing.Point(407, 120);
            this.flbl.Name = "flbl";
            this.flbl.Size = new System.Drawing.Size(182, 19);
            this.flbl.TabIndex = 110;
            this.flbl.Text = "First Name cannot contain Numbers";
            this.flbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flbl.Visible = false;
            // 
            // passlbl
            // 
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.Color.Red;
            this.passlbl.Location = new System.Drawing.Point(335, 261);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(166, 25);
            this.passlbl.TabIndex = 114;
            this.passlbl.Text = "Invalid Password";
            this.passlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passlbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 109;
            this.label2.Text = "Upload Image";
            // 
            // dpbox
            // 
            this.dpbox.BackColor = System.Drawing.Color.White;
            this.dpbox.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources.user_20;
            this.dpbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dpbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dpbox.Location = new System.Drawing.Point(683, 94);
            this.dpbox.Name = "dpbox";
            this.dpbox.Size = new System.Drawing.Size(75, 75);
            this.dpbox.TabIndex = 108;
            this.dpbox.TabStop = false;
            this.dpbox.Click += new System.EventHandler(this.dpbox_Click);
            this.dpbox.MouseHover += new System.EventHandler(this.dpbox_MouseHover);
            // 
            // back
            // 
            this.back.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources._9895;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(12, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 64);
            this.back.TabIndex = 8;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.inclbl);
            this.Controls.Add(this.usrlbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dlbl);
            this.Controls.Add(this.plbl);
            this.Controls.Add(this.confirmlbl);
            this.Controls.Add(this.elbl);
            this.Controls.Add(this.confirmtxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.montxt);
            this.Controls.Add(this.daytxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dpbox);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.llbl);
            this.Controls.Add(this.flbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label inclbl;
        private System.Windows.Forms.Label usrlbl;
        private MaterialSkin.Controls.MaterialRaisedButton cancelbtn;
        private MaterialSkin.Controls.MaterialRaisedButton updatebtn;
        private System.Windows.Forms.Label dlbl;
        private System.Windows.Forms.Label plbl;
        private System.Windows.Forms.Label confirmlbl;
        private System.Windows.Forms.Label elbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmtxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField yeartxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField montxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField daytxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox dpbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField phonetxt;
        private MaterialSkin.Controls.MaterialLabel phonelbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField pwdtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField lnametxt;
        private MaterialSkin.Controls.MaterialLabel pwdlbl;
        private MaterialSkin.Controls.MaterialLabel emaillbl;
        private MaterialSkin.Controls.MaterialLabel usernamelbl;
        private MaterialSkin.Controls.MaterialLabel lnamelbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField fnametxt;
        private MaterialSkin.Controls.MaterialLabel fnamelbl;
        private System.Windows.Forms.Label llbl;
        private System.Windows.Forms.Label flbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}