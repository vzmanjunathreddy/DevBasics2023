//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDbFirstApproach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FoodDbConext : DbContext
    {
        public FoodDbConext()
            : base("name=FoodDbConext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API ..
            modelBuilder.Entity<Customer>().HasKey(x => x.CustomerId);

            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SupportEmployee> SupportEmployees { get; set; }
        public virtual DbSet<Orgnization> Orgnizations { get; set; }
    }
}
