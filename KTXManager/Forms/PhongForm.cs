using System;
using System.Windows.Forms;
using System.Drawing;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;

namespace KTXManager.Forms
{
    public partial class PhongForm : Form
    {
        private readonly KTXContext _context;
        private readonly Phong _phong;
        private readonly bool _isEdit;

        public PhongForm(Phong phong = null)
        {
            InitializeComponent();
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            _isEdit = phong != null;
            _phong = phong ?? new Phong();

            if (_isEdit)
            {
                this.Text = "Sửa phòng";
                LoadPhongData();
            }
            else
            {
                this.Text = "Thêm phòng mới";
            }
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelContent = new Panel();
            this.lblMaPhong = new Label();
            this.txtMaPhong = new TextBox();
            this.lblTenPhong = new Label();
            this.txtTenPhong = new TextBox();
            this.lblLoaiPhong = new Label();
            this.cboLoaiPhong = new ComboBox();
            this.lblSoLuongSinhVien = new Label();
            this.numSoLuongSinhVien = new NumericUpDown();
            this.lblTrangThai = new Label();
            this.cboTrangThai = new ComboBox();
            this.panelFooter = new Panel();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            // Panel Header
            this.panelHeader.BackColor = Color.FromArgb(94, 148, 255);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Padding = new Padding(20);

            // Label Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "THÔNG TIN PHÒNG";
            this.lblTitle.Location = new Point(20, 15);

            // Panel Content
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Padding = new Padding(20);
            this.panelContent.BackColor = Color.White;

            // Label và TextBox Mã phòng
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new Font("Segoe UI", 9F);
            this.lblMaPhong.Location = new Point(20, 20);
            this.lblMaPhong.Text = "Mã phòng:";

            this.txtMaPhong.Font = new Font("Segoe UI", 9F);
            this.txtMaPhong.Location = new Point(150, 20);
            this.txtMaPhong.Size = new Size(300, 30);
            this.txtMaPhong.Enabled = !_isEdit;

            // Label và TextBox Tên phòng
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new Font("Segoe UI", 9F);
            this.lblTenPhong.Location = new Point(20, 60);
            this.lblTenPhong.Text = "Tên phòng:";

            this.txtTenPhong.Font = new Font("Segoe UI", 9F);
            this.txtTenPhong.Location = new Point(150, 60);
            this.txtTenPhong.Size = new Size(300, 30);

            // Label và ComboBox Loại phòng
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new Font("Segoe UI", 9F);
            this.lblLoaiPhong.Location = new Point(20, 100);
            this.lblLoaiPhong.Text = "Loại phòng:";

            this.cboLoaiPhong.Font = new Font("Segoe UI", 9F);
            this.cboLoaiPhong.Location = new Point(150, 100);
            this.cboLoaiPhong.Size = new Size(300, 30);
            this.cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.Items.AddRange(new object[] { "Nam", "Nữ" });

            // Label và NumericUpDown Số lượng sinh viên
            this.lblSoLuongSinhVien.AutoSize = true;
            this.lblSoLuongSinhVien.Font = new Font("Segoe UI", 9F);
            this.lblSoLuongSinhVien.Location = new Point(20, 140);
            this.lblSoLuongSinhVien.Text = "Số lượng sinh viên:";

            this.numSoLuongSinhVien.Font = new Font("Segoe UI", 9F);
            this.numSoLuongSinhVien.Location = new Point(150, 140);
            this.numSoLuongSinhVien.Size = new Size(300, 30);
            this.numSoLuongSinhVien.Minimum = 1;
            this.numSoLuongSinhVien.Maximum = 8;
            this.numSoLuongSinhVien.Value = 4;

            // Label và ComboBox Trạng thái
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new Font("Segoe UI", 9F);
            this.lblTrangThai.Location = new Point(20, 180);
            this.lblTrangThai.Text = "Trạng thái:";

            this.cboTrangThai.Font = new Font("Segoe UI", 9F);
            this.cboTrangThai.Location = new Point(150, 180);
            this.cboTrangThai.Size = new Size(300, 30);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] { "Còn trống", "Đã đầy", "Đang bảo trì" });

            // Panel Footer
            this.panelFooter.Dock = DockStyle.Bottom;
            this.panelFooter.Height = 60;
            this.panelFooter.Padding = new Padding(20);
            this.panelFooter.BackColor = Color.White;

            // Button Save
            this.btnSave.BackColor = Color.FromArgb(94, 148, 255);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 9F);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(150, 15);
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new EventHandler(btnSave_Click);

            // Button Cancel
            this.btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(260, 15);
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            // Add controls to panels
            this.panelContent.Controls.Add(this.lblMaPhong);
            this.panelContent.Controls.Add(this.txtMaPhong);
            this.panelContent.Controls.Add(this.lblTenPhong);
            this.panelContent.Controls.Add(this.txtTenPhong);
            this.panelContent.Controls.Add(this.lblLoaiPhong);
            this.panelContent.Controls.Add(this.cboLoaiPhong);
            this.panelContent.Controls.Add(this.lblSoLuongSinhVien);
            this.panelContent.Controls.Add(this.numSoLuongSinhVien);
            this.panelContent.Controls.Add(this.lblTrangThai);
            this.panelContent.Controls.Add(this.cboTrangThai);

            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnCancel);

            this.panelHeader.Controls.Add(this.lblTitle);

            // Add panels to form
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);

            // Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblTenPhong;
        private TextBox txtTenPhong;
        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;
        private Label lblSoLuongSinhVien;
        private NumericUpDown numSoLuongSinhVien;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Panel panelFooter;
        private Button btnSave;
        private Button btnCancel;

        private void LoadPhongData()
        {
            txtMaPhong.Text = _phong.MaPhong.ToString(); // Convert int to string  
            txtTenPhong.Text = _phong.TenPhong;
            cboLoaiPhong.SelectedItem = _phong.LoaiPhong;
            numSoLuongSinhVien.Value = _phong.SoLuongSinhVien;
            cboTrangThai.SelectedItem = _phong.TrangThai;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate  
                if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cboLoaiPhong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cboTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update data  
                if (!int.TryParse(txtMaPhong.Text, out int maPhong))
                {
                    MessageBox.Show("Mã phòng phải là số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _phong.MaPhong = maPhong;
                _phong.TenPhong = txtTenPhong.Text;
                _phong.LoaiPhong = cboLoaiPhong.SelectedItem.ToString();
                _phong.SoLuongSinhVien = (int)numSoLuongSinhVien.Value;
                _phong.TrangThai = cboTrangThai.SelectedItem.ToString();

                if (!_isEdit)
                {
                    _context.Phongs.Add(_phong);
                }

                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 