using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;

namespace Doannhom4CongngheNET
{
    public partial class FrmEmployeeManagement : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5H4QKBF\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private SqlDataAdapter adapter;
        private DataTable dt;
        private int currentRow = -1;

        public FrmEmployeeManagement()
        {
            InitializeComponent();
            LoadData();
            SetupDataGridView();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                adapter = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SetupDataGridView()
        {
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(78, 115, 223);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            EnableInputs(true);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRow >= 0)
            {
                EnableInputs(true);
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentRow >= 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", dgvEmployees.Rows[currentRow].Cells["MaNV"].Value);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    conn.Open();
                    string query;
                    SqlCommand cmd;

                    if (string.IsNullOrEmpty(txtMaNV.Text)) // Thêm mới
                    {
                        query = @"INSERT INTO NhanVien (HoTen, Email, SDT, PhongBan, NgaySinh, GioiTinh, DiaChi) 
                                VALUES (@HoTen, @Email, @SDT, @PhongBan, @NgaySinh, @GioiTinh, @DiaChi)";
                        cmd = new SqlCommand(query, conn);
                    }
                    else // Cập nhật
                    {
                        query = @"UPDATE NhanVien 
                                SET HoTen = @HoTen, Email = @Email, SDT = @SDT, 
                                    PhongBan = @PhongBan, NgaySinh = @NgaySinh, 
                                    GioiTinh = @GioiTinh, DiaChi = @DiaChi 
                                WHERE MaNV = @MaNV";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    }

                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@PhongBan", cboPhongBan.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearInputs();
                    EnableInputs(false);
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
            EnableInputs(false);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"HoTen LIKE '%{searchText}%' OR MaNV LIKE '%{searchText}%' OR Email LIKE '%{searchText}%'";
                dgvEmployees.DataSource = dv;
            }
            else
            {
                dgvEmployees.DataSource = dt;
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentRow = e.RowIndex;
                DataGridViewRow row = dgvEmployees.Rows[currentRow];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cboPhongBan.Text = row.Cells["PhongBan"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            cboPhongBan.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = -1;
            txtDiaChi.Clear();
            currentRow = -1;
        }

        private void EnableInputs(bool enable)
        {
            txtHoTen.Enabled = enable;
            txtEmail.Enabled = enable;
            txtSDT.Enabled = enable;
            cboPhongBan.Enabled = enable;
            dtpNgaySinh.Enabled = enable;
            cboGioiTinh.Enabled = enable;
            txtDiaChi.Enabled = enable;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (cboPhongBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongBan.Focus();
                return false;
            }
            if (cboGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return false;
            }
            return true;
        }
    }
} 