using System;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
    public abstract class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AddedDate { get; set; }
        public UserProfile PersonDetails { get; set; }
    }

    public class UserProfile
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Address CorrespondenceAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public int ContactNummber { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; }
    }

    public enum MaritalStatus
    {
        Single,
        Married,
        Divorced,
        Widow
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