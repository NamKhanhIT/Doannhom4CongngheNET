using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.SinhVien
{
    public partial class FrmCheckSignRoom : Form
    {
        private string MaSV;
        private DataServices mydataServices;
        private DataTable dt;

        public FrmCheckSignRoom(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;
            mydataServices = new DataServices();
        }

        private void FrmCheckSignRoom_Load(object sender, EventArgs e)
        {
            LoadYeuCauThuePhong();
        }

        private void LoadYeuCauThuePhong()
        {
            try
            {
                dt = mydataServices.RunQuery(MaSV);
                dgvYeuCau.DataSource = dt;

                // Định dạng cột
                dgvYeuCau.Columns["MaYeuCau"].HeaderText = "Mã yêu cầu";
                dgvYeuCau.Columns["NgayYeuCau"].HeaderText = "Ngày yêu cầu";
                dgvYeuCau.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvYeuCau.Columns["MaPhong"].HeaderText = "Mã phòng";
                dgvYeuCau.Columns["TenPhong"].HeaderText = "Tên phòng";
                dgvYeuCau.Columns["LoaiPhong"].HeaderText = "Loại phòng";
                dgvYeuCau.Columns["GiaThue"].HeaderText = "Giá phòng";
                dgvYeuCau.Columns["MoTaTrangThai"].HeaderText = "Mô tả trạng thái";

                // Định dạng cột ngày tháng
                dgvYeuCau.Columns["NgayYeuCau"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Định dạng cột giá tiền
                dgvYeuCau.Columns["GiaThue"].DefaultCellStyle.Format = "N0";
                dgvYeuCau.Columns["GiaThue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Tự động điều chỉnh độ rộng cột
                dgvYeuCau.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Ẩn cột mã yêu cầu
                dgvYeuCau.Columns["MaYeuCau"].Visible = false;

                // Kiểm tra nếu không có dữ liệu
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa có yêu cầu thuê phòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MaYeuCau = dgvYeuCau.SelectedRows[0].Cells["MaYeuCau"].Value.ToString();
            string trangThai = dgvYeuCau.SelectedRows[0].Cells["TrangThai"].Value.ToString();

            if (trangThai != "Chờ duyệt")
            {
                MessageBox.Show("Chỉ có thể hủy yêu cầu đang ở trạng thái chờ duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy yêu cầu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string updateQuery = $"UPDATE YeuCau SET TrangThai = 'Huy' WHERE MaYeuCau = '{MaYeuCau}'";
                    mydataServices.ExecuteNonQuery(updateQuery);
                    MessageBox.Show("Hủy yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadYeuCauThuePhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hủy yêu cầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadYeuCauThuePhong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 