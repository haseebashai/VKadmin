namespace Veiled_Kashmir_Admin_Panel
{
    partial class messages
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
            this.addevpnl = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inclblr = new System.Windows.Forms.Label();
            this.replycancelbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addreply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.replytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msglist = new System.Windows.Forms.ListBox();
            this.msgtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addevpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addevpnl
            // 
            this.addevpnl.Controls.Add(this.label3);
            this.addevpnl.Controls.Add(this.panel2);
            this.addevpnl.Controls.Add(this.label1);
            this.addevpnl.Controls.Add(this.msglist);
            this.addevpnl.Location = new System.Drawing.Point(12, 128);
            this.addevpnl.Name = "addevpnl";
            this.addevpnl.Size = new System.Drawing.Size(998, 420);
            this.addevpnl.TabIndex = 32;
            // 
            // back
            // 
            this.back.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources._9895;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(12, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 64);
            this.back.TabIndex = 31;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.msgtxt);
            this.panel2.Controls.Add(this.inclblr);
            this.panel2.Controls.Add(this.replycancelbtn);
            this.panel2.Controls.Add(this.addreply);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.replytxt);
            this.panel2.Location = new System.Drawing.Point(443, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 387);
            this.panel2.TabIndex = 15;
            // 
            // inclblr
            // 
            this.inclblr.AutoSize = true;
            this.inclblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclblr.ForeColor = System.Drawing.Color.Red;
            this.inclblr.Location = new System.Drawing.Point(423, 220);
            this.inclblr.Name = "inclblr";
            this.inclblr.Size = new System.Drawing.Size(105, 20);
            this.inclblr.TabIndex = 71;
            this.inclblr.Text = "Add reply first";
            this.inclblr.Visible = false;
            // 
            // replycancelbtn
            // 
            this.replycancelbtn.Depth = 0;
            this.replycancelbtn.Location = new System.Drawing.Point(423, 290);
            this.replycancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.replycancelbtn.Name = "replycancelbtn";
            this.replycancelbtn.Primary = true;
            this.replycancelbtn.Size = new System.Drawing.Size(110, 35);
            this.replycancelbtn.TabIndex = 3;
            this.replycancelbtn.Text = "cancel";
            this.replycancelbtn.UseVisualStyleBackColor = true;
            // 
            // addreply
            // 
            this.addreply.Depth = 0;
            this.addreply.Location = new System.Drawing.Point(423, 249);
            this.addreply.MouseState = MaterialSkin.MouseState.HOVER;
            this.addreply.Name = "addreply";
            this.addreply.Primary = true;
            this.addreply.Size = new System.Drawing.Size(110, 35);
            this.addreply.TabIndex = 2;
            this.addreply.Text = "send mail";
            this.addreply.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Send Mail";
            // 
            // replytxt
            // 
            this.replytxt.Location = new System.Drawing.Point(6, 181);
            this.replytxt.Multiline = true;
            this.replytxt.Name = "replytxt";
            this.replytxt.Size = new System.Drawing.Size(411, 199);
            this.replytxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Messages";
            // 
            // msglist
            // 
            this.msglist.FormattingEnabled = true;
            this.msglist.Location = new System.Drawing.Point(14, 26);
            this.msglist.Name = "msglist";
            this.msglist.Size = new System.Drawing.Size(423, 381);
            this.msglist.TabIndex = 13;
            // 
            // msgtxt
            // 
            this.msgtxt.Enabled = false;
            this.msgtxt.Location = new System.Drawing.Point(6, 3);
            this.msgtxt.Multiline = true;
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.ReadOnly = true;
            this.msgtxt.Size = new System.Drawing.Size(527, 159);
            this.msgtxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "username";
            // 
            // messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addevpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messages";
            this.Text = "messages";
            this.addevpnl.ResumeLayout(false);
            this.addevpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel addevpnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox msgtxt;
        private System.Windows.Forms.Label inclblr;
        private MaterialSkin.Controls.MaterialRaisedButton replycancelbtn;
        private MaterialSkin.Controls.MaterialRaisedButton addreply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox msglist;
        private System.Windows.Forms.Label label3;
    }
}