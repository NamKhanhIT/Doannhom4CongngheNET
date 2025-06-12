using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using KTXManager.Models;
using KTXManager.Data;
using Microsoft.EntityFrameworkCore;

namespace KTXManager.Forms
{
    public partial class DashboardForm : UserControl
    {
        private readonly KTXContext _context;

        public DashboardForm()
        {
            InitializeComponent();
            _context = new KTXContext(new DbContextOptionsBuilder<KTXContext>()
                .UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True")
                .Options);

            LoadDashboardData();
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelStats = new Panel();
            this.panelPhong = new Panel();
            this.lblPhongTitle = new Label();
            this.lblPhongCount = new Label();
            this.panelSinhVien = new Panel();
            this.lblSinhVienTitle = new Label();
            this.lblSinhVienCount = new Label();
            this.panelChiPhi = new Panel();
            this.lblChiPhiTitle = new Label();
            this.lblChiPhiCount = new Label();
            this.panelBaoTri = new Panel();
            this.lblBaoTriTitle = new Label();
            this.lblBaoTriCount = new Label();
            this.panelRecentActivities = new Panel();
            this.lblRecentActivities = new Label();
            this.listRecentActivities = new ListView();
            this.columnTime = new ColumnHeader();
            this.columnActivity = new ColumnHeader();

            // Panel Header
            this.panelHeader.BackColor = Color.FromArgb(94, 148, 255);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Padding = new Padding(20);

            // Label Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
            this.lblTitle.Location = new Point(20, 15);

            // Panel Stats
            this.panelStats.Dock = DockStyle.Top;
            this.panelStats.Height = 120;
            this.panelStats.Padding = new Padding(20);
            this.panelStats.BackColor = Color.White;

            // Panel Phong
            this.panelPhong.BackColor = Color.FromArgb(94, 148, 255);
            this.panelPhong.Size = new Size(200, 80);
            this.panelPhong.Location = new Point(20, 20);
            this.panelPhong.Padding = new Padding(10);

            this.lblPhongTitle.AutoSize = true;
            this.lblPhongTitle.Font = new Font("Segoe UI", 10F);
            this.lblPhongTitle.ForeColor = Color.White;
            this.lblPhongTitle.Text = "TỔNG SỐ PHÒNG";
            this.lblPhongTitle.Location = new Point(10, 10);

            this.lblPhongCount.AutoSize = true;
            this.lblPhongCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblPhongCount.ForeColor = Color.White;
            this.lblPhongCount.Text = "0";
            this.lblPhongCount.Location = new Point(10, 35);

            // Panel SinhVien
            this.panelSinhVien.BackColor = Color.FromArgb(255, 128, 128);
            this.panelSinhVien.Size = new Size(200, 80);
            this.panelSinhVien.Location = new Point(240, 20);
            this.panelSinhVien.Padding = new Padding(10);

            this.lblSinhVienTitle.AutoSize = true;
            this.lblSinhVienTitle.Font = new Font("Segoe UI", 10F);
            this.lblSinhVienTitle.ForeColor = Color.White;
            this.lblSinhVienTitle.Text = "TỔNG SỐ SINH VIÊN";
            this.lblSinhVienTitle.Location = new Point(10, 10);

            this.lblSinhVienCount.AutoSize = true;
            this.lblSinhVienCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblSinhVienCount.ForeColor = Color.White;
            this.lblSinhVienCount.Text = "0";
            this.lblSinhVienCount.Location = new Point(10, 35);

            // Panel ChiPhi
            this.panelChiPhi.BackColor = Color.FromArgb(128, 255, 128);
            this.panelChiPhi.Size = new Size(200, 80);
            this.panelChiPhi.Location = new Point(460, 20);
            this.panelChiPhi.Padding = new Padding(10);

            this.lblChiPhiTitle.AutoSize = true;
            this.lblChiPhiTitle.Font = new Font("Segoe UI", 10F);
            this.lblChiPhiTitle.ForeColor = Color.White;
            this.lblChiPhiTitle.Text = "CHI PHÍ THÁNG NÀY";
            this.lblChiPhiTitle.Location = new Point(10, 10);

            this.lblChiPhiCount.AutoSize = true;
            this.lblChiPhiCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblChiPhiCount.ForeColor = Color.White;
            this.lblChiPhiCount.Text = "0 VNĐ";
            this.lblChiPhiCount.Location = new Point(10, 35);

            // Panel BaoTri
            this.panelBaoTri.BackColor = Color.FromArgb(255, 192, 128);
            this.panelBaoTri.Size = new Size(200, 80);
            this.panelBaoTri.Location = new Point(680, 20);
            this.panelBaoTri.Padding = new Padding(10);

            this.lblBaoTriTitle.AutoSize = true;
            this.lblBaoTriTitle.Font = new Font("Segoe UI", 10F);
            this.lblBaoTriTitle.ForeColor = Color.White;
            this.lblBaoTriTitle.Text = "YÊU CẦU BẢO TRÌ";
            this.lblBaoTriTitle.Location = new Point(10, 10);

            this.lblBaoTriCount.AutoSize = true;
            this.lblBaoTriCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblBaoTriCount.ForeColor = Color.White;
            this.lblBaoTriCount.Text = "0";
            this.lblBaoTriCount.Location = new Point(10, 35);

            // Panel Recent Activities
            this.panelRecentActivities.Dock = DockStyle.Fill;
            this.panelRecentActivities.Padding = new Padding(20);
            this.panelRecentActivities.BackColor = Color.White;

            this.lblRecentActivities.AutoSize = true;
            this.lblRecentActivities.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblRecentActivities.Text = "HOẠT ĐỘNG GẦN ĐÂY";
            this.lblRecentActivities.Location = new Point(20, 20);

            this.listRecentActivities.View = View.Details;
            this.listRecentActivities.FullRowSelect = true;
            this.listRecentActivities.GridLines = true;
            this.listRecentActivities.Location = new Point(20, 50);
            this.listRecentActivities.Size = new Size(1120, 400);
            this.listRecentActivities.Font = new Font("Segoe UI", 9F);

            this.columnTime.Text = "Thời gian";
            this.columnTime.Width = 150;

            this.columnActivity.Text = "Hoạt động";
            this.columnActivity.Width = 950;

            this.listRecentActivities.Columns.Add(this.columnTime);
            this.listRecentActivities.Columns.Add(this.columnActivity);

            // Add controls to panels
            this.panelPhong.Controls.Add(this.lblPhongTitle);
            this.panelPhong.Controls.Add(this.lblPhongCount);

            this.panelSinhVien.Controls.Add(this.lblSinhVienTitle);
            this.panelSinhVien.Controls.Add(this.lblSinhVienCount);

            this.panelChiPhi.Controls.Add(this.lblChiPhiTitle);
            this.panelChiPhi.Controls.Add(this.lblChiPhiCount);

            this.panelBaoTri.Controls.Add(this.lblBaoTriTitle);
            this.panelBaoTri.Controls.Add(this.lblBaoTriCount);

            this.panelStats.Controls.Add(this.panelPhong);
            this.panelStats.Controls.Add(this.panelSinhVien);
            this.panelStats.Controls.Add(this.panelChiPhi);
            this.panelStats.Controls.Add(this.panelBaoTri);

            this.panelRecentActivities.Controls.Add(this.lblRecentActivities);
            this.panelRecentActivities.Controls.Add(this.listRecentActivities);

            this.panelHeader.Controls.Add(this.lblTitle);

            // Add panels to form
            this.Controls.Add(this.panelRecentActivities);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelHeader);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelStats;
        private Panel panelPhong;
        private Label lblPhongTitle;
        private Label lblPhongCount;
        private Panel panelSinhVien;
        private Label lblSinhVienTitle;
        private Label lblSinhVienCount;
        private Panel panelChiPhi;
        private Label lblChiPhiTitle;
        private Label lblChiPhiCount;
        private Panel panelBaoTri;
        private Label lblBaoTriTitle;
        private Label lblBaoTriCount;
        private Panel panelRecentActivities;
        private Label lblRecentActivities;
        private ListView listRecentActivities;
        private ColumnHeader columnTime;
        private ColumnHeader columnActivity;

        private void LoadDashboardData()
        {
            try
            {
                // Load tổng số phòng
                var totalPhong = _context.Phongs.Count();
                lblPhongCount.Text = totalPhong.ToString();

                // Load tổng số sinh viên
                var totalSinhVien = _context.SinhViens.Count();
                lblSinhVienCount.Text = totalSinhVien.ToString();

                // Load chi phí tháng này
                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;
                var chiPhiThangNay = _context.ChiPhis
                    .Where(cp => cp.NgayThanhToan.Month == currentMonth && cp.NgayThanhToan.Year == currentYear)
                    .Sum(cp => cp.SoTien);
                lblChiPhiCount.Text = $"{chiPhiThangNay:N0} VNĐ";

                // Load số yêu cầu bảo trì chưa xử lý
                var baoTriChuaXuLy = _context.YeuCauBaoTris
                    .Count(yc => yc.TrangThai == "Chờ xử lý");
                lblBaoTriCount.Text = baoTriChuaXuLy.ToString();

                // Load hoạt động gần đây
                var recentActivities = _context.NhatKyTruyCaps
                    .OrderByDescending(nk => nk.ThoiGian)
                    .Take(10)
                    .ToList();

                listRecentActivities.Items.Clear();
                foreach (var activity in recentActivities)
                {
                    // Fix for CS1501: Ensure that the nullable DateTime? type is properly handled before calling ToString with a format string.
                    var item = new ListViewItem(activity.ThoiGian.HasValue
                        ? activity.ThoiGian.Value.ToString("dd/MM/yyyy HH:mm")
                        : "N/A");
                    item.SubItems.Add($"{activity.NguoiDung.HoTen} - {activity.LoaiTruyCap}");
                    listRecentActivities.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 