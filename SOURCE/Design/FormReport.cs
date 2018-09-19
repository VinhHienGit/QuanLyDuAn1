using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void f_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNSDataSet.vw_NhanSu' table. You can move, or remove it, as needed.
            this.vw_NhanSuTableAdapter.Fill(this.QLNSDataSet.vw_NhanSu);

            this.reportViewer1.RefreshReport();
        }

        void load()
        {
            string sql = "SELECT * FROM dbo.vw_NhanSu";
            string connectionSTR = @"Data Source=KIDSZONE;Initial Catalog=QLNS;User ID=sa;Password=123456";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionSTR;
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            
            reportViewer1.LocalReport.ReportPath = "rp_NhanSu.rdlc";
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DanhSachNhanVien";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
