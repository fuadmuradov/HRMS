﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMS2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRMSystemEntities : DbContext
    {
        public HRMSystemEntities()
            : base("name=HRMSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Earning_details> Earning_details { get; set; }
        public virtual DbSet<Emp_Adress> Emp_Adress { get; set; }
        public virtual DbSet<Emp_company> Emp_company { get; set; }
        public virtual DbSet<Emp_main> Emp_main { get; set; }
        public virtual DbSet<Is_ayrintilari> Is_ayrintilari { get; set; }
        public virtual DbSet<Leaf> Leaves { get; set; }
        public virtual DbSet<Monthly_Leaves> Monthly_Leaves { get; set; }
        public virtual DbSet<Muraciet1> Muraciet1 { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}