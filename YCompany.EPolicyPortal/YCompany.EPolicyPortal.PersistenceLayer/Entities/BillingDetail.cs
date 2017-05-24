using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public abstract class BillingDetail
    {
        public int BillingDetailId { get; set; }
        public string Owner { get; set; }
        public string Number { get; set; }
    }

    [Table("BankAccounts")]
    public class BankAccount : BillingDetail
    {
        public string BankName { get; set; }
        public string Swift { get; set; }
    }

    [Table("CreditCards")]
    public class CreditCard : BillingDetail
    {
        public int CardType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }

    [Table("Payments")]
    public class Payment
    {
        public int ID { get; set; }
        public int TransactionId { get; set; }
        public DateTime DueDate { get; set; }
        public bool PaidOnTime { get; set; }
    }

    [Table("Claims")]
    public class Claim
    {
        public int ID { get; set; }
        public int TransactionId { get; set; }
        public long Amount { get; set; }
        public bool Approved { get; set; }
    }
}
