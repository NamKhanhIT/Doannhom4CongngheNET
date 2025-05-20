using Doannhom4CongngheNET.QuanLyKTXDataSetTableAdapters;
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
    public partial class FrmSearchRoom : Form
    {
        private DataServices myDataServices;
        private bool modeNew;
        public static string MaNguoiDung { get; set; }

        public FrmSearchRoom()
        {
            InitializeComponent();
        }

        private void FrmSearchRoom_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sSql = "SELECT * FROM tblPhong ORDER BY MaPhong";
            DataTable dtRooms = myDataServices.RunQuery(sSql);
            if (dtRooms == null)
            {
                MessageBox.Show("Truy vấn phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sSql = "Select Distinct SoPhong From tblPhong Order By SoPhong";
            DataTable dtSoPhong = myDataServices.RunQuery(sSql);
            cboSoPhong.DataSource = dtSoPhong;
            cboSoPhong.DisplayMember = "SoPhong";
            cboSoPhong.ValueMember = "SoPhong";

            sSql = "Select Distinct LoaiPhong From tblPhong Order By LoaiPhong";
            DataTable dtLoaiPhong = myDataServices.RunQuery(sSql);
            cboLoaiPhong.DataSource = dtLoaiPhong;
            cboLoaiPhong.DisplayMember = "LoaiPhong";
            cboLoaiPhong.ValueMember = "LoaiPhong";

            sSql = "Select Distinct TinhTrang From tblPhong Order By TinhTrang";
            DataTable dtTinhTrang = myDataServices.RunQuery(sSql);
            cboTinhTrang.DataSource = dtTinhTrang;
            cboTinhTrang.DisplayMember = "TinhTrang";
            cboTinhTrang.ValueMember = "TinhTrang";

            PanelCha.Controls.Clear();

            foreach (DataRow row in dtRooms.Rows)
            {
                UserControl1 phong = new UserControl1();
                phong.maphong = row["MaPhong"].ToString();
                phong.sophong = row["SoPhong"].ToString();
                phong.loaiphong = row["LoaiPhong"].ToString();
                phong.succhua = row["SucChua"].ToString();
                phong.tinhtrang = row["TinhTrang"].ToString();
                phong.giathue = row["GiaThue"].ToString() ;
                phong.songuoithue = row["SoNguoiDaThue"].ToString();
                phong.tienich = row["TienIch"].ToString();

                PanelCha.Controls.Add(phong);
            }

        }
        public void LayDuLieu(string maphong, string sophong, string loaiphong, string succhua, string songuoithue, string tinhtrang, string tienich, string giathue)
        {
            txtMaPhong.Text = maphong;
            txtSoPhong.Text = sophong;
            txtLoaiPhong.Text = loaiphong;
            txtSucChua.Text = succhua;
            txtSoNguoiThue.Text = songuoithue;
            txtTinhTrangPhong.Text = tinhtrang;
            txtTienIch.Text = tienich;
            txtGiaThue.Text = giathue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sSql = "SELECT * FROM tblPhong WHERE SoNguoiDaThue < SucChua";

            if (!string.IsNullOrEmpty(cboSoPhong.Text))
                sSql += " AND SoPhong = N'" + cboSoPhong.Text + "'";

            if (!string.IsNullOrEmpty(cboLoaiPhong.Text))
                sSql += " AND LoaiPhong = N'" + cboLoaiPhong.Text + "'";

            if (!string.IsNullOrEmpty(cboTinhTrang.Text))
                sSql += " AND TinhTrang = N'" + cboTinhTrang.Text + "'";

            sSql += " ORDER BY MaPhong";

            DataTable dtRooms = myDataServices.RunQuery(sSql);
            if (dtRooms == null)
            {
                MessageBox.Show("Truy vấn phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 

            PanelCha.Controls.Clear();

            foreach (DataRow row in dtRooms.Rows)
            {
                UserControl1 phong = new UserControl1();
                phong.maphong = row["MaPhong"].ToString();
                phong.sophong = row["SoPhong"].ToString();
                phong.loaiphong = row["LoaiPhong"].ToString();

                int sucChua = Convert.ToInt32(row["SucChua"]);
                int soNguoiDaThue = Convert.ToInt32(row["SoNguoiDaThue"]);
                int sucChuaConLai = sucChua - soNguoiDaThue;
                phong.succhua = sucChuaConLai.ToString();

                phong.tinhtrang = row["TinhTrang"].ToString();
                phong.giathue = row["GiaThue"].ToString();
                phong.songuoithue = row["SoNguoiDaThue"].ToString();
                phong.tienich = row["TienIch"].ToString();

                PanelCha.Controls.Add(phong);
            }

        }
        private void SetControls(bool edit)
        {
            txtMaPhong.Enabled = edit;
            txtSoPhong.Enabled = edit;
            txtLoaiPhong.Enabled = edit;
            txtSucChua.Enabled = edit;
            txtSoNguoiThue.Enabled = edit;
            txtTinhTrangPhong.Enabled = edit;
            txtTienIch.Enabled = edit;
            txtGiaThue.Enabled = edit;
            btnSignRoom.Enabled = edit;

        }
        private void btnSignRoom_Click(object sender, EventArgs e)
        {
            string MaND = FrmLogin.MaNguoiDung;
            string MaPhong = txtMaPhong.Text;
            string NgayYeuCau = DateTime.Now.ToString("yyyy-MM-dd");
            string TrangThai = "Chờ duyệt";
            SetControls(true);

            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string getSql = $"SELECT SoNguoiDaThue, SucChua FROM tblPhong WHERE MaPhong = {MaPhong}";
            DataTable dt = myDataServices.RunQuery(getSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int soNguoiDaThue = Convert.ToInt32(dt.Rows[0]["SoNguoiDaThue"]);
            int sucChua = Convert.ToInt32(dt.Rows[0]["SucChua"]);

            if (soNguoiDaThue >= sucChua)
            {
                MessageBox.Show("Phòng đã đủ người!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sSql = "insert into tblYeuCauThuePhong (MaNguoiDung, MaPhong, NgayYeuCau, TrangThai) " +
                          "values (" + MaND + ", " + MaPhong + ", N'" + NgayYeuCau + "', N'" + TrangThai + "')";
            try
            {
                myDataServices.ExecuteNonQuery(sSql);
                soNguoiDaThue++;
                string updateSql;
                if (soNguoiDaThue >= sucChua)
                {
                    updateSql = $"UPDATE tblPhong SET SoNguoiDaThue = {soNguoiDaThue}, TinhTrang = N'Đang sử dụng' WHERE MaPhong = {MaPhong}";
                }
                else
                {
                    updateSql = $"UPDATE tblPhong SET SoNguoiDaThue = {soNguoiDaThue} WHERE MaPhong = {MaPhong}";
                }
                myDataServices.ExecuteNonQuery(updateSql);

                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSearchRoom_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
