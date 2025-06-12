using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblNhatKyTruyCap")]
    public class NhatKyTruyCap
    {
        [Key]
        public int MaNhatKy { get; set; }
        public int? MaNguoiDung { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string LoaiTruyCap { get; set; }

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
} 