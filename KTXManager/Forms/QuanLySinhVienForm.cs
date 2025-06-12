using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;

namespace KTXManager.Forms
{
    public partial class QuanLySinhVienForm : UserControl
    {
        private readonly KTXContext _context;
        private SinhVien _selectedSinhVien;

        public QuanLySinhVienForm()
        {
            InitializeComponent();
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            LoadSinhVienData();
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelSearch = new Panel();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.panelActions = new Panel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.panelGrid = new Panel();
            this.gridSinhVien = new DataGridView();
            this.columnMaSinhVien = new DataGridViewTextBoxColumn();
            this.columnHoTen = new DataGridViewTextBoxColumn();
            this.columnNgaySinh = new DataGridViewTextBoxColumn();
            this.columnGioiTinh = new DataGridViewTextBoxColumn();
            this.columnDiaChi = new DataGridViewTextBoxColumn();
            this.columnSoDienThoai = new DataGridViewTextBoxColumn();
            this.columnEmail = new DataGridViewTextBoxColumn();
            this.columnPhong = new DataGridViewTextBoxColumn();

            // Panel Header
            this.panelHeader.BackColor = Color.FromArgb(94, 148, 255);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Padding = new Padding(20);

            // Label Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            this.lblTitle.Location = new Point(20, 15);

            // Panel Search
            this.panelSearch.Dock = DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.Padding = new Padding(20);
            this.panelSearch.BackColor = Color.White;

            this.txtSearch.Font = new Font("Segoe UI", 9F);
            this.txtSearch.Location = new Point(20, 15);
            this.txtSearch.Size = new Size(300, 30);
            this.txtSearch.PlaceholderText = "Nhập tên sinh viên để tìm kiếm...";

            this.btnSearch.BackColor = Color.FromArgb(94, 148, 255);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font = new Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(330, 15);
            this.btnSearch.Size = new Size(100, 30);
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new EventHandler(btnSearch_Click);

            // Panel Actions
            this.panelActions.Dock = DockStyle.Top;
            this.panelActions.Height = 60;
            this.panelActions.Padding = new Padding(20);
            this.panelActions.BackColor = Color.White;

            this.btnAdd.BackColor = Color.FromArgb(94, 148, 255);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(20, 15);
            this.btnAdd.Size = new Size(100, 30);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            this.btnEdit.BackColor = Color.FromArgb(255, 192, 128);
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Font = new Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.Location = new Point(130, 15);
            this.btnEdit.Size = new Size(100, 30);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new EventHandler(btnEdit_Click);

            this.btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(240, 15);
            this.btnDelete.Size = new Size(100, 30);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new EventHandler(btnDelete_Click);

            // Panel Grid
            this.panelGrid.Dock = DockStyle.Fill;
            this.panelGrid.Padding = new Padding(20);
            this.panelGrid.BackColor = Color.White;

            // DataGridView
            this.gridSinhVien.Dock = DockStyle.Fill;
            this.gridSinhVien.BackgroundColor = Color.White;
            this.gridSinhVien.BorderStyle = BorderStyle.None;
            this.gridSinhVien.Font = new Font("Segoe UI", 9F);
            this.gridSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridSinhVien.MultiSelect = false;
            this.gridSinhVien.AllowUserToAddRows = false;
            this.gridSinhVien.AllowUserToDeleteRows = false;
            this.gridSinhVien.ReadOnly = true;
            this.gridSinhVien.RowHeadersVisible = false;
            this.gridSinhVien.SelectionChanged += new EventHandler(gridSinhVien_SelectionChanged);

            // Columns
            this.columnMaSinhVien.HeaderText = "Mã sinh viên";
            this.columnMaSinhVien.DataPropertyName = "MaSinhVien";
            this.columnMaSinhVien.Width = 100;

            this.columnHoTen.HeaderText = "Họ tên";
            this.columnHoTen.DataPropertyName = "HoTen";
            this.columnHoTen.Width = 150;

            this.columnNgaySinh.HeaderText = "Ngày sinh";
            this.columnNgaySinh.DataPropertyName = "NgaySinh";
            this.columnNgaySinh.Width = 100;

            this.columnGioiTinh.HeaderText = "Giới tính";
            this.columnGioiTinh.DataPropertyName = "GioiTinh";
            this.columnGioiTinh.Width = 80;

            this.columnDiaChi.HeaderText = "Địa chỉ";
            this.columnDiaChi.DataPropertyName = "DiaChi";
            this.columnDiaChi.Width = 200;

            this.columnSoDienThoai.HeaderText = "Số điện thoại";
            this.columnSoDienThoai.DataPropertyName = "SoDienThoai";
            this.columnSoDienThoai.Width = 120;

            this.columnEmail.HeaderText = "Email";
            this.columnEmail.DataPropertyName = "Email";
            this.columnEmail.Width = 150;

            this.columnPhong.HeaderText = "Phòng";
            this.columnPhong.DataPropertyName = "Phong.TenPhong";
            this.columnPhong.Width = 100;

            this.gridSinhVien.Columns.Add(this.columnMaSinhVien);
            this.gridSinhVien.Columns.Add(this.columnHoTen);
            this.gridSinhVien.Columns.Add(this.columnNgaySinh);
            this.gridSinhVien.Columns.Add(this.columnGioiTinh);
            this.gridSinhVien.Columns.Add(this.columnDiaChi);
            this.gridSinhVien.Columns.Add(this.columnSoDienThoai);
            this.gridSinhVien.Columns.Add(this.columnEmail);
            this.gridSinhVien.Columns.Add(this.columnPhong);

            // Add controls to panels
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);

            this.panelActions.Controls.Add(this.btnAdd);
            this.panelActions.Controls.Add(this.btnEdit);
            this.panelActions.Controls.Add(this.btnDelete);

            this.panelGrid.Controls.Add(this.gridSinhVien);

            this.panelHeader.Controls.Add(this.lblTitle);

            // Add panels to form
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panelActions;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Panel panelGrid;
        private DataGridView gridSinhVien;
        private DataGridViewTextBoxColumn columnMaSinhVien;
        private DataGridViewTextBoxColumn columnHoTen;
        private DataGridViewTextBoxColumn columnNgaySinh;
        private DataGridViewTextBoxColumn columnGioiTinh;
        private DataGridViewTextBoxColumn columnDiaChi;
        private DataGridViewTextBoxColumn columnSoDienThoai;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnPhong;

        private void LoadSinhVienData()
        {
            try
            {
                var sinhViens = _context.SinhViens
                    .Include(s => s.Phong)
                    .ToList();
                gridSinhVien.DataSource = sinhViens;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var searchText = txtSearch.Text.Trim().ToLower();
                var sinhViens = _context.SinhViens
                    .Include(s => s.Phong)
                    .Where(s => s.HoTen.ToLower().Contains(searchText))
                    .ToList();
                gridSinhVien.DataSource = sinhViens;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSinhVien.SelectedRows.Count > 0)
            {
                _selectedSinhVien = (SinhVien)gridSinhVien.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _selectedSinhVien = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new SinhVienForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSinhVienData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedSinhVien == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new SinhVienForm(_selectedSinhVien))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSinhVienData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSinhVien == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.SinhViens.Remove(_selectedSinhVien);
                    _context.SaveChanges();
                    LoadSinhVienData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 