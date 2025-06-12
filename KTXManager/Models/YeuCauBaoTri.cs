using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("YeuCauBaoTri")]
    public class YeuCauBaoTri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaYeuCau { get; set; }

        [Required]
        [StringLength(100)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(500)]
        public string NoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        [Required]
        public DateTime NgayTao { get; set; }

        [Required]
        public int MaPhong { get; set; }

        [Required]
        public int MaSinhVien { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }

        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }
    }
} 