using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblYeuCauThuePhong")]
    public class YeuCauThuePhong
    {
        [Key]
        public int MaYeuCau { get; set; }
        public int? MaNguoiDung { get; set; }
        public int? MaPhong { get; set; }
        public DateTime? NgayYeuCau { get; set; }
        public string TrangThai { get; set; }
        public string MoTaTrangThai { get; set; }

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
} 