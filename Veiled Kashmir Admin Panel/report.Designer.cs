namespace Veiled_Kashmir_Admin_Panel
{
    partial class report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.back = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userrbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.placerbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.shoprbtn = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessdetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackgroundImage = global::Veiled_Kashmir_Admin_Panel.Properties.Resources._9895;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(12, 7);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 64);
            this.back.TabIndex = 28;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reportViewer1
            // 
            reportDataSource10.Name = "place";
            reportDataSource10.Value = this.placeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.placereport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 371);
            this.reportViewer1.TabIndex = 29;
            this.reportViewer1.Visible = false;
            // 
            // reportViewer2
            // 
            reportDataSource11.Name = "user";
            reportDataSource11.Value = this.userBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.userreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 121);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(998, 371);
            this.reportViewer2.TabIndex = 31;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            reportDataSource12.Name = "shop";
            reportDataSource12.Value = this.businessdetailBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.shopreport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(12, 121);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(998, 433);
            this.reportViewer3.TabIndex = 32;
            this.reportViewer3.Visible = false;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(Veiled_Kashmir_Admin_Panel.place);
            // 
            // businessdetailBindingSource
            // 
            this.businessdetailBindingSource.DataSource = typeof(Veiled_Kashmir_Admin_Panel.businessdetail);
            // 
            // userrbtn
            // 
            this.userrbtn.AutoSize = true;
            this.userrbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userrbtn.Depth = 0;
            this.userrbtn.Location = new System.Drawing.Point(242, 81);
            this.userrbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userrbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.userrbtn.Name = "userrbtn";
            this.userrbtn.Primary = false;
            this.userrbtn.Size = new System.Drawing.Size(172, 36);
            this.userrbtn.TabIndex = 33;
            this.userrbtn.Text = "Generate User Report";
            this.userrbtn.UseVisualStyleBackColor = true;
            this.userrbtn.Click += new System.EventHandler(this.usrbtn_Click);
            // 
            // placerbtn
            // 
            this.placerbtn.AutoSize = true;
            this.placerbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.placerbtn.Depth = 0;
            this.placerbtn.Location = new System.Drawing.Point(433, 81);
            this.placerbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.placerbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.placerbtn.Name = "placerbtn";
            this.placerbtn.Primary = false;
            this.placerbtn.Size = new System.Drawing.Size(181, 36);
            this.placerbtn.TabIndex = 34;
            this.placerbtn.Text = "Generate Place Report";
            this.placerbtn.UseVisualStyleBackColor = true;
            this.placerbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // shoprbtn
            // 
            this.shoprbtn.AutoSize = true;
            this.shoprbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shoprbtn.Depth = 0;
            this.shoprbtn.Location = new System.Drawing.Point(636, 81);
            this.shoprbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.shoprbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.shoprbtn.Name = "shoprbtn";
            this.shoprbtn.Primary = false;
            this.shoprbtn.Size = new System.Drawing.Size(175, 36);
            this.shoprbtn.TabIndex = 35;
            this.shoprbtn.Text = "Generate Shop Report";
            this.shoprbtn.UseVisualStyleBackColor = true;
            this.shoprbtn.Click += new System.EventHandler(this.shpbtn_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.shoprbtn);
            this.Controls.Add(this.placerbtn);
            this.Controls.Add(this.userrbtn);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reportViewer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessdetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource businessdetailBindingSource;
        private MaterialSkin.Controls.MaterialFlatButton userrbtn;
        private MaterialSkin.Controls.MaterialFlatButton placerbtn;
        private MaterialSkin.Controls.MaterialFlatButton shoprbtn;
    }
}