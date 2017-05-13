namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public enum UserType
    {
        Admin,
        Agent,
        Underwriter,
        Auditor,
        Biller
    }
    public class InternalUser
    {
        public UserType Type;
    }
}