namespace Veiled_Kashmir_Admin_Panel
{
    partial class mainform
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
            this.signoutlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.revbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.conbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.evtbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.frmbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.culbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.desbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.busbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.wldbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.signinlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilebtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signoutlbl
            // 
            this.signoutlbl.AutoSize = true;
            this.signoutlbl.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signoutlbl.Location = new System.Drawing.Point(951, 9);
            this.signoutlbl.Name = "signoutlbl";
            this.signoutlbl.Size = new System.Drawing.Size(55, 16);
            this.signoutlbl.TabIndex = 0;
            this.signoutlbl.Text = "SIGN OUT";
            this.signoutlbl.Visible = false;
            this.signoutlbl.Click += new System.EventHandler(this.signoutlbl_Click);
            this.signoutlbl.MouseHover += new System.EventHandler(this.signoutlbl_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.revbtn);
            this.groupBox1.Controls.Add(this.conbtn);
            this.groupBox1.Controls.Add(this.evtbtn);
            this.groupBox1.Controls.Add(this.frmbtn);
            this.groupBox1.Controls.Add(this.resbtn);
            this.groupBox1.Controls.Add(this.culbtn);
            this.groupBox1.Controls.Add(this.desbtn);
            this.groupBox1.Controls.Add(this.busbtn);
            this.groupBox1.Controls.Add(this.wldbtn);
            this.groupBox1.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(125, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 481);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Content";
            // 
            // revbtn
            // 
            this.revbtn.Depth = 0;
            this.revbtn.Location = new System.Drawing.Point(18, 415);
            this.revbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.revbtn.Name = "revbtn";
            this.revbtn.Primary = true;
            this.revbtn.Size = new System.Drawing.Size(233, 42);
            this.revbtn.TabIndex = 11;
            this.revbtn.Text = "reviews";
            this.revbtn.UseVisualStyleBackColor = true;
            this.revbtn.Click += new System.EventHandler(this.revbtn_Click);
            // 
            // conbtn
            // 
            this.conbtn.Depth = 0;
            this.conbtn.Location = new System.Drawing.Point(18, 367);
            this.conbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.conbtn.Name = "conbtn";
            this.conbtn.Primary = true;
            this.conbtn.Size = new System.Drawing.Size(233, 42);
            this.conbtn.TabIndex = 10;
            this.conbtn.Text = "contacts";
            this.conbtn.UseVisualStyleBackColor = true;
            this.conbtn.Click += new System.EventHandler(this.conbtn_Click);
            // 
            // evtbtn
            // 
            this.evtbtn.Depth = 0;
            this.evtbtn.Location = new System.Drawing.Point(18, 319);
            this.evtbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.evtbtn.Name = "evtbtn";
            this.evtbtn.Primary = true;
            this.evtbtn.Size = new System.Drawing.Size(233, 42);
            this.evtbtn.TabIndex = 9;
            this.evtbtn.Text = "events";
            this.evtbtn.UseVisualStyleBackColor = true;
            this.evtbtn.Click += new System.EventHandler(this.evtbtn_Click);
            // 
            // frmbtn
            // 
            this.frmbtn.Depth = 0;
            this.frmbtn.Location = new System.Drawing.Point(18, 271);
            this.frmbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.frmbtn.Name = "frmbtn";
            this.frmbtn.Primary = true;
            this.frmbtn.Size = new System.Drawing.Size(233, 42);
            this.frmbtn.TabIndex = 8;
            this.frmbtn.Text = "forum";
            this.frmbtn.UseVisualStyleBackColor = true;
            this.frmbtn.Click += new System.EventHandler(this.frmbtn_Click);
            // 
            // resbtn
            // 
            this.resbtn.Depth = 0;
            this.resbtn.Location = new System.Drawing.Point(18, 223);
            this.resbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resbtn.Name = "resbtn";
            this.resbtn.Primary = true;
            this.resbtn.Size = new System.Drawing.Size(233, 42);
            this.resbtn.TabIndex = 7;
            this.resbtn.Text = "research";
            this.resbtn.UseVisualStyleBackColor = true;
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // culbtn
            // 
            this.culbtn.Depth = 0;
            this.culbtn.Location = new System.Drawing.Point(18, 175);
            this.culbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.culbtn.Name = "culbtn";
            this.culbtn.Primary = true;
            this.culbtn.Size = new System.Drawing.Size(233, 42);
            this.culbtn.TabIndex = 6;
            this.culbtn.Text = "culture";
            this.culbtn.UseVisualStyleBackColor = true;
            this.culbtn.Click += new System.EventHandler(this.culbtn_Click);
            // 
            // desbtn
            // 
            this.desbtn.Depth = 0;
            this.desbtn.Location = new System.Drawing.Point(18, 31);
            this.desbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.desbtn.Name = "desbtn";
            this.desbtn.Primary = true;
            this.desbtn.Size = new System.Drawing.Size(233, 42);
            this.desbtn.TabIndex = 3;
            this.desbtn.Text = "destinations";
            this.desbtn.UseVisualStyleBackColor = true;
            this.desbtn.Click += new System.EventHandler(this.desbtn_Click);
            // 
            // busbtn
            // 
            this.busbtn.Depth = 0;
            this.busbtn.Location = new System.Drawing.Point(18, 79);
            this.busbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.busbtn.Name = "busbtn";
            this.busbtn.Primary = true;
            this.busbtn.Size = new System.Drawing.Size(233, 42);
            this.busbtn.TabIndex = 4;
            this.busbtn.Text = "business";
            this.busbtn.UseVisualStyleBackColor = true;
            this.busbtn.Click += new System.EventHandler(this.busbtn_Click);
            // 
            // wldbtn
            // 
            this.wldbtn.Depth = 0;
            this.wldbtn.Location = new System.Drawing.Point(18, 127);
            this.wldbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.wldbtn.Name = "wldbtn";
            this.wldbtn.Primary = true;
            this.wldbtn.Size = new System.Drawing.Size(233, 42);
            this.wldbtn.TabIndex = 5;
            this.wldbtn.Text = "wildlife";
            this.wldbtn.UseVisualStyleBackColor = true;
            this.wldbtn.Click += new System.EventHandler(this.wldbtn_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(37, 76);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(125, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "add sub-admins";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(37, 148);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(103, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "remove user";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(280, 76);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(152, 36);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "remove sub-admins";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(653, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Controls";
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Location = new System.Drawing.Point(280, 148);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(113, 36);
            this.materialFlatButton9.TabIndex = 8;
            this.materialFlatButton9.Text = "send message";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // signinlbl
            // 
            this.signinlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlbl.Location = new System.Drawing.Point(758, 25);
            this.signinlbl.Name = "signinlbl";
            this.signinlbl.Size = new System.Drawing.Size(252, 25);
            this.signinlbl.TabIndex = 9;
            this.signinlbl.Text = "Welcome, admin";
            this.signinlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signinlbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.profilebtn);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.materialFlatButton9);
            this.panel1.Controls.Add(this.materialFlatButton3);
            this.panel1.Location = new System.Drawing.Point(485, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 192);
            this.panel1.TabIndex = 10;
            // 
            // profilebtn
            // 
            this.profilebtn.AutoSize = true;
            this.profilebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilebtn.Depth = 0;
            this.profilebtn.Location = new System.Drawing.Point(37, 6);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.profilebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Primary = false;
            this.profilebtn.Size = new System.Drawing.Size(98, 36);
            this.profilebtn.TabIndex = 9;
            this.profilebtn.Text = "edit profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signinlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signoutlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signoutlbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton desbtn;
        private MaterialSkin.Controls.MaterialRaisedButton busbtn;
        private MaterialSkin.Controls.MaterialRaisedButton wldbtn;
        private MaterialSkin.Controls.MaterialRaisedButton revbtn;
        private MaterialSkin.Controls.MaterialRaisedButton conbtn;
        private MaterialSkin.Controls.MaterialRaisedButton evtbtn;
        private MaterialSkin.Controls.MaterialRaisedButton frmbtn;
        private MaterialSkin.Controls.MaterialRaisedButton resbtn;
        private MaterialSkin.Controls.MaterialRaisedButton culbtn;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private System.Windows.Forms.Label signinlbl;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton profilebtn;
    }
}