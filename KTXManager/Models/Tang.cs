using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTXManager.Models
{
    [Table("tblTang")]
    public class Tang
    {
        [Key]
        public int MaTang { get; set; }
        public int? MaToaNha { get; set; }
        public int? SoTang { get; set; }

        [ForeignKey("MaToaNha")]
        public virtual ToaNha ToaNha { get; set; }
    }
} 