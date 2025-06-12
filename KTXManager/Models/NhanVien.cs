using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblNhanVien")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public int? MaNguoiDung { get; set; }
        public string Ten { get; set; }
        public string ChucVu { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public int? MaToaNhaDuocPhanCong { get; set; }

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaToaNhaDuocPhanCong")]
        public virtual ToaNha ToaNhaDuocPhanCong { get; set; }
    }
} 