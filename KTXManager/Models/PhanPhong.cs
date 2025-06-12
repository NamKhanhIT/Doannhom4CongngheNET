using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("PhanPhong")]
    public class PhanPhong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanPhong { get; set; }

        [Required]
        public int MaSinhVien { get; set; }

        [Required]
        public int MaPhong { get; set; }

        [Required]
        public DateTime NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
} 