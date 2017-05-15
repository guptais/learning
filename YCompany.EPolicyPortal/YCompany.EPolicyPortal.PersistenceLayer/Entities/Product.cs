using System.ComponentModel.DataAnnotations;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class Product
    {
        //Primary Key
        public int ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        public long SumAssured { get; set; }

        [DataType(DataType.Duration)]
        public int TimePeriod { get; set; }
    }
}