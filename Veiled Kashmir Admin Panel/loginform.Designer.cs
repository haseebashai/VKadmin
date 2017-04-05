namespace Veiled_Kashmir_Admin_Panel
{
    partial class loginform
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
            this.usrtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pwdtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.forgotbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.loginbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrtxt
            // 
            this.usrtxt.Depth = 0;
            this.usrtxt.Hint = "";
            this.usrtxt.Location = new System.Drawing.Point(366, 205);
            this.usrtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrtxt.Name = "usrtxt";
            this.usrtxt.PasswordChar = '\0';
            this.usrtxt.SelectedText = "";
            this.usrtxt.SelectionLength = 0;
            this.usrtxt.SelectionStart = 0;
            this.usrtxt.Size = new System.Drawing.Size(248, 23);
            this.usrtxt.TabIndex = 2;
            this.usrtxt.TabStop = false;
            this.usrtxt.Text = "Username";
            this.usrtxt.UseSystemPasswordChar = false;
            this.usrtxt.Enter += new System.EventHandler(this.usrtxt_Enter);
            // 
            // pwdtxt
            // 
            this.pwdtxt.Depth = 0;
            this.pwdtxt.Hint = "";
            this.pwdtxt.Location = new System.Drawing.Point(366, 261);
            this.pwdtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.SelectedText = "";
            this.pwdtxt.SelectionLength = 0;
            this.pwdtxt.SelectionStart = 0;
            this.pwdtxt.Size = new System.Drawing.Size(248, 23);
            this.pwdtxt.TabIndex = 3;
            this.pwdtxt.TabStop = false;
            this.pwdtxt.Text = "Password";
            this.pwdtxt.UseSystemPasswordChar = false;
            this.pwdtxt.Enter += new System.EventHandler(this.pwdtxt_Enter);
            // 
            // forgotbtn
            // 
            this.forgotbtn.AutoSize = true;
            this.forgotbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forgotbtn.Depth = 0;
            this.forgotbtn.Location = new System.Drawing.Point(366, 320);
            this.forgotbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.forgotbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.forgotbtn.Name = "forgotbtn";
            this.forgotbtn.Primary = false;
            this.forgotbtn.Size = new System.Drawing.Size(148, 36);
            this.forgotbtn.TabIndex = 5;
            this.forgotbtn.Text = "FORGOT PASSWORD?";
            this.forgotbtn.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Depth = 0;
            this.loginbtn.Location = new System.Drawing.Point(539, 327);
            this.loginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Primary = true;
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN TO YOUR ACCOUNT.";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgotbtn);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usrtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "loginform";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField usrtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField pwdtxt;
        private MaterialSkin.Controls.MaterialFlatButton forgotbtn;
        private MaterialSkin.Controls.MaterialRaisedButton loginbtn;
        private System.Windows.Forms.Label label1;
    }
}