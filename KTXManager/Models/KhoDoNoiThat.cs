using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblKhoDoNoiThat")]
    public class KhoDoNoiThat
    {
        [Key]
        public int MaDo { get; set; }
        public int? MaPhong { get; set; }
        public string TenDo { get; set; }
        public int? SoLuong { get; set; }
        public string TinhTrang { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
} 