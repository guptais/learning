
using System;
using System.Collections.Generic;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class Customer : User
    {
        public string BillingCycle { get; set; }
        public string BillAmount { get; set; }
        public DigitalSignature DigitalSignature { get; set; }
        public DocumentRepository ProofDocument { get; set; }
        public LifeInsurancePolicy Policy { get; set; }
        public BillingDetail BillingInfo { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Claim> Claims { get; set; }
    }

}