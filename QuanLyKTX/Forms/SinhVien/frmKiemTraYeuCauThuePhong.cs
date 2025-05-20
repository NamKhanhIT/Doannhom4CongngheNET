using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.SinhVien
{
    public partial class frmKiemTraYeuCauThuePhong : Form
    {
        private string maSV;
        private DataServices dataServices;
        private DataTable dt;

        public frmKiemTraYeuCauThuePhong(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
            dataServices = new DataServices();
        }

        private void frmKiemTraYeuCauThuePhong_Load(object sender, EventArgs e)
        {
            LoadYeuCauThuePhong();
        }

        private void LoadYeuCauThuePhong()
        {
            try
            {
                dt = dataServices.GetYeuCauThuePhongByMaSV(maSV);
                dgvYeuCau.DataSource = dt;

                // Định dạng cột
                dgvYeuCau.Columns["MaYeuCau"].HeaderText = "Mã yêu cầu";
                dgvYeuCau.Columns["NgayGui"].HeaderText = "Ngày gửi";
                dgvYeuCau.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvYeuCau.Columns["MaPhong"].HeaderText = "Mã phòng";
                dgvYeuCau.Columns["TenPhong"].HeaderText = "Tên phòng";
                dgvYeuCau.Columns["LoaiPhong"].HeaderText = "Loại phòng";
                dgvYeuCau.Columns["GiaPhong"].HeaderText = "Giá phòng";
                dgvYeuCau.Columns["MoTaTrangThai"].HeaderText = "Mô tả trạng thái";

                // Định dạng cột ngày tháng
                dgvYeuCau.Columns["NgayGui"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Định dạng cột giá tiền
                dgvYeuCau.Columns["GiaPhong"].DefaultCellStyle.Format = "N0";
                dgvYeuCau.Columns["GiaPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Tự động điều chỉnh độ rộng cột
                dgvYeuCau.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Ẩn cột mã yêu cầu
                dgvYeuCau.Columns["MaYeuCau"].Visible = false;
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

            string maYeuCau = dgvYeuCau.SelectedRows[0].Cells["MaYeuCau"].Value.ToString();
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
                    if (dataServices.HuyYeuCauThuePhong(maYeuCau))
                    {
                        MessageBox.Show("Hủy yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadYeuCauThuePhong();
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy yêu cầu. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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