using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using YCompany.EPolicyPortal.PersistenceLayer.Entities;

namespace YCompany.EPolicyPortal.PersistenceLayer.Context
{
    public class EPolicyPortalContext : DbContext
    {
        public EPolicyPortalContext() : base("EPolicyPortalContext")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<InternalUser> InternalUsers { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}