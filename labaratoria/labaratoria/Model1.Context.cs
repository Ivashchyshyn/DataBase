﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labaratoria
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<Diagnosi> Diagnosis { get; set; }
        public virtual DbSet<DOCTORS_1> DOCTORS_1 { get; set; }
        public virtual DbSet<Engineer_1> Engineer_1 { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Laboratory> Laboratories { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Type_of_analysis> Type_of_analyses { get; set; }
    }
}
