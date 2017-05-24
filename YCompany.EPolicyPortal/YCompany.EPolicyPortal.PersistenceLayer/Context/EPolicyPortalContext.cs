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

        public DbSet<LifeInsurancePolicy> Policies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InternalUser> InternalUsers { get; set; }
        public DbSet<AgentUser> AgentUsers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<DocumentRepository> DocumentRepositories { get; set; }
        public DbSet<DigitalSignature> DigitalSignatures { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}