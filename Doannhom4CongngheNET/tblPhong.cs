//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doannhom4CongngheNET
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhong()
        {
            this.tblHoaDons = new HashSet<tblHoaDon>();
            this.tblKhoDoNoiThats = new HashSet<tblKhoDoNoiThat>();
            this.tblKiemTraPhongs = new HashSet<tblKiemTraPhong>();
            this.tblPhanPhongs = new HashSet<tblPhanPhong>();
            this.tblYeuCauThuePhongs = new HashSet<tblYeuCauThuePhong>();
            this.tblYeuCauBaoTris = new HashSet<tblYeuCauBaoTri>();
        }
    
        public int MaPhong { get; set; }
        public Nullable<int> MaTang { get; set; }
        public string SoPhong { get; set; }
        public string LoaiPhong { get; set; }
        public Nullable<int> SucChua { get; set; }
        public string TinhTrang { get; set; }
        public string TienIch { get; set; }
        public Nullable<decimal> GiaThue { get; set; }
        public Nullable<int> SoNguoiDaThue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHoaDon> tblHoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKhoDoNoiThat> tblKhoDoNoiThats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKiemTraPhong> tblKiemTraPhongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhanPhong> tblPhanPhongs { get; set; }
        public virtual tblTang tblTang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblYeuCauThuePhong> tblYeuCauThuePhongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblYeuCauBaoTri> tblYeuCauBaoTris { get; set; }
    }
}
