using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Cần thiết cho việc tham số hóa truy vấn
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    public partial class FrmQuanLyPhong : Form
    {
        private DataServices myDataServices;
        private DataTable dtAllRooms;
        private bool modeNew;
        private UserControl1 selectedRoomControl = null;
        private string selectedSoPhong = null;
        public FrmQuanLyPhong()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FrmSearchRoom_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CapNhatTinhTrangPhong();
            LoadAllRoomsData();
            LoadComboBoxes();

            DisplayRoomCards(dtAllRooms);
            SetControls(false);

        }

        private void CapNhatTinhTrangPhong()
        {
            string sql = @"
                UPDATE tblPhong
                SET TinhTrang = CASE
                    WHEN SoNguoiDaThue = 0 THEN N'Trống'
                    WHEN SoNguoiDaThue = SucChua THEN N'Đầy'
                    ELSE N'Đang sử dụng'
                END";
            myDataServices.ExecuteNonQuery(sql);
        }
        private void LoadAllRoomsData()
        {
            string sSql = @"
                SELECT
                    p.MaPhong, 
                    tnh.TenToaNha,
                    tg.SoTang,
                    p.SoPhong,
                    p.LoaiPhong,
                    p.SucChua,
                    p.TienIch,
                    p.GiaThue,
                    p.TinhTrang,
                    p.SoNguoiDaThue,
                    COALESCE(STRING_AGG(sv.Ten, N', '), '') AS TenSinhVien
                FROM tblPhong p
                LEFT JOIN tblTang tg ON p.MaTang = tg.MaTang
                LEFT JOIN tblToaNha tnh ON tg.MaToaNha = tnh.MaToaNha
                LEFT JOIN tblPhanPhong pp ON pp.MaPhong = p.MaPhong
                    AND pp.NgayBatDau <= GETDATE()
                    AND (pp.NgayKetThuc IS NULL OR pp.NgayKetThuc >= GETDATE())
                LEFT JOIN tblSinhVien sv ON pp.MaSV = sv.MaSV
                GROUP BY
                    p.MaPhong, tnh.TenToaNha, tg.SoTang, p.SoPhong, p.LoaiPhong,
                    p.SucChua, p.TienIch, p.GiaThue, p.TinhTrang, p.SoNguoiDaThue
                ORDER BY
                    tnh.TenToaNha, tg.SoTang, p.SoPhong;";
            dtAllRooms = myDataServices.RunQuery(sSql);
        }

        private void LoadComboBoxes()
        {

            string sSqlToaNha = "SELECT MaToaNha, TenToaNha FROM tblToaNha ORDER BY TenToaNha";
            DataTable dtToaNha = myDataServices.RunQuery(sSqlToaNha);
            if (dtToaNha != null && dtToaNha.Rows.Count > 0)
            {
                DataRow allRow = dtToaNha.NewRow();
                allRow["MaToaNha"] = DBNull.Value; 
                allRow["TenToaNha"] = "--- Tất cả tòa nhà ---";
                dtToaNha.Rows.InsertAt(allRow, 0);

                cboToaNha.DataSource = dtToaNha;
                cboToaNha.DisplayMember = "TenToaNha";
                cboToaNha.ValueMember = "MaToaNha"; 
            }

            cboSoPhong.Items.Clear();
            cboSoPhong.Items.Add("Tất cả số phòng");
            string sqlSoPhong = "SELECT DISTINCT SoPhong FROM tblPhong ORDER BY SoPhong";
            DataTable dtSoPhong = myDataServices.RunQuery(sqlSoPhong);
            if (dtSoPhong != null && dtSoPhong.Rows.Count > 0)
            {
                foreach (DataRow row in dtSoPhong.Rows)
                {
                    cboSoPhong.Items.Add(row["SoPhong"].ToString());
                }
            }
            cboSoPhong.SelectedIndex = 0;


            cboTinhTrang.Items.Clear();
            cboTinhTrang.Items.Add("--- Tất cả tình trạng ---");
            cboTinhTrang.Items.Add("Trống");
            cboTinhTrang.Items.Add("Đang sử dụng");
            cboTinhTrang.Items.Add("Đầy");
            cboTinhTrang.SelectedIndex = 0;
        }
        private void DisplayRoomCards(DataTable dtSource)
        {
            PanelCha.Controls.Clear();
            if (dtSource == null) return;

            foreach (DataRow row in dtSource.Rows)
            {
                var phong = new UserControl1 
                {
                    sophong = row["SoPhong"]?.ToString() ?? "N/A",
                    loaiphong = row["LoaiPhong"]?.ToString() ?? "N/A",
                    succhua = row["SucChua"]?.ToString() ?? "N/A",
                    tinhtrang = row["TinhTrang"]?.ToString() ?? "N/A",
                    songuoithue = row["SoNguoiDaThue"]?.ToString() ?? "0",
                    tienich = row["TienIch"]?.ToString() ?? "N/A",
                    giathue = row["GiaThue"] is DBNull ? "0" : Convert.ToDecimal(row["GiaThue"]).ToString("N0"),
                    tensv = row["TenSinhVien"]?.ToString() ?? "Chưa có sinh viên"
                };
                phong.Click += (s, ev) => UserControl_Click(row, phong);


                PanelCha.Controls.Add(phong);
            }
        }
        private void UserControl_Click(DataRow rowData, UserControl1 clickedControl)
        {
            if (currentMode == "addRoom" || currentMode == "addSinhVien")
                return;

            selectedRoomControl = clickedControl;
            selectedSoPhong = rowData["SoPhong"].ToString();  
            txtSoPhong.Text = rowData["SoPhong"]?.ToString();
            txtLoaiPhong.Text = rowData["LoaiPhong"]?.ToString();
            txtSucChua.Text = rowData["SucChua"]?.ToString();
            txtSinhVien.Text = rowData["TenSinhVien"]?.ToString();
            txtSoNguoiThue.Text = rowData["SoNguoiDaThue"]?.ToString();
            txtTinhTrangPhong.Text = rowData["TinhTrang"]?.ToString();
            txtTienIch.Text = rowData["TienIch"]?.ToString();
            txtGiaThue.Text = rowData["GiaThue"] is DBNull ? "0" : Convert.ToDecimal(rowData["GiaThue"]).ToString("N0");
        }
        public void LayDuLieu(DataRow rowData, UserControl1 clickedControl)
        {
            UserControl_Click(rowData, clickedControl);
        }


        private string currentMode = string.Empty;
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            modeNew = true;
            txtSoPhong.Clear();
            txtLoaiPhong.Clear();
            txtSucChua.Clear();
            txtSinhVien.Clear();
            txtTienIch.Clear();
            txtGiaThue.Clear();

            SetControls(true);
            currentMode = "addRoom";
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            currentMode = "addSinhVien";

            txtSinhVien.Enabled = true;
            btnSave.Enabled = true;
            btnAddRoom.Enabled = false;
            btnAddSinhVien.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cboToaNha.Enabled = false;
            cboSoPhong.Enabled = false;
            cboTinhTrang.Enabled = false;
            txtLoaiPhong.Enabled = false;
            txtSucChua.Enabled = false;
            txtTienIch.Enabled = false;
            txtGiaThue.Enabled = false;
            txtSoPhong.Enabled = false;
            txtSoNguoiThue.Enabled = false;
            txtTinhTrangPhong.Enabled = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetControls(true);
            currentMode = "updateRoom";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomControl == null || string.IsNullOrEmpty(selectedSoPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa phòng {selectedSoPhong} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string so = selectedSoPhong.Replace("'", "''");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblYeuCauThuePhong " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblPhanPhong " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblKhoDoNoiThat " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblKiemTraPhong " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblYeuCauBaoTri " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");

                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblChiSoDN " +
                    "WHERE MaPhong IN (SELECT MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + so + "')");


                myDataServices.ExecuteNonQuery(
                    "DELETE FROM dbo.tblPhong WHERE SoPhong = N'" + so + "'");

                PanelCha.Controls.Remove(selectedRoomControl);
                selectedRoomControl.Dispose();
                selectedRoomControl = null;

                foreach (var tb in new[] {
                        txtSoPhong, txtLoaiPhong, txtSucChua,
                        txtTinhTrangPhong, txtTienIch, txtGiaThue,
                        txtSinhVien, txtSoNguoiThue })
                {
                    tb.Clear();
                }

                for (int i = dtAllRooms.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtAllRooms.Rows[i]["SoPhong"].ToString() == so)
                        dtAllRooms.Rows.RemoveAt(i);
                }

                MessageBox.Show("Xóa phòng thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                LoadAllRoomsData();
                DisplayRoomCards(dtAllRooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            selectedSoPhong = null;
        }

        private void SetControls(bool enabled)
        {
            cboToaNha.Enabled = !enabled;
            cboSoPhong.Enabled = !enabled;
            cboTinhTrang.Enabled = !enabled;
            txtSoPhong.Enabled = enabled;
            txtLoaiPhong.Enabled = enabled;
            txtSucChua.Enabled = enabled;
            txtSinhVien.Enabled = enabled;
            txtSoNguoiThue.Enabled = !enabled; 
            txtTinhTrangPhong.Enabled = !enabled;
            txtTienIch.Enabled = enabled;
            txtGiaThue.Enabled = enabled;

            btnAddRoom.Enabled = !enabled;
            btnAddSinhVien.Enabled = !enabled;
            btnUpdate.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentMode == "addRoom")
            {
                string soPhong = txtSoPhong.Text.Trim();
                string loaiPhong = txtLoaiPhong.Text.Trim();
                string sucChua = txtSucChua.Text.Trim();
                string tienIch = txtTienIch.Text.Trim();
                string giaThue = txtGiaThue.Text.Trim();

                if (soPhong == "" || loaiPhong == "" || sucChua == "" || giaThue == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(sucChua, out int sucChuaValue) || sucChuaValue <= 0)
                {
                    MessageBox.Show("Sức chứa phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(giaThue, out decimal giaThueValue) || giaThueValue < 0)
                {
                    MessageBox.Show("Giá thuê phải là số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int floor = int.Parse(soPhong.Substring(0, 1));
                if (floor == 6) floor = 5;  

                string sqlGetMaTang = "SELECT MaTang FROM tblTang WHERE SoTang = " + floor;
                DataTable dtMaTang = myDataServices.RunQuery(sqlGetMaTang);
                if (dtMaTang.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tầng " + floor, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maTangValue = Convert.ToInt32(dtMaTang.Rows[0]["MaTang"]);

                string sqlCheck = "SELECT COUNT(*) FROM tblPhong WHERE SoPhong = N'" + soPhong + "'";
                DataTable dtCheck = myDataServices.RunQuery(sqlCheck);
                int existCount = Convert.ToInt32(dtCheck.Rows[0][0]);
                if (existCount > 0)
                {
                    MessageBox.Show("Số phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlInsert =
                    "INSERT INTO tblPhong " +
                    "(MaTang, SoPhong, LoaiPhong, SucChua, TinhTrang, TienIch, GiaThue, SoNguoiDaThue) VALUES " +
                    "("
                    + maTangValue.ToString() + ", "                    // MaTang
                    + "N'" + soPhong.Replace("'", "''") + "', "         // SoPhong
                    + "N'" + loaiPhong.Replace("'", "''") + "', "       // LoaiPhong
                    + sucChuaValue.ToString() + ", "                    // SucChua
                    + "N'Trống', "                                      // TinhTrang
                    + "N'" + tienIch.Replace("'", "''") + "', "         // TienIch
                    + giaThueValue.ToString() + ", "                    // GiaThue
                    + "0" +                                             // SoNguoiDaThue khởi 0
                    ")";
                try
                {
                    myDataServices.ExecuteNonQuery(sqlInsert);
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRoomsData();
                    DisplayRoomCards(dtAllRooms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (currentMode == "updateRoom" && selectedRoomControl != null)
            {
                string newName = txtSinhVien.Text.Trim();
                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                newName = newName.Replace("'", "''");

                string spEsc = selectedSoPhong.Replace("'", "''");
                DataTable dtPhong = myDataServices.RunQuery(
                    "SELECT TOP 1 MaPhong FROM dbo.tblPhong WHERE SoPhong = N'" + spEsc + "'");
                if (dtPhong.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maPhong = Convert.ToInt32(dtPhong.Rows[0]["MaPhong"]);

                try
                {
                    string sqlUpdateSV = @"
                    UPDATE sv
                    SET sv.Ten = N'" + newName + @"'
                    FROM dbo.tblSinhVien sv
                    INNER JOIN dbo.tblPhanPhong pp ON sv.MaSV = pp.MaSV
                    WHERE pp.MaPhong = " + maPhong + @"
                    AND sv.Ten <> N'" + newName + @"'";
                    myDataServices.ExecuteNonQuery(sqlUpdateSV);

                    selectedRoomControl.tensv = newName;

                    txtSinhVien.Clear();
                    SetControls(false);
                    currentMode = "";

                    MessageBox.Show("Sửa tên sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRoomsData();
                    DisplayRoomCards(dtAllRooms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (currentMode == "addSinhVien")
            {
                if (string.IsNullOrEmpty(selectedSoPhong))
                {
                    MessageBox.Show("Vui lòng chọn phòng để thêm sinh viên!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenSV = txtSinhVien.Text.Trim();
                if (tenSV == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sinh viên!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tenSV = tenSV.Replace("'", "''");
                string soPhongEsc = selectedSoPhong.Replace("'", "''");

                DataTable dtMax = myDataServices.RunQuery(@"
                SELECT TOP 1 RIGHT(MaSV,3) AS Num
                FROM dbo.tblSinhVien
                WHERE MaSV LIKE 'SV[0-9][0-9][0-9]'
                ORDER BY MaSV DESC");
                int nextNum = 1;
                if (dtMax.Rows.Count > 0 && int.TryParse(dtMax.Rows[0]["Num"].ToString(), out int n))
                    nextNum = n + 1;
                string newMaSV = "SV" + nextNum.ToString("D3");

                string sql = @"
                INSERT INTO dbo.tblSinhVien (MaSV, Ten)
                VALUES ('" + newMaSV + @"', N'" + tenSV + @"');

                DECLARE @mp INT = (
                  SELECT TOP 1 MaPhong
                  FROM dbo.tblPhong
                  WHERE SoPhong = N'" + soPhongEsc + @"'
                );

                INSERT INTO dbo.tblPhanPhong (MaSV, MaPhong, NgayBatDau, NgayKetThuc)
                VALUES ('" + newMaSV + @"', @mp, GETDATE(), NULL);

                UPDATE dbo.tblPhong
                SET 
                  SoNguoiDaThue = SoNguoiDaThue + 1,
                  TinhTrang = CASE
                    WHEN SoNguoiDaThue + 1 >= SucChua THEN N'Đầy'
                    WHEN SoNguoiDaThue + 1 = 0       THEN N'Trống'
                    ELSE                              N'Đang sử dụng'
                  END
                WHERE MaPhong = @mp;

                DECLARE @soNg INT, @sc INT;
                SELECT @soNg = SoNguoiDaThue, @sc = SucChua
                FROM dbo.tblPhong WHERE MaPhong = @mp;
                IF @soNg >= @sc
                    RAISERROR('Phòng %s đã đầy (%d/%d).',0,1, N'" + soPhongEsc + @"', @soNg, @sc);
                ";

                try
                {
                    myDataServices.ExecuteNonQuery(sql);

                    LoadAllRoomsData();
                    DisplayRoomCards(dtAllRooms);
                    txtSinhVien.Clear();
                    SetControls(false);
                    currentMode = "";

                    MessageBox.Show("Đã thêm sinh viên vào phòng thành công!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetControls(false);
                    currentMode = "";
                }

                return;
            }

            SetControls(false);
            currentMode = string.Empty;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedRoomControl == null)
            {
                MessageBox.Show("Vui lòng chọn phòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtLoaiPhong.Enabled = true;
            txtSucChua.Enabled = true;
            txtTienIch.Enabled = true;
            txtGiaThue.Enabled = true;
            txtSinhVien.Enabled = true;
            txtSoPhong.Enabled = false;
            SetControls(true);
            currentMode = "updateRoom";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = dtAllRooms.DefaultView;
            StringBuilder filter = new StringBuilder();
            if (cboToaNha.SelectedIndex > 0 && cboToaNha.SelectedValue != DBNull.Value)
            {
                filter.AppendFormat("TenToaNha = '{0}'", cboToaNha.Text.Replace("'", "''"));
            }

            if (cboTinhTrang.SelectedIndex > 0)
            {
                if (filter.Length > 0) filter.Append(" AND ");
                filter.AppendFormat("TinhTrang = '{0}'", cboTinhTrang.SelectedItem.ToString().Replace("'", "''"));
            }

            if (cboSoPhong.SelectedIndex > 0)
            {
                if (filter.Length > 0) filter.Append(" AND ");
                filter.AppendFormat("SoPhong = '{0}'", cboSoPhong.SelectedItem.ToString().Replace("'", "''"));
            }

            dv.RowFilter = filter.ToString();
            DisplayRoomCards(dv.ToTable());

        }
    }
}