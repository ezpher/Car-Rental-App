﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalDesktopApp.CarRentalLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarRentalAppEntities : DbContext
    {
        public CarRentalAppEntities()
            : base("name=CarRentalAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarRecord> CarRecords { get; set; }
        public virtual DbSet<CarRentalRecord> CarRentalRecords { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
