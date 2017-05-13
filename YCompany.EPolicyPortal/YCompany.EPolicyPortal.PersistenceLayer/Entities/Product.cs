namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long SumAssured { get; set; }
        public int TimePeriod { get; set; }
    }
}