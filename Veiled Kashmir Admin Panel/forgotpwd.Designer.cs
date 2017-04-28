namespace Veiled_Kashmir_Admin_Panel
{
    partial class forgotpwd
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
            this.error = new System.Windows.Forms.Label();
            this.loginbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.emailtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Coral;
            this.error.Location = new System.Drawing.Point(225, 103);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(145, 13);
            this.error.TabIndex = 54;
            this.error.Text = "Email is not registered with us";
            this.error.Visible = false;
            // 
            // loginbtn
            // 
            this.loginbtn.Depth = 0;
            this.loginbtn.Location = new System.Drawing.Point(284, 130);
            this.loginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Primary = true;
            this.loginbtn.Size = new System.Drawing.Size(83, 25);
            this.loginbtn.TabIndex = 53;
            this.loginbtn.TabStop = false;
            this.loginbtn.Text = "Send Mail";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Depth = 0;
            this.emailtxt.Hint = "";
            this.emailtxt.Location = new System.Drawing.Point(12, 77);
            this.emailtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.SelectedText = "";
            this.emailtxt.SelectionLength = 0;
            this.emailtxt.SelectionStart = 0;
            this.emailtxt.Size = new System.Drawing.Size(355, 23);
            this.emailtxt.TabIndex = 51;
            this.emailtxt.TabStop = false;
            this.emailtxt.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, -44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 321);
            this.panel1.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 1);
            this.panel3.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(378, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 170);
            this.panel2.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 1);
            this.panel5.TabIndex = 46;
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources.turn_on;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Location = new System.Drawing.Point(351, 5);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(25, 25);
            this.closebtn.TabIndex = 47;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(111, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Enter your registered Email id";
            // 
            // forgotpwd
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgotpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpwd";
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private MaterialSkin.Controls.MaterialRaisedButton loginbtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}