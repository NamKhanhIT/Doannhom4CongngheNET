using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblKiemTraPhong")]
    public class KiemTraPhong
    {
        [Key]
        public int MaKiemTra { get; set; }
        public int? MaPhong { get; set; }
        public DateTime? NgayKiemTra { get; set; }
        public string MaNhanVien { get; set; }
        public string GhiChu { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }

        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
    }
} 