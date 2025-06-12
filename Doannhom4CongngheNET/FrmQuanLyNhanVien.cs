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
    public partial class FrmQuanLyNhanVien : Form
    {
        private DataServices myDataServices;
        private DataTable dtNhanVien;
        private string currentAction = "";
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadNhanVienData();
        }
        private void LoadNhanVienData()
        {
            string sSql = "SELECT * FROM tblNhanVien order by MaNhanVien";
            dtNhanVien = myDataServices.RunQuery(sSql);
            if (dtNhanVien != null)
            {
                dgvNhanVien.DataSource = dtNhanVien;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu nhân viên.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct ChucVu FROM tblNhanVien";
            DataTable dtChucVu = myDataServices.RunQuery(sSql);
            if (dtChucVu != null)
            {
                cboChucVu.DataSource = dtChucVu;
                cboChucVu.DisplayMember = "ChucVu";
                cboChucVu.ValueMember = "ChucVu";
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu chức vụ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct ChucVu FROM tblNhanVien";
            DataTable dtChucVuFind = myDataServices.RunQuery(sSql);
            if (dtChucVuFind != null)
            {
                DataRow drAll = dtChucVuFind.NewRow();
                drAll["ChucVu"] = "Tất cả";
                dtChucVuFind.Rows.InsertAt(drAll, 0);
                cboChucVuFind.DataSource = dtChucVuFind;
                cboChucVuFind.DisplayMember = "ChucVu";
                cboChucVuFind.ValueMember = "ChucVu";
                cboChucVuFind.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu chức vụ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "SELECT Distinct MaToaNha, TenToaNha FROM tblToaNha";
            DataTable dtToaNhaFind = myDataServices.RunQuery(sSql);
            if (dtToaNhaFind != null)
            {
                DataRow drAll = dtToaNhaFind.NewRow();
                drAll["MaToaNha"] = DBNull.Value;
                drAll["TenToaNha"] = "Tất cả";
                dtToaNhaFind.Rows.InsertAt(drAll, 0);
                cboToaNhaFind.DataSource = dtToaNhaFind;
                cboToaNhaFind.DisplayMember = "TenToaNha";
                cboToaNhaFind.ValueMember = "MaToaNha";
                cboToaNhaFind.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu tòa nhà.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sSql = "Select GioiTinh from tblNhanVien Group by GioiTinh";
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

            sSql = "SELECT Distinct MaToaNha, TenToaNha FROM tblToaNha";
            DataTable dtToaNha = myDataServices.RunQuery(sSql);
            if (dtToaNha != null)
            {
                cboToaNha.DataSource = dtToaNha;
                cboToaNha.DisplayMember = "TenToaNha";
                cboToaNha.ValueMember = "MaToaNha";
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu tòa nhà.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtNhanVien != null)
            {
                lbTongNV.Text ="Tổng số nhân viên: " + dtNhanVien.Rows.Count.ToString();

                int newNV = dtNhanVien.AsEnumerable()
                    .Count(row => row.Field<DateTime>("NgaySinh").Year >= 1991);
                lbNewNV.Text = "Số nhân viên mới: " + newNV.ToString();

                int oldNV = dtNhanVien.AsEnumerable()
                    .Count(row => row.Field<DateTime>("NgaySinh").Year <= 1990);
                lbOldNV.Text = "Số nhân viên cũ: " + oldNV.ToString();
            }
            SetControls(false);
        }
        private void SetControls(bool enable)
        {
            cboChucVuFind.Enabled = !enable;
            cboGioiTinh.Enabled = !enable;
            cboToaNhaFind.Enabled = !enable;
            txtMaNV.Enabled = enable;
            txtHoTen.Enabled = enable;
            dtpNgaySinh.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtSDT.Enabled = enable;
            txtEmail.Enabled = enable;
            cboToaNha.Enabled = enable;
            //Button
            btnAddNV.Enabled = !enable;
            btnUpdateNV.Enabled = !enable;
            btnDeleteNV.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;

        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();

            SetControls(true);
            currentAction = "Add";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);

        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {

            SetControls(true);
            currentAction = "Update";
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int rowIndex = dgvNhanVien.SelectedRows[0].Index;
                string maNV = dgvNhanVien.Rows[rowIndex].Cells["MaNhanVien"].Value.ToString();
                string sSql = $"DELETE FROM tblNhanVien WHERE MaNhanVien = '{maNV}'";
                myDataServices.ExecuteNonQuery(sSql);
                LoadNhanVienData();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string gioiTinh = rbGioiTinh1.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string chucVu = cboChucVu.SelectedValue?.ToString();
            string diaChi = txtDiaChi.Text.Trim();
            string maToaNha = cboToaNha.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentAction == "Add")
            {
                string sql = $"INSERT INTO tblNhanVien (MaNhanVien, Ten, GioiTinh, NgaySinh, DienThoai, Email, ChucVu, DiaChi, MaToaNhaDuocPhanCong) " +
                             $"VALUES ('{maNV}', N'{ten}', N'{gioiTinh}', '{ngaySinh:yyyy-MM-dd}', '{sdt}', '{email}', N'{chucVu}', N'{diaChi}', '{maToaNha}')";
                myDataServices.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentAction == "Update")
            {
                string sql = $"UPDATE tblNhanVien SET Ten=N'{ten}', GioiTinh=N'{gioiTinh}', NgaySinh='{ngaySinh:yyyy-MM-dd}', DienThoai='{sdt}', Email='{email}', ChucVu=N'{chucVu}', DiaChi=N'{diaChi}', MaToaNhaDuocPhanCong='{maToaNha}' WHERE MaNhanVien='{maNV}'";
                myDataServices.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadNhanVienData();
            SetControls(false);
            currentAction = "";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "NhanVien";

            for (int i = 1; i < dgvNhanVien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvNhanVien.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value?.ToString();
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = "DanhSachNhanVien.xlsx";
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

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value?.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["Ten"].Value?.ToString();
            rbGioiTinh1.Checked = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString() == "Nam";
            rbGioiTinh2.Checked = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString() == "Nữ";
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DienThoai"].Value?.ToString();
            txtEmail.Text = dgvNhanVien.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
            cboChucVu.SelectedValue = dgvNhanVien.Rows[e.RowIndex].Cells["ChucVu"].Value?.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString();
            cboToaNha.SelectedValue = dgvNhanVien.Rows[e.RowIndex].Cells["MaToaNhaDuocPhanCong"].Value?.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string chucVu = cboChucVuFind.Text;
            string gioiTinh = cboGioiTinh.Text;
            string tenToaNha = cboToaNhaFind.Text;

            string sql = "SELECT * FROM tblNhanVien WHERE 1=1";
            if (chucVu != "Tất cả")
                sql += $" AND ChucVu = N'{chucVu}'";
            if (gioiTinh != "Tất cả")
                sql += $" AND GioiTinh = N'{gioiTinh}'";
            if (tenToaNha != "Tất cả")
            {
                string maToaNha = cboToaNhaFind.SelectedValue?.ToString();
                sql += $" AND MaToaNhaDuocPhanCong = '{maToaNha}'";
            }

            DataTable dtSearch = myDataServices.RunQuery(sql);
            if (dtSearch != null)
            {
                dgvNhanVien.DataSource = dtSearch;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dtNVReport = (DataTable)dgvNhanVien.DataSource;
            FrmNhanVienReport frm = new FrmNhanVienReport(dtNVReport);
            frm.ShowDialog();
        }
    }
}
