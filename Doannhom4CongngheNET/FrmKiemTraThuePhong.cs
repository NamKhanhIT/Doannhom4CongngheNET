using Doannhom4CongngheNET.Resources;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    public partial class FrmKiemTraThuePhong : Form
    {
        private DataServices myDataServices;
        private DataTable dtYeuCau;
        private string currentAction = "";

        public FrmKiemTraThuePhong()
        {
            InitializeComponent();
        }

        private void FrmKiemTraThuePhong_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadYeuCauThuePhong();
            SetControls(false);
        }
        private void LoadYeuCauThuePhong()
        {
            string sSql = @"
                SELECT yc.MaYeuCau, sv.MaSV, sv.Ten AS TenSV, p.MaPhong, p.SoPhong, yc.NgayYeuCau, yc.TrangThai, yc.MoTaTrangThai
                FROM tblPhong p
                INNER JOIN tblYeuCauThuePhong yc ON yc.MaPhong = p.MaPhong
                INNER JOIN tblSinhVien sv ON sv.MaSV = yc.MaSV
                ORDER BY yc.NgayYeuCau";
            dtYeuCau = myDataServices.RunQuery(sSql);
            if (dtYeuCau != null)
            {
                dgvYeuCauTP.DataSource = dtYeuCau;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu yêu cầu thuê phòng.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct MaPhong, SoPhong FROM tblPhong order by MaPhong";
            DataTable dtPhong = myDataServices.RunQuery(sSql);
            if (dtPhong != null)
            {
                cboSoPhong.DataSource = dtPhong;
                cboSoPhong.DisplayMember = "SoPhong";
                cboSoPhong.ValueMember = "MaPhong";
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu phòng.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT DISTINCT TrangThai FROM tblYeuCauThuePhong ORDER BY TrangThai";
            DataTable dtTrangThai = myDataServices.RunQuery(sSql);
            cboTrangThai.DataSource = dtTrangThai;
            cboTrangThai.DisplayMember = "TrangThai";
            cboTrangThai.ValueMember = "TrangThai";

            sSql = "SELECT MaSV, Ten FROM tblSinhVien ORDER BY Ten";
            DataTable dtSinhVien = myDataServices.RunQuery(sSql);
            if (dtSinhVien != null)
            {
                cboTenSV.DataSource = dtSinhVien;
                cboTenSV.DisplayMember = "Ten";
                cboTenSV.ValueMember = "MaSV";
                cboTenSV.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách sinh viên.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            cboTenSV.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            var dtChart = myDataServices.RunQuery(
                "SELECT CONVERT(date, NgayYeuCau) AS Ngay, COUNT(*) AS SoYeuCau " +
                "FROM tblYeuCauThuePhong " +
                "WHERE NgayYeuCau >= DATEADD(day, -6, GETDATE()) " +
                "GROUP BY CONVERT(date, NgayYeuCau) " +
                "ORDER BY Ngay"
            );
            chartYeuCau.Series.Clear();
            chartYeuCau.ChartAreas[0].AxisX.Title = "Ngày";
            chartYeuCau.ChartAreas[0].AxisY.Title = "Số yêu cầu";
            var series = chartYeuCau.Series.Add("Số yêu cầu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            if (dtChart != null)
            {
                foreach (DataRow row in dtChart.Rows)
                {
                    series.Points.AddXY(Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy"), Convert.ToInt32(row["SoYeuCau"]));
                }
            }
            var dates = dtYeuCau.AsEnumerable()
                .Select(r => Convert.ToDateTime(r["NgayYeuCau"]).Date)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();

            cboSearch.Items.Clear();
            cboSearch.Items.Add("Gần nhất");
            foreach (var d in dates)
                cboSearch.Items.Add(d.ToString("dd/MM/yyyy"));

            cboSearch.SelectedIndex = 0;

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn làm mới dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Làm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadYeuCauThuePhong();
                txtMaYeuCau.Visible = true;
            }
            else return;
        }

        private void dgvYeuCauTP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaYeuCau.Text = dgvYeuCauTP.Rows[e.RowIndex].Cells["MaYeuCau"].Value?.ToString();
            cboTenSV.SelectedValue = dgvYeuCauTP.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();
            cboSoPhong.SelectedValue = dgvYeuCauTP.Rows[e.RowIndex].Cells["MaPhong"].Value;
            dtpNgayYeuCau.Value = Convert.ToDateTime(dgvYeuCauTP.Rows[e.RowIndex].Cells["NgayYeuCau"].Value);
            cboTrangThai.SelectedValue = dgvYeuCauTP.Rows[e.RowIndex].Cells["TrangThai"].Value;
            txtMoTa.Text = dgvYeuCauTP.Rows[e.RowIndex].Cells["MoTaTrangThai"].Value?.ToString();
        }

        private void SetControls (bool enable)
        {
            txtMaYeuCau.Enabled = enable;
            cboTenSV.Enabled = enable;
            cboSoPhong.Enabled = enable;
            dtpNgayYeuCau.Enabled = enable;
            cboTrangThai.Enabled = enable;
            txtMoTa.Enabled = enable;
            btnAdd.Enabled = !enable;
            btnUpdate.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnGhi.Enabled = enable;
            btnCancel.Enabled = enable;
            btnRefresh.Enabled = !enable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if(dgvYeuCauTP.SelectedRows.Count > 0)
            {
                int rowIndex = dgvYeuCauTP.SelectedRows[0].Index;
                string mayeucau = dgvYeuCauTP.Rows[rowIndex].Cells["MaYeuCau"].Value.ToString();
                string sSql = $"DELETE FROM tblYeuCauThuePhong WHERE MaYeuCau = '{mayeucau}'";
                myDataServices.ExecuteNonQuery(sSql);
                LoadYeuCauThuePhong();
                MessageBox.Show("Xóa yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboTenSV.SelectedIndex = -1;
            cboSoPhong.SelectedIndex = -1;
            dtpNgayYeuCau.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = -1;
            txtMoTa.Clear();
            txtMaYeuCau.Clear();
            txtMaYeuCau.Visible = false;
            currentAction = "Add";
            SetControls(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtMaYeuCau.Visible = false;
            SetControls(true);
            currentAction = "Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
            txtMaYeuCau.Visible = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string maYeuCau = txtMaYeuCau.Text.Trim();
            string tenSV = cboTenSV.SelectedValue?.ToString();
            string soPhong = cboSoPhong.SelectedValue?.ToString();
            string ngayYeuCau = dtpNgayYeuCau.Value.ToString("yyyy-MM-dd");
            string trangThai = cboTrangThai.SelectedValue?.ToString();
            string moTa = txtMoTa.Text.Trim();
            if (string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(soPhong) || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentAction == "Add")
            {
                string maSV = cboTenSV.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sSql = $@"
                    INSERT INTO tblYeuCauThuePhong (MaSV, MaPhong, NgayYeuCau, TrangThai)
                    VALUES ('{maSV}', '{soPhong}', '{ngayYeuCau}', N'{trangThai}')";
                myDataServices.ExecuteNonQuery(sSql);
                MessageBox.Show("Thêm yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadYeuCauThuePhong();
                SetControls(false);
                txtMaYeuCau.Visible = true;
            }

            else if (currentAction == "Update")
            {

                if (string.IsNullOrEmpty(maYeuCau))
                {
                    MessageBox.Show("Vui lòng chọn yêu cầu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sSql = $@"
                    UPDATE tblYeuCauThuePhong
                    SET MaSV = '{tenSV}', MaPhong = '{soPhong}', NgayYeuCau = '{ngayYeuCau}', TrangThai = N'{trangThai}'
                    WHERE MaYeuCau = '{maYeuCau}'";
                myDataServices.ExecuteNonQuery(sSql);
                MessageBox.Show("Cập nhật yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadYeuCauThuePhong();
                SetControls(false);
                txtMaYeuCau.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtYeuCau == null) return;

            var dv = dtYeuCau.DefaultView;

            string timkiem = cboSearch.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(timkiem) || timkiem == "Gần nhất")
            {
                var maxDate = dtYeuCau.AsEnumerable()
                              .Select(r => Convert.ToDateTime(r["NgayYeuCau"]).Date)
                              .DefaultIfEmpty(DateTime.Today)
                              .Max();

                dv.RowFilter = $"CONVERT(NgayYeuCau, 'System.DateTime') >= #{maxDate:MM/dd/yyyy}# " +
                               $"AND CONVERT(NgayYeuCau, 'System.DateTime') <  #{maxDate.AddDays(1):MM/dd/yyyy}#";
            }
            else
            {
                if (DateTime.TryParseExact(timkiem, "dd/MM/yyyy", null,
                                           System.Globalization.DateTimeStyles.None, out DateTime pick))
                {
                    dv.RowFilter = $"CONVERT(NgayYeuCau, 'System.DateTime') >= #{pick:MM/dd/yyyy}# " +
                                   $"AND CONVERT(NgayYeuCau, 'System.DateTime') <  #{pick.AddDays(1):MM/dd/yyyy}#";
                }
            }

            dgvYeuCauTP.DataSource = dv.ToTable();

            var filtered = dv.ToTable().AsEnumerable()
                            .GroupBy(r => Convert.ToDateTime(r["NgayYeuCau"]).Date)
                            .Select(g => new { Ngay = g.Key, Count = g.Count() })
                            .OrderBy(x => x.Ngay)
                            .ToList();

            chartYeuCau.Series["Số yêu cầu"].Points.Clear();
            foreach (var x in filtered)
            {
                chartYeuCau.Series["Số yêu cầu"]
                    .Points.AddXY(x.Ngay.ToString("dd/MM"), x.Count);
            }
        }
    }
}
