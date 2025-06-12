using System;
using System.Windows.Forms;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KTXManager.Forms
{
    public partial class MainForm : Form
    {
        private readonly KTXContext _context;
        private readonly NguoiDung _currentUser;
        private DashboardForm _dashboardForm;
        private QuanLyPhongForm _quanLyPhongForm;

        public MainForm(NguoiDung user)
        {
            InitializeComponent();
            _currentUser = user;
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            // Hiển thị thông tin người dùng
            lblUserInfo.Text = $"Xin chào, {user.HoTen} ({user.VaiTro})";

            // Khởi tạo DashboardForm
            _dashboardForm = new DashboardForm();
            _dashboardForm.Dock = DockStyle.Fill;
            tabDashboard.Controls.Add(_dashboardForm);

            // Khởi tạo QuanLyPhongForm
            _quanLyPhongForm = new QuanLyPhongForm();
            _quanLyPhongForm.Dock = DockStyle.Fill;
            tabQuanLyPhong.Controls.Add(_quanLyPhongForm);
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabDashboard = new TabPage();
            this.tabQuanLyPhong = new TabPage();
            this.tabQuanLySinhVien = new TabPage();
            this.tabQuanLyChiPhi = new TabPage();
            this.tabQuanLyBaoTri = new TabPage();
            this.lblUserInfo = new Label();
            this.btnLogout = new Button();
            this.panelHeader = new Panel();

            // Thiết lập form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Ký túc xá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackColor = System.Drawing.Color.White;

            // Panel header
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;

            // Label thông tin người dùng
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(20, 20);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(300, 19);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Xin chào, ...";

            // Nút đăng xuất
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1100, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Thiết lập tab control
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 640);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Appearance = TabAppearance.FlatButtons;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl.SizeMode = TabSizeMode.Fixed;

            // Tab Dashboard
            this.tabDashboard.Text = "Trang chủ";
            this.tabDashboard.UseVisualStyleBackColor = true;

            // Tab Quản lý phòng
            this.tabQuanLyPhong.Text = "Quản lý phòng";
            this.tabQuanLyPhong.UseVisualStyleBackColor = true;

            // Tab Quản lý sinh viên
            this.tabQuanLySinhVien.Text = "Quản lý sinh viên";
            this.tabQuanLySinhVien.UseVisualStyleBackColor = true;

            // Tab Quản lý chi phí
            this.tabQuanLyChiPhi.Text = "Quản lý chi phí";
            this.tabQuanLyChiPhi.UseVisualStyleBackColor = true;

            // Tab Quản lý bảo trì
            this.tabQuanLyBaoTri.Text = "Quản lý bảo trì";
            this.tabQuanLyBaoTri.UseVisualStyleBackColor = true;

            // Thêm các tab vào tab control
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabQuanLyPhong);
            this.tabControl.Controls.Add(this.tabQuanLySinhVien);
            this.tabControl.Controls.Add(this.tabQuanLyChiPhi);
            this.tabControl.Controls.Add(this.tabQuanLyBaoTri);

            // Thêm controls vào form
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tabControl);

            this.ResumeLayout(false);
        }

        private TabControl tabControl;
        private TabPage tabDashboard;
        private TabPage tabQuanLyPhong;
        private TabPage tabQuanLySinhVien;
        private TabPage tabQuanLyChiPhi;
        private TabPage tabQuanLyBaoTri;
        private Label lblUserInfo;
        private Button btnLogout;
        private Panel panelHeader;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                // Ghi log đăng xuất
                _context.NhatKyTruyCaps.Add(new NhatKyTruyCap
                {
                    MaNguoiDung = _currentUser.MaNguoiDung,
                    ThoiGian = DateTime.Now,
                    LoaiTruyCap = "Đăng xuất"
                });
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi log đăng xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng form
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _context.Dispose();
        }
    }
} 