//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewspaperDoAnV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Newspaper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Newspaper()
        {
            this.Comments = new HashSet<Comment>();
            this.Likeds = new HashSet<Liked>();
        }
    
        public int NewspaperId { get; set; }
        public string Newspaper_tieude { get; set; }
        public string Newspaper_tieudephu { get; set; }
        public string Newspaper_anh { get; set; }
        public string Newspaper_noidung { get; set; }
        public int UserID { get; set; }
        public int danhmuc_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Danh_muc Danh_muc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liked> Likeds { get; set; }
        public virtual User User { get; set; }
    }
}
