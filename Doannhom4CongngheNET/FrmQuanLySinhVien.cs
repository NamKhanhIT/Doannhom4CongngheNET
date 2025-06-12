using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace Doannhom4CongngheNET
{
    public partial class FrmQuanLySinhVien : Form
    {
        private DataServices myDataServices;
        private DataTable dtSinhVien;
        private string currentAction = "";
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if(!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadSinhVienData();
        }
        private void LoadSinhVienData()
        {
            string sSql = "SELECT * FROM tblSinhVien order by MaSV";
            dtSinhVien = myDataServices.RunQuery(sSql);
            if (dtSinhVien != null)
            {
                dgvSinhVien.DataSource = dtSinhVien;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu nhân viên.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct Khoa FROM tblSinhVien";
            DataTable dtKhoa = myDataServices.RunQuery(sSql);
            if (dtKhoa != null)
            {
                cboKhoa.DataSource = dtKhoa;
                cboKhoa.DisplayMember = "Khoa";
                cboKhoa.ValueMember = "Khoa";
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu chức vụ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct Khoa FROM tblSinhVien";
            DataTable dtKhoaFind = myDataServices.RunQuery(sSql);
            if (dtKhoaFind != null)
            {
                DataRow drAll = dtKhoaFind.NewRow();
                drAll["Khoa"] = "Tất cả";
                dtKhoaFind.Rows.InsertAt(drAll, 0); 
                cboKhoaFind.DataSource = dtKhoaFind;
                cboKhoaFind.DisplayMember = "Khoa";
                cboKhoaFind.ValueMember = "Khoa";
                cboKhoaFind.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu chức vụ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct NamHoc FROM tblSinhVien";
            DataTable dtNamHocFind = myDataServices.RunQuery(sSql);
            if (dtNamHocFind != null)
            {
                DataRow drAll = dtNamHocFind.NewRow();
                drAll["NamHoc"] = -1; 
                dtNamHocFind.Rows.InsertAt(drAll, 0);
                cboNamHocFind.DataSource = dtNamHocFind;
                cboNamHocFind.DisplayMember = "NamHoc";
                cboNamHocFind.ValueMember = "NamHoc";
                cboNamHocFind.SelectedIndex = 0;
                cboNamHocFind.Format += (s, e) =>
                {
                    if (e.ListItem != null && e.ListItem is DataRowView drv && drv["NamHoc"] != DBNull.Value && Convert.ToInt32(drv["NamHoc"]) == -1)
                        e.Value = "Tất cả";
                };
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu chức vụ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            sSql = "Select distinct GioiTinh from tblSinhVien";
            DataTable dtGioiTinh = myDataServices.RunQuery(sSql);
            if (dtGioiTinh != null)
            {
                DataRow drAll = dtGioiTinh.NewRow();
                drAll["GioiTinh"] = "Tất cả";
                dtGioiTinh.Rows.InsertAt(drAll, 0);
                cboGioiTinh.DataSource = dtGioiTinh;
                cboGioiTinh.DisplayMember = "GioiTinh";
                cboGioiTinh.ValueMember = "GioiTinh";
                cboGioiTinh.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu giới tính.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtSinhVien != null)
            {
                lbTongSV.Text = "Tổng số sinh viên: " + dtSinhVien.Rows.Count.ToString();

                int newSV = dtSinhVien.AsEnumerable()
                    .Count(row => row.Field<int?>("NamHoc") != null && row.Field<int?>("NamHoc") >= 2022);
                lbNewSV.Text = "Số sinh viên mới: " + newSV.ToString();

                int oldSV = dtSinhVien.AsEnumerable()
                    .Count(row => row.Field<int?>("NamHoc") != null && row.Field<int?>("NamHoc") <= 2021);
                lbOldSV.Text = "Số sinh viên cũ: " + oldSV.ToString();
            }

            SetControls(false);
        }
        private void SetControls(bool enable)
        {
            cboKhoaFind.Enabled = !enable;
            cboGioiTinh.Enabled = !enable;
            cboNamHocFind.Enabled = !enable;
            txtMaSV.Enabled = enable;
            txtHoTen.Enabled = enable;
            dtpNgaySinh.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtSDT.Enabled = enable;
            txtEmail.Enabled = enable;
            cboKhoa.Enabled = enable;
            txtNamVaoHoc.Enabled = enable;
            //Button
            btnAddSV.Enabled = !enable;
            btnUpdateSV.Enabled = !enable;
            btnDeleteSV.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;

        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtEmail.Clear();
            txtNamVaoHoc.Clear();
            txtDiaChi.Clear();

            SetControls(true);
            currentAction = "Add";
        }

        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            SetControls(true);
            currentAction = "Update";
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                int rowIndex = dgvSinhVien.SelectedRows[0].Index;
                string maSV = dgvSinhVien.Rows[rowIndex].Cells["MaSV"].Value.ToString();

                string sSql = $@"
                    DELETE FROM tblViPham WHERE MaSV IN (SELECT MaSV FROM tblSinhVien WHERE MaSV = '{maSV}');
                    DELETE FROM tblThanhToan WHERE MaSV IN (SELECT MaSV FROM tblSinhVien WHERE MaSV = '{maSV}');
                    delete from tblPhanPhong where MaSV in(select MaSV from tblSinhVien where MaSV = '{maSV}')
                    DELETE FROM tblSinhVien WHERE MaSV = '{maSV}';";

                myDataServices.ExecuteNonQuery(sSql);
                LoadSinhVienData();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells["Ten"].Value?.ToString();
            rbGioiTinh1.Checked = dgvSinhVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString() == "Nam";
            rbGioiTinh2.Checked = dgvSinhVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString() == "Nữ";
            dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            txtSDT.Text = dgvSinhVien.Rows[e.RowIndex].Cells["SoDienThoai"].Value?.ToString();
            txtEmail.Text = dgvSinhVien.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
            cboKhoa.SelectedValue = dgvSinhVien.Rows[e.RowIndex].Cells["Khoa"].Value?.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString();
            txtNamVaoHoc.Text = dgvSinhVien.Rows[e.RowIndex].Cells["NamHoc"].Value?.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string gioiTinh = rbGioiTinh1.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string khoahoc = cboKhoa.SelectedValue?.ToString();
            string diaChi = txtDiaChi.Text.Trim();
            string namHoc = txtNamVaoHoc.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(maSV, @"^SV\d{3}$"))
            {
                MessageBox.Show("Mã sinh viên phải bắt đầu bằng 'SV' và theo sau là 3 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngaySinh.Year < 1960 || ngaySinh > DateTime.Now )
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(sdt.Length >=11 && !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số và không được là chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(namHoc, out int namHocInt) || namHocInt < 1900 || namHocInt > DateTime.Now.Year)
            {
                MessageBox.Show("Năm học không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentAction == "Add" && dtSinhVien.AsEnumerable().Any(row => row.Field<string>("MaSV") == maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentAction == "Update" && !dtSinhVien.AsEnumerable().Any(row => row.Field<string>("MaSV") == maSV))
            {
                MessageBox.Show("Mã sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentAction == "Add")
            {
                string sSql = $@"
                    INSERT INTO tblSinhVien (MaSV, Ten, GioiTinh, NgaySinh, SoDienThoai, Email, Khoa, DiaChi, NamHoc)
                    VALUES ('{maSV}', N'{ten}', N'{gioiTinh}', '{ngaySinh:yyyy-MM-dd}', '{sdt}', '{email}', N'{khoahoc}', N'{diaChi}', {namHoc});";
                myDataServices.ExecuteNonQuery(sSql);
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentAction == "Update")
            {
                string sSql = $@"
                    UPDATE tblSinhVien
                    SET Ten = N'{ten}', GioiTinh = N'{gioiTinh}', NgaySinh = '{ngaySinh:yyyy-MM-dd}',
                        SoDienThoai = '{sdt}', Email = '{email}', Khoa = N'{khoahoc}', DiaChi = N'{diaChi}',
                        NamHoc = {namHoc}
                    WHERE MaSV = '{maSV}';";
                myDataServices.ExecuteNonQuery(sSql);
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadSinhVienData();
            SetControls(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string khoa = cboKhoaFind.Text;
            string gioiTinh = cboGioiTinh.Text;
            string namhoc = cboNamHocFind.Text;

            string sql = "SELECT * FROM tblSinhVien WHERE 1=1";
            if (khoa != "Tất cả")
                sql += $" AND Khoa = N'{khoa}'";
            if (gioiTinh != "Tất cả")
                sql += $" AND GioiTinh = N'{gioiTinh}'";
            if (namhoc != "Tất cả")
                sql += $" AND NamHoc = {namhoc}";

            DataTable dtSearch = myDataServices.RunQuery(sql);
            if (dtSearch != null)
            {
                dgvSinhVien.DataSource = dtSearch;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "SinhVien";

            for (int i = 1; i < dgvSinhVien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvSinhVien.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSinhVien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvSinhVien.Rows[i].Cells[j].Value?.ToString();
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = "DanhSachSinhVien.xlsx";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveDialog.FileName);
                excelApp.Quit();
                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                excelApp.Quit();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dtSVReport = (DataTable)dgvSinhVien.DataSource;
            FrmSinhVienReport frmSV = new FrmSinhVienReport(dtSVReport);
            frmSV.ShowDialog();
        }
    }
}
