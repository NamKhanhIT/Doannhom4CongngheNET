using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("Phong")]
    public class Phong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhong { get; set; }

        [Required]
        [StringLength(20)]
        public string LoaiPhong { get; set; }

        [Required]
        public int SoLuongSinhVien { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
} 