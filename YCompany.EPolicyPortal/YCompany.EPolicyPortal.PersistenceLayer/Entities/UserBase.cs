using System;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public class UserBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string Email { get; set; }
        public int ContactNummber { get; set; }
        public UserType UserType { get; set; }
    }
    
    public enum UserType
    {
        Admin,
        Agent,
        Underwriter,
        Auditor,
        Biller,
        Customer
    }
}