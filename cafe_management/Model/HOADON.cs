//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cafe_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CTHDs = new HashSet<CTHD>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> NgXuat { get; set; }
        public Nullable<decimal> TongGia { get; set; }
        public Nullable<int> MaTB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual THEBAN THEBAN { get; set; }
    }
}
