﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeMVCV1._2.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HusteDbEntities : DbContext
    {
        public HusteDbEntities()
            : base("name=HusteDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblBizeKesilenFatura> TblBizeKesilenFatura { get; set; }
        public virtual DbSet<TblBizeKesilenFaturaIcerik> TblBizeKesilenFaturaIcerik { get; set; }
        public virtual DbSet<TblHesap> TblHesap { get; set; }
        public virtual DbSet<TblKesilenFatura> TblKesilenFatura { get; set; }
        public virtual DbSet<TblKesilenFaturaIcerik> TblKesilenFaturaIcerik { get; set; }
        public virtual DbSet<TblVarliklar> TblVarliklar { get; set; }
    }
}
