﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaEntities : DbContext
    {
        public CinemaEntities()
            : base("name=CinemaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GENRES> GENRES { get; set; }
        public virtual DbSet<HALL> HALL { get; set; }
        public virtual DbSet<MOVIES> MOVIES { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULE { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
