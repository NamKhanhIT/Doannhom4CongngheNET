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
    
    public partial class tblTang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTang()
        {
            this.tblPhongs = new HashSet<tblPhong>();
        }
    
        public int MaTang { get; set; }
        public Nullable<int> MaToaNha { get; set; }
        public Nullable<int> SoTang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhong> tblPhongs { get; set; }
        public virtual tblToaNha tblToaNha { get; set; }
    }
}
