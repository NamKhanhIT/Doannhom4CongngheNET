using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;

namespace KTXManager.Forms
{
    public partial class QuanLyPhongForm : UserControl
    {
        private readonly KTXContext _context;
        private Phong _selectedPhong;

        public QuanLyPhongForm()
        {
            InitializeComponent();
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            LoadPhongData();
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
            this.gridPhong = new DataGridView();
            this.columnMaPhong = new DataGridViewTextBoxColumn();
            this.columnTenPhong = new DataGridViewTextBoxColumn();
            this.columnLoaiPhong = new DataGridViewTextBoxColumn();
            this.columnSoLuongSinhVien = new DataGridViewTextBoxColumn();
            this.columnTrangThai = new DataGridViewTextBoxColumn();

            // Panel Header
            this.panelHeader.BackColor = Color.FromArgb(94, 148, 255);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Padding = new Padding(20);

            // Label Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG";
            this.lblTitle.Location = new Point(20, 15);

            // Panel Search
            this.panelSearch.Dock = DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.Padding = new Padding(20);
            this.panelSearch.BackColor = Color.White;

            this.txtSearch.Font = new Font("Segoe UI", 9F);
            this.txtSearch.Location = new Point(20, 15);
            this.txtSearch.Size = new Size(300, 30);
            this.txtSearch.PlaceholderText = "Nhập tên phòng để tìm kiếm...";

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
            this.gridPhong.Dock = DockStyle.Fill;
            this.gridPhong.BackgroundColor = Color.White;
            this.gridPhong.BorderStyle = BorderStyle.None;
            this.gridPhong.Font = new Font("Segoe UI", 9F);
            this.gridPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridPhong.MultiSelect = false;
            this.gridPhong.AllowUserToAddRows = false;
            this.gridPhong.AllowUserToDeleteRows = false;
            this.gridPhong.ReadOnly = true;
            this.gridPhong.RowHeadersVisible = false;
            this.gridPhong.SelectionChanged += new EventHandler(gridPhong_SelectionChanged);

            // Columns
            this.columnMaPhong.HeaderText = "Mã phòng";
            this.columnMaPhong.DataPropertyName = "MaPhong";
            this.columnMaPhong.Width = 100;

            this.columnTenPhong.HeaderText = "Tên phòng";
            this.columnTenPhong.DataPropertyName = "TenPhong";
            this.columnTenPhong.Width = 150;

            this.columnLoaiPhong.HeaderText = "Loại phòng";
            this.columnLoaiPhong.DataPropertyName = "LoaiPhong";
            this.columnLoaiPhong.Width = 150;

            this.columnSoLuongSinhVien.HeaderText = "Số lượng sinh viên";
            this.columnSoLuongSinhVien.DataPropertyName = "SoLuongSinhVien";
            this.columnSoLuongSinhVien.Width = 150;

            this.columnTrangThai.HeaderText = "Trạng thái";
            this.columnTrangThai.DataPropertyName = "TrangThai";
            this.columnTrangThai.Width = 150;

            this.gridPhong.Columns.Add(this.columnMaPhong);
            this.gridPhong.Columns.Add(this.columnTenPhong);
            this.gridPhong.Columns.Add(this.columnLoaiPhong);
            this.gridPhong.Columns.Add(this.columnSoLuongSinhVien);
            this.gridPhong.Columns.Add(this.columnTrangThai);

            // Add controls to panels
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);

            this.panelActions.Controls.Add(this.btnAdd);
            this.panelActions.Controls.Add(this.btnEdit);
            this.panelActions.Controls.Add(this.btnDelete);

            this.panelGrid.Controls.Add(this.gridPhong);

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
        private DataGridView gridPhong;
        private DataGridViewTextBoxColumn columnMaPhong;
        private DataGridViewTextBoxColumn columnTenPhong;
        private DataGridViewTextBoxColumn columnLoaiPhong;
        private DataGridViewTextBoxColumn columnSoLuongSinhVien;
        private DataGridViewTextBoxColumn columnTrangThai;

        private void LoadPhongData()
        {
            try
            {
                var phongs = _context.Phongs.ToList();
                gridPhong.DataSource = phongs;
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
                var phongs = _context.Phongs
                    .Where(p => p.TenPhong.ToLower().Contains(searchText))
                    .ToList();
                gridPhong.DataSource = phongs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (gridPhong.SelectedRows.Count > 0)
            {
                _selectedPhong = (Phong)gridPhong.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _selectedPhong = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PhongForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPhongData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedPhong == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new PhongForm(_selectedPhong))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPhongData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPhong == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.Phongs.Remove(_selectedPhong);
                    _context.SaveChanges();
                    LoadPhongData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 