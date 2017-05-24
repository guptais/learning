using System;
using System.ComponentModel.DataAnnotations;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class LifeInsurancePolicy
    {
        //Primary Key
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PolicyEffectiveDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PolicyExpiryDate { get; set; }

        public string PolicyNumber { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public long SumAssured { get; set; }

        [DataType(DataType.Duration)]
        public int TimePeriod { get; set; }

        public bool Active { get; set; }
    }
}