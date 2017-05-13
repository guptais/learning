using System;

namespace YCompany.EPolicyPortal.PersistenceLayer
{
    public enum Gender
    {
        Male, Female
    }

    public class Address
    {
        public string Current { get; set; }
        public string Permanent { get; set; }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address CorrespondenceAddress { get; set; }
        public string Email { get; set; }
    }
}