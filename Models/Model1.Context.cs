﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDPeopleMotion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDPEOPLEMOTIONEntities : DbContext
    {
        public BDPEOPLEMOTIONEntities()
            : base("name=BDPEOPLEMOTIONEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
    }
}