using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("ViPham")]
    public class ViPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaViPham { get; set; }

        [Required]
        public int MaSinhVien { get; set; }

        [Required]
        public DateTime NgayViPham { get; set; }

        [Required]
        [StringLength(500)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(50)]
        public string HinhPhat { get; set; }

        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }
    }
} 