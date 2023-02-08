using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
   public class FoodDbConextCodeFirst: DbContext
    {
        public FoodDbConextCodeFirst():base("name=FoodDbConextCodeFirst")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Orgnization> Orgnizations { get; set; }
        public virtual DbSet<SupportEmployees> SupportEmployees { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
    }
}
