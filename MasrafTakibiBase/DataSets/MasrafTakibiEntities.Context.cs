﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasrafTakibiBase.DataSets
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MasrafTakibiEntities : DbContext
    {
        public MasrafTakibiEntities()
            : base("name=MasrafTakibiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<giderhardetail> giderhardetail { get; set; }
        public virtual DbSet<giderharmain> giderharmain { get; set; }
        public virtual DbSet<parFirma> parFirma { get; set; }
        public virtual DbSet<parGider> parGider { get; set; }
        public virtual DbSet<parGiderTip> parGiderTip { get; set; }
        public virtual DbSet<parLogin> parLogin { get; set; }
    }
}
