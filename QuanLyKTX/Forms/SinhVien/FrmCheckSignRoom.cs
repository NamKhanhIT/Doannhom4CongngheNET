using System;
using System.Data;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    public partial class FrmCheckSignRoom : Form
    {
        private DataServices mydataServices;
        private DataTable dt;
        public static string MaNguoiDung { get; set; }

        public FrmCheckSignRoom()
        {
            InitializeComponent();
            mydataServices = new DataServices();
        }

        private void FrmCheckSignRoom_Load(object sender, EventArgs e)
        {
            LoadYeuCauThuePhong();
        }

        private void LoadYeuCauThuePhong()
        {
            if (mydataServices == null)
            {
                mydataServices = new DataServices();
            }

            if (!mydataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = @"SELECT YC.MaYeuCau, YC.MaPhong, YC.NgayYeuCau, YC.TrangThai,
                                P.TenPhong, P.LoaiPhong, P.GiaThue,
                                CASE 
                                    WHEN YC.TrangThai = N'Chờ duyệt' THEN N'Đang chờ quản lý xét duyệt'
                                    WHEN YC.TrangThai = N'Đã duyệt' THEN N'Yêu cầu của bạn đã được chấp nhận'
                                    WHEN YC.TrangThai = N'Từ chối' THEN N'Yêu cầu của bạn đã bị từ chối'
                                    WHEN YC.TrangThai = N'Huy' THEN N'Bạn đã hủy yêu cầu này'
                                    ELSE N'Không xác định'
                                END as MoTaTrangThai
                                FROM YeuCau YC
                                LEFT JOIN Phong P ON YC.MaPhong = P.MaPhong
                                WHERE YC.MaNguoiDung = '" + MaNguoiDung + "'
                                ORDER BY YC.NgayYeuCau DESC";

                dt = mydataServices.RunQuery(query);
                if (dt != null)
                {
                    dgvYeuCau.DataSource = dt;

                    // Định dạng cột
                    dgvYeuCau.Columns["MaYeuCau"].HeaderText = "Mã yêu cầu";
                    dgvYeuCau.Columns["MaPhong"].HeaderText = "Mã phòng";
                    dgvYeuCau.Columns["NgayYeuCau"].HeaderText = "Ngày yêu cầu";
                    dgvYeuCau.Columns["TrangThai"].HeaderText = "Trạng thái";
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
                }
                else
                {
                    MessageBox.Show("Bạn chưa có yêu cầu thuê phòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MaYeuCau = dgvYeuCau.SelectedRows[0].Cells["MaYeuCau"].Value.ToString();
            string TrangThai = dgvYeuCau.SelectedRows[0].Cells["TrangThai"].Value.ToString();

            if (TrangThai != "Chờ duyệt")
            {
                MessageBox.Show("Chỉ có thể hủy yêu cầu đang ở trạng thái chờ duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy yêu cầu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string updateSQL = "UPDATE YeuCau SET TrangThai = N'Huy' WHERE MaYeuCau = '" + MaYeuCau + "'";
                    mydataServices.ExecuteNonQuery(updateSQL);
                    MessageBox.Show("Hủy yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadYeuCauThuePhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hủy yêu cầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadYeuCauThuePhong();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 