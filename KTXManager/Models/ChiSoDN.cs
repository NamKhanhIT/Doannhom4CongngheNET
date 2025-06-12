using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblChiSoDN")]
    public class ChiSoDN
    {
        [Key]
        public int MaChiSo { get; set; }
        public int MaPhong { get; set; }
        public byte Thang { get; set; }
        public short Nam { get; set; }
        public int ChiSoDien { get; set; }
        public int ChiSoNuoc { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
} 