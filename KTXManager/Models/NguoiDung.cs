using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(20)]
        public string VaiTro { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public bool TrangThai { get; set; } = true;

        public virtual SinhVien SinhVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
} 