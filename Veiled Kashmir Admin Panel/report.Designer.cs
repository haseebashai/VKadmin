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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userbtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usrbtn = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.shpbtn = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(Veiled_Kashmir_Admin_Panel.place);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Veiled_Kashmir_Admin_Panel.user);
            // 
            // businessdetailBindingSource
            // 
            this.businessdetailBindingSource.DataSource = typeof(Veiled_Kashmir_Admin_Panel.businessdetail);
            // 
            // userbtn
            // 
            this.userbtn.Location = new System.Drawing.Point(242, 92);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(153, 23);
            this.userbtn.TabIndex = 1;
            this.userbtn.Text = "Generate Place Report";
            this.userbtn.UseVisualStyleBackColor = true;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
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
            reportDataSource1.Name = "place";
            reportDataSource1.Value = this.placeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.placereport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 371);
            this.reportViewer1.TabIndex = 29;
            this.reportViewer1.Visible = false;
            // 
            // usrbtn
            // 
            this.usrbtn.Location = new System.Drawing.Point(416, 92);
            this.usrbtn.Name = "usrbtn";
            this.usrbtn.Size = new System.Drawing.Size(153, 23);
            this.usrbtn.TabIndex = 2;
            this.usrbtn.Text = "Generate User Report";
            this.usrbtn.UseVisualStyleBackColor = true;
            this.usrbtn.Click += new System.EventHandler(this.usrbtn_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "user";
            reportDataSource2.Value = this.userBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.userreport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 121);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(998, 371);
            this.reportViewer2.TabIndex = 31;
            this.reportViewer2.Visible = false;
            // 
            // shpbtn
            // 
            this.shpbtn.Location = new System.Drawing.Point(591, 92);
            this.shpbtn.Name = "shpbtn";
            this.shpbtn.Size = new System.Drawing.Size(153, 23);
            this.shpbtn.TabIndex = 3;
            this.shpbtn.Text = "Generate Shop Report";
            this.shpbtn.UseVisualStyleBackColor = true;
            this.shpbtn.Click += new System.EventHandler(this.shpbtn_Click);
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "shop";
            reportDataSource3.Value = this.businessdetailBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Veiled_Kashmir_Admin_Panel.shopreport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(12, 121);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(998, 433);
            this.reportViewer3.TabIndex = 32;
            this.reportViewer3.Visible = false;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.shpbtn);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.usrbtn);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.userbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.PictureBox back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.Button usrbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button shpbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource businessdetailBindingSource;
    }
}