using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Doannhom4CongngheNET
{
    public partial class FrmNhanVienReport : Form
    {
        private DataTable dtReportNV;
        public FrmNhanVienReport(DataTable dtReportNV)
        {
            InitializeComponent();
            this.dtReportNV = dtReportNV;
        }

        private void FrmNhanVienReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportPath = "ReportNhanVien.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1",dtReportNV );
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
