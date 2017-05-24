namespace YCompany.EPolicyPortal.DataModel
{
    public class PolicyHolderModel
    {
        public string MedicalHistory { get; set; }
        public string BillingCycle { get; set; }
        public string BillAmount { get; set; }
        public DigitalSignature DigitalSignature { get; set; }
        public InsurancePolicyModel PolicyModel { get; set; }
    }

    public class DigitalSignature
    {
    }
}