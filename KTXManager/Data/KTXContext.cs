using Microsoft.EntityFrameworkCore;
using KTXManager.Models;

namespace KTXManager.Data
{
    public class KTXContext : DbContext
    {
        public KTXContext(DbContextOptions<KTXContext> options) : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }
        public DbSet<YeuCauBaoTri> YeuCauBaoTris { get; set; }
        public DbSet<NhatKyTruyCap> NhatKyTruyCaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình NguoiDung
            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.ToTable("NguoiDung");
                entity.HasKey(e => e.MaNguoiDung);
                entity.Property(e => e.TenDangNhap).IsRequired().HasMaxLength(50);
                entity.Property(e => e.MatKhau).IsRequired().HasMaxLength(50);
                entity.Property(e => e.HoTen).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.SoDienThoai).HasMaxLength(20);
                entity.Property(e => e.VaiTro).IsRequired().HasMaxLength(20);
                entity.Property(e => e.NgayTao).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.TrangThai).HasDefaultValue(true);
            });

            // Cấu hình Phong
            modelBuilder.Entity<Phong>(entity =>
            {
                entity.ToTable("Phong");
                entity.HasKey(e => e.MaPhong);
                entity.Property(e => e.TenPhong).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LoaiPhong).IsRequired().HasMaxLength(20);
                entity.Property(e => e.TrangThai).IsRequired().HasMaxLength(20);
            });

            // Cấu hình SinhVien
            // Update the SinhVien entity configuration
            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.ToTable("SinhVien");
                entity.HasKey(e => e.MaSinhVien); // Corrected property name
                entity.Property(e => e.HoTen).IsRequired().HasMaxLength(100);
                entity.Property(e => e.NgaySinh).IsRequired();
                entity.Property(e => e.GioiTinh).IsRequired().HasMaxLength(10);
                entity.Property(e => e.DiaChi).HasMaxLength(200);
                entity.Property(e => e.SoDienThoai).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.MaPhong).IsRequired();
                entity.HasOne(e => e.Phong)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(e => e.MaPhong)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // Cấu hình ChiPhi
            modelBuilder.Entity<ChiPhi>(entity =>
            {
                entity.ToTable("ChiPhi");
                entity.HasKey(e => e.MaChiPhi);
                entity.Property(e => e.LoaiChiPhi).IsRequired().HasMaxLength(50);
                entity.Property(e => e.SoTien).IsRequired();
                entity.Property(e => e.NgayThanhToan).IsRequired();
                entity.Property(e => e.GhiChu).HasMaxLength(200);
                entity.Property(e => e.MaNguoiDung).IsRequired();
                entity.HasOne(e => e.NguoiDung)
                    .WithMany()
                    .HasForeignKey(e => e.MaNguoiDung)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Cấu hình YeuCauBaoTri
            modelBuilder.Entity<YeuCauBaoTri>(entity =>
            {
                entity.ToTable("YeuCauBaoTri");
                entity.HasKey(e => e.MaYeuCau);
                entity.Property(e => e.TieuDe).IsRequired().HasMaxLength(100);
                entity.Property(e => e.NoiDung).IsRequired().HasMaxLength(500);
                entity.Property(e => e.TrangThai).IsRequired().HasMaxLength(20);
                entity.Property(e => e.NgayTao).IsRequired();
                entity.Property(e => e.MaPhong).IsRequired();
                entity.Property(e => e.MaSinhVien).IsRequired();
                entity.HasOne(e => e.Phong)
                    .WithMany()
                    .HasForeignKey(e => e.MaPhong)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.SinhVien)
                    .WithMany()
                    .HasForeignKey(e => e.MaSinhVien)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Cấu hình NhatKyTruyCap
            modelBuilder.Entity<NhatKyTruyCap>(entity =>
            {
                entity.ToTable("NhatKyTruyCap");
                entity.HasKey(e => e.MaNhatKy);
                entity.Property(e => e.ThoiGian).IsRequired();
                entity.Property(e => e.LoaiTruyCap).IsRequired().HasMaxLength(50);
                entity.Property(e => e.MaNguoiDung).IsRequired();
                entity.HasOne(e => e.NguoiDung)
                    .WithMany()
                    .HasForeignKey(e => e.MaNguoiDung)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
} 