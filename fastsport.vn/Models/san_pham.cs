//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fastsport.vn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class san_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public san_pham()
        {
            this.chi_tiet_hoa_don = new HashSet<chi_tiet_hoa_don>();
            this.chi_tiet_don_dat_hang = new HashSet<chi_tiet_don_dat_hang>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<double> Sale_off { get; set; }
        public Nullable<int> color_id { get; set; }
        public Nullable<int> trang_thai_sp_id { get; set; }
        public Nullable<int> loai_sp_id { get; set; }
        public Nullable<int> size_id { get; set; }
        public string Hinh_1 { get; set; }
        public string Hinh_2 { get; set; }
        public string Hinh_3 { get; set; }
        public string Hinh_4 { get; set; }
        public string Hinh_5 { get; set; }
        public string Hinh_6 { get; set; }
        public string Hinh_7 { get; set; }
        public string Hinh_8 { get; set; }
        public string Hinh_9 { get; set; }
        public string Hinh_10 { get; set; }
        public Nullable<int> nhom_sp_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
        public virtual color color { get; set; }
        public virtual loai_san_pham loai_san_pham { get; set; }
        public virtual nhom_sp nhom_sp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_dat_hang> chi_tiet_don_dat_hang { get; set; }
        public virtual size size { get; set; }
        public virtual trang_thai_sp trang_thai_sp { get; set; }
    }
}
