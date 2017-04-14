namespace Veiled_Kashmir_Admin_Panel
{
    partial class research
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
            this.foodpnl = new System.Windows.Forms.Panel();
            this.ragree = new System.Windows.Forms.CheckBox();
            this.inclbler = new System.Windows.Forms.Label();
            this.inclblr = new System.Windows.Forms.Label();
            this.rvmresbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editcancelbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateresbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editdesctxt = new System.Windows.Forms.TextBox();
            this.editnametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label12 = new System.Windows.Forms.Label();
            this.resbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addresbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.resbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.back = new System.Windows.Forms.PictureBox();
            this.foodpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // foodpnl
            // 
            this.foodpnl.Controls.Add(this.ragree);
            this.foodpnl.Controls.Add(this.inclbler);
            this.foodpnl.Controls.Add(this.inclblr);
            this.foodpnl.Controls.Add(this.rvmresbtn);
            this.foodpnl.Controls.Add(this.editcancelbtn);
            this.foodpnl.Controls.Add(this.updateresbtn);
            this.foodpnl.Controls.Add(this.editdesctxt);
            this.foodpnl.Controls.Add(this.editnametxt);
            this.foodpnl.Controls.Add(this.label12);
            this.foodpnl.Controls.Add(this.resbox);
            this.foodpnl.Controls.Add(this.label9);
            this.foodpnl.Controls.Add(this.panel1);
            this.foodpnl.Controls.Add(this.cancelbtn);
            this.foodpnl.Controls.Add(this.addresbtn);
            this.foodpnl.Controls.Add(this.desctxt);
            this.foodpnl.Controls.Add(this.label2);
            this.foodpnl.Controls.Add(this.nametxt);
            this.foodpnl.Controls.Add(this.label1);
            this.foodpnl.Location = new System.Drawing.Point(12, 128);
            this.foodpnl.Name = "foodpnl";
            this.foodpnl.Size = new System.Drawing.Size(998, 420);
            this.foodpnl.TabIndex = 25;
            // 
            // ragree
            // 
            this.ragree.AutoSize = true;
            this.ragree.Location = new System.Drawing.Point(751, 328);
            this.ragree.Name = "ragree";
            this.ragree.Size = new System.Drawing.Size(182, 17);
            this.ragree.TabIndex = 8;
            this.ragree.Text = "I have entered the correct details";
            this.ragree.UseVisualStyleBackColor = true;
            this.ragree.CheckedChanged += new System.EventHandler(this.ragree_CheckedChanged);
            // 
            // inclbler
            // 
            this.inclbler.AutoSize = true;
            this.inclbler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclbler.ForeColor = System.Drawing.Color.Red;
            this.inclbler.Location = new System.Drawing.Point(800, 399);
            this.inclbler.Name = "inclbler";
            this.inclbler.Size = new System.Drawing.Size(136, 20);
            this.inclbler.TabIndex = 47;
            this.inclbler.Text = "incomplete details";
            this.inclbler.Visible = false;
            // 
            // inclblr
            // 
            this.inclblr.AutoSize = true;
            this.inclblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclblr.ForeColor = System.Drawing.Color.Red;
            this.inclblr.Location = new System.Drawing.Point(229, 399);
            this.inclblr.Name = "inclblr";
            this.inclblr.Size = new System.Drawing.Size(136, 20);
            this.inclblr.TabIndex = 46;
            this.inclblr.Text = "incomplete details";
            this.inclblr.Visible = false;
            // 
            // rvmresbtn
            // 
            this.rvmresbtn.Depth = 0;
            this.rvmresbtn.Location = new System.Drawing.Point(484, 361);
            this.rvmresbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rvmresbtn.Name = "rvmresbtn";
            this.rvmresbtn.Primary = true;
            this.rvmresbtn.Size = new System.Drawing.Size(107, 35);
            this.rvmresbtn.TabIndex = 11;
            this.rvmresbtn.Text = "Remove item";
            this.rvmresbtn.UseVisualStyleBackColor = true;
            this.rvmresbtn.Click += new System.EventHandler(this.rvmfdbtn_Click);
            // 
            // editcancelbtn
            // 
            this.editcancelbtn.Depth = 0;
            this.editcancelbtn.Location = new System.Drawing.Point(644, 361);
            this.editcancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editcancelbtn.Name = "editcancelbtn";
            this.editcancelbtn.Primary = true;
            this.editcancelbtn.Size = new System.Drawing.Size(143, 35);
            this.editcancelbtn.TabIndex = 10;
            this.editcancelbtn.Text = "cancel";
            this.editcancelbtn.UseVisualStyleBackColor = true;
            this.editcancelbtn.Click += new System.EventHandler(this.editcancelbtn_Click);
            // 
            // updateresbtn
            // 
            this.updateresbtn.Depth = 0;
            this.updateresbtn.Location = new System.Drawing.Point(793, 361);
            this.updateresbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateresbtn.Name = "updateresbtn";
            this.updateresbtn.Primary = true;
            this.updateresbtn.Size = new System.Drawing.Size(143, 35);
            this.updateresbtn.TabIndex = 9;
            this.updateresbtn.Text = "update information";
            this.updateresbtn.UseVisualStyleBackColor = true;
            this.updateresbtn.Click += new System.EventHandler(this.updateresbtn_Click);
            // 
            // editdesctxt
            // 
            this.editdesctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editdesctxt.Location = new System.Drawing.Point(484, 85);
            this.editdesctxt.Multiline = true;
            this.editdesctxt.Name = "editdesctxt";
            this.editdesctxt.Size = new System.Drawing.Size(449, 224);
            this.editdesctxt.TabIndex = 7;
            // 
            // editnametxt
            // 
            this.editnametxt.Depth = 0;
            this.editnametxt.Hint = "";
            this.editnametxt.Location = new System.Drawing.Point(540, 44);
            this.editnametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.editnametxt.Name = "editnametxt";
            this.editnametxt.PasswordChar = '\0';
            this.editnametxt.SelectedText = "";
            this.editnametxt.SelectionLength = 0;
            this.editnametxt.SelectionStart = 0;
            this.editnametxt.Size = new System.Drawing.Size(396, 23);
            this.editnametxt.TabIndex = 6;
            this.editnametxt.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(483, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Name";
            // 
            // resbox
            // 
            this.resbox.FormattingEnabled = true;
            this.resbox.Location = new System.Drawing.Point(632, 10);
            this.resbox.Name = "resbox";
            this.resbox.Size = new System.Drawing.Size(304, 21);
            this.resbox.TabIndex = 5;
            this.resbox.SelectedIndexChanged += new System.EventHandler(this.resbox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Edit Research Topic";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(443, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 401);
            this.panel1.TabIndex = 10;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Depth = 0;
            this.cancelbtn.Location = new System.Drawing.Point(73, 361);
            this.cancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Primary = true;
            this.cancelbtn.Size = new System.Drawing.Size(143, 35);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addresbtn
            // 
            this.addresbtn.Depth = 0;
            this.addresbtn.Location = new System.Drawing.Point(222, 361);
            this.addresbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addresbtn.Name = "addresbtn";
            this.addresbtn.Primary = true;
            this.addresbtn.Size = new System.Drawing.Size(143, 35);
            this.addresbtn.TabIndex = 3;
            this.addresbtn.Text = "add item";
            this.addresbtn.UseVisualStyleBackColor = true;
            this.addresbtn.Click += new System.EventHandler(this.addresbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desctxt.Location = new System.Drawing.Point(24, 85);
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(375, 243);
            this.desctxt.TabIndex = 2;
            this.desctxt.Leave += new System.EventHandler(this.desctxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // nametxt
            // 
            this.nametxt.Depth = 0;
            this.nametxt.Hint = "";
            this.nametxt.Location = new System.Drawing.Point(77, 25);
            this.nametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.SelectedText = "";
            this.nametxt.SelectionLength = 0;
            this.nametxt.SelectionStart = 0;
            this.nametxt.Size = new System.Drawing.Size(322, 23);
            this.nametxt.TabIndex = 1;
            this.nametxt.UseSystemPasswordChar = false;
            this.nametxt.Leave += new System.EventHandler(this.nametxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // resbtn
            // 
            this.resbtn.AutoSize = true;
            this.resbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resbtn.Depth = 0;
            this.resbtn.Location = new System.Drawing.Point(403, 83);
            this.resbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resbtn.Name = "resbtn";
            this.resbtn.Primary = false;
            this.resbtn.Size = new System.Drawing.Size(200, 36);
            this.resbtn.TabIndex = 22;
            this.resbtn.Text = "Edit Reseach information";
            this.resbtn.UseVisualStyleBackColor = true;
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources._9895;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(12, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 64);
            this.back.TabIndex = 21;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.foodpnl);
            this.Controls.Add(this.resbtn);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "research";
            this.Text = "research";
            this.Load += new System.EventHandler(this.research_Load);
            this.foodpnl.ResumeLayout(false);
            this.foodpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel foodpnl;
        private MaterialSkin.Controls.MaterialRaisedButton rvmresbtn;
        private MaterialSkin.Controls.MaterialRaisedButton editcancelbtn;
        private MaterialSkin.Controls.MaterialRaisedButton updateresbtn;
        private System.Windows.Forms.TextBox editdesctxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField editnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox resbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton cancelbtn;
        private MaterialSkin.Controls.MaterialRaisedButton addresbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField nametxt;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton resbtn;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label inclbler;
        private System.Windows.Forms.Label inclblr;
        private System.Windows.Forms.CheckBox ragree;
    }
}