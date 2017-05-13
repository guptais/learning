using System;

namespace YCompany.EPolicyPortal.PersistenceLayer.Entities
{
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