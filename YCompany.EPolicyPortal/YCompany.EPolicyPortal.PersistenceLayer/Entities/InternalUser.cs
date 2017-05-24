using System.Collections.Generic;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class InternalUser : User
    {
        
    }

    public class AgentUser : User
    {
        public ICollection<Customer> Customers { get; set; } 
    }
    
    public class DigitalSignature
    {
        public int ID { get; set; }
        public string signature { get; set; }
    }

    public class DocumentRepository
    {
        public int ID { get; set; }
        public string RepositoryLink { get; set; }
    }

}