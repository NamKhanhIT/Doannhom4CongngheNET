using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("ChiPhi")]
    public class ChiPhi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChiPhi { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiChiPhi { get; set; }

        [Required]
        public decimal SoTien { get; set; }

        [Required]
        public DateTime NgayThanhToan { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [Required]
        public int MaNguoiDung { get; set; }

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
} 