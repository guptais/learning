using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace YCompany.EPolicyPortal.PersistenceLayer
{
    public class EPolicyPortalContext : DbContext
    {
        public EPolicyPortalContext() : base("EPolicyPortalContext")
        {
            
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}