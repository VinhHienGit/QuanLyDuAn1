namespace Design
{
    partial class f_report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLNSDataSet = new Design.QLNSDataSet();
            this.vw_NhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanSuTableAdapter = new Design.QLNSDataSetTableAdapters.vw_NhanSuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanSuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_NhanSuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Design.Report.rp_NhanSu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(816, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNSDataSet
            // 
            this.QLNSDataSet.DataSetName = "QLNSDataSet";
            this.QLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_NhanSuBindingSource
            // 
            this.vw_NhanSuBindingSource.DataMember = "vw_NhanSu";
            this.vw_NhanSuBindingSource.DataSource = this.QLNSDataSet;
            // 
            // vw_NhanSuTableAdapter
            // 
            this.vw_NhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // f_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(816, 441);
            this.Controls.Add(this.reportViewer1);
            this.Name = "f_report";
            this.Text = "Quản lý nhân sự - Báo cáo";
            this.Load += new System.EventHandler(this.f_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanSuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_NhanSuBindingSource;
        private QLNSDataSet QLNSDataSet;
        private QLNSDataSetTableAdapters.vw_NhanSuTableAdapter vw_NhanSuTableAdapter;
    }
}