﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewspaperV13Entities : DbContext
    {
        public NewspaperV13Entities()
            : base("name=NewspaperV13Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Danh_muc> Danh_muc { get; set; }
        public virtual DbSet<Liked> Likeds { get; set; }
        public virtual DbSet<Newspaper> Newspapers { get; set; }
        public virtual DbSet<Phan_Quyen> Phan_Quyen { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
