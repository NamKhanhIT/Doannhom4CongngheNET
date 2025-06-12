using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;

namespace KTXManager.Forms
{
    public partial class SinhVienForm : Form
    {
        private readonly KTXContext _context;
        private readonly SinhVien _sinhVien;
        private readonly bool _isEdit;

        public SinhVienForm(SinhVien sinhVien = null)
        {
            InitializeComponent();
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            _sinhVien = sinhVien ?? new SinhVien();
            _isEdit = sinhVien != null;

            LoadPhongData();
            if (_isEdit)
            {
                LoadSinhVienData();
            }
        }

        private void InitializeComponent()
        {
            this.Text = _isEdit ? "Sửa sinh viên" : "Thêm sinh viên mới";
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Panel Header
            this.panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(94, 148, 255)
            };

            this.lblTitle = new Label
            {
                Text = _isEdit ? "SỬA THÔNG TIN SINH VIÊN" : "THÊM SINH VIÊN MỚI",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 15)
            };

            // Panel Content
            this.panelContent = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            // Form fields
            this.lblHoTen = new Label
            {
                Text = "Họ tên:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            this.txtHoTen = new TextBox
            {
                Location = new Point(120, 20),
                Size = new Size(300, 30)
            };

            this.lblNgaySinh = new Label
            {
                Text = "Ngày sinh:",
                Location = new Point(20, 70),
                AutoSize = true
            };

            this.dtpNgaySinh = new DateTimePicker
            {
                Location = new Point(120, 70),
                Size = new Size(300, 30),
                Format = DateTimePickerFormat.Short
            };

            this.lblGioiTinh = new Label
            {
                Text = "Giới tính:",
                Location = new Point(20, 120),
                AutoSize = true
            };

            this.cboGioiTinh = new ComboBox
            {
                Location = new Point(120, 120),
                Size = new Size(300, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            this.lblDiaChi = new Label
            {
                Text = "Địa chỉ:",
                Location = new Point(20, 170),
                AutoSize = true
            };

            this.txtDiaChi = new TextBox
            {
                Location = new Point(120, 170),
                Size = new Size(300, 30)
            };

            this.lblSoDienThoai = new Label
            {
                Text = "Số điện thoại:",
                Location = new Point(20, 220),
                AutoSize = true
            };

            this.txtSoDienThoai = new TextBox
            {
                Location = new Point(120, 220),
                Size = new Size(300, 30)
            };

            this.lblEmail = new Label
            {
                Text = "Email:",
                Location = new Point(20, 270),
                AutoSize = true
            };

            this.txtEmail = new TextBox
            {
                Location = new Point(120, 270),
                Size = new Size(300, 30)
            };

            this.lblPhong = new Label
            {
                Text = "Phòng:",
                Location = new Point(20, 320),
                AutoSize = true
            };

            this.cboPhong = new ComboBox
            {
                Location = new Point(120, 320),
                Size = new Size(300, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Panel Footer
            this.panelFooter = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.White
            };

            this.btnSave = new Button
            {
                Text = "Lưu",
                BackColor = Color.FromArgb(94, 148, 255),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Size = new Size(100, 30),
                Location = new Point(220, 15)
            };
            this.btnSave.Click += new EventHandler(btnSave_Click);

            this.btnCancel = new Button
            {
                Text = "Hủy",
                BackColor = Color.FromArgb(255, 128, 128),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Size = new Size(100, 30),
                Location = new Point(330, 15)
            };
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            // Add controls to panels
            this.panelHeader.Controls.Add(this.lblTitle);

            this.panelContent.Controls.Add(this.lblHoTen);
            this.panelContent.Controls.Add(this.txtHoTen);
            this.panelContent.Controls.Add(this.lblNgaySinh);
            this.panelContent.Controls.Add(this.dtpNgaySinh);
            this.panelContent.Controls.Add(this.lblGioiTinh);
            this.panelContent.Controls.Add(this.cboGioiTinh);
            this.panelContent.Controls.Add(this.lblDiaChi);
            this.panelContent.Controls.Add(this.txtDiaChi);
            this.panelContent.Controls.Add(this.lblSoDienThoai);
            this.panelContent.Controls.Add(this.txtSoDienThoai);
            this.panelContent.Controls.Add(this.lblEmail);
            this.panelContent.Controls.Add(this.txtEmail);
            this.panelContent.Controls.Add(this.lblPhong);
            this.panelContent.Controls.Add(this.cboPhong);

            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnCancel);

            // Add panels to form
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhong;
        private ComboBox cboPhong;
        private Panel panelFooter;
        private Button btnSave;
        private Button btnCancel;

        private void LoadPhongData()
        {
            try
            {
                var phongs = _context.Phongs.ToList();
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";
                cboPhong.DataSource = phongs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSinhVienData()
        {
            txtHoTen.Text = _sinhVien.HoTen;
            dtpNgaySinh.Value = _sinhVien.NgaySinh;
            cboGioiTinh.Text = _sinhVien.GioiTinh;
            txtDiaChi.Text = _sinhVien.DiaChi;
            txtSoDienThoai.Text = _sinhVien.SoDienThoai;
            txtEmail.Text = _sinhVien.Email;
            cboPhong.SelectedValue = _sinhVien.MaPhong;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _sinhVien.HoTen = txtHoTen.Text;
                _sinhVien.NgaySinh = dtpNgaySinh.Value;
                _sinhVien.GioiTinh = cboGioiTinh.Text;
                _sinhVien.DiaChi = txtDiaChi.Text;
                _sinhVien.SoDienThoai = txtSoDienThoai.Text;
                _sinhVien.Email = txtEmail.Text;
                _sinhVien.MaPhong = (int)cboPhong.SelectedValue;

                if (!_isEdit)
                {
                    _context.SinhViens.Add(_sinhVien);
                }

                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 