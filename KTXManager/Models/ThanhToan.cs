using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("ThanhToan")]
    public class ThanhToan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThanhToan { get; set; }

        [Required]
        public int MaSinhVien { get; set; }

        [Required]
        public decimal SoTien { get; set; }

        [Required]
        public DateTime NgayThanhToan { get; set; }

        [Required]
        [StringLength(50)]
        public string PhuongThucThanhToan { get; set; }

        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }
    }
} 