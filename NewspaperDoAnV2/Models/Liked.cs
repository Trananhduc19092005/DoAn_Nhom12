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
    
    public partial class Liked
    {
        public int like_id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> NewspaperId { get; set; }
    
        public virtual Newspaper Newspaper { get; set; }
        public virtual User User { get; set; }
    }
}
