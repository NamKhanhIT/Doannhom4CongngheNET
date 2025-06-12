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
    public partial class FrmSinhVienReport : Form
    {
        private DataTable dtReportSV;
        public FrmSinhVienReport(DataTable dtReportSV)
        {
            InitializeComponent();
            this.dtReportSV = dtReportSV;
        }

        private void FrmSinhVienReport_Load(object sender, EventArgs e)
        {

            try
            {
                reportViewerSV.LocalReport.ReportPath = "ReportSinhVien.rdlc";
                reportViewerSV.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet2", dtReportSV);
                reportViewerSV.LocalReport.DataSources.Add(reportDataSource);
                reportViewerSV.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
