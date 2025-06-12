using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblToaNha")]
    public class ToaNha
    {
        [Key]
        public int MaToaNha { get; set; }
        public string TenToaNha { get; set; }
        public string DiaChi { get; set; }
        public int? SoTang { get; set; }
    }
} 