using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address CorrespondenceAddress { get; set; }
        public string Email { get; set; }
    }

    public enum Role
    {
        Admin,
        Agent,
        Underwriter,
        Auditor,
        Biller,
        Internal,
        PolicyHolder
    }

    public class User
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Person Detail { get; set; }
    }

    public class Address
    {
        public string Current { get; set; }
        public string Permanent { get; set; }
    }
    
    public enum Gender
    { 
        Male,
        Female
    }
    
    public class PolicyHolderPerson : Person
    {
        public string MedicalHistory { get; set; }
        public List<Nominee> Nominees { get; set; }
        public string BillingCycle { get; set; }
        public string BillAmount { get; set; }
        public Signature DigitalSignature { get; set; }
        public Policy Policy { get; set; }
    }

    public class Nominee : Person
    {
        public string RelationShipWithApplicant { get; set; }
    }

    //Temp Object
    public class Applicant
    {
        public PolicyHolderPerson PersonalDetail { get; set; }
    }

    //public class Agent
    //{
    //    public string LoginId { get; set; }
    //    public string Password { get; set; }
    //    public IList<Applicant> Customers { get; set; } 
    //}

    public class Policy
    {
        public long Id { get; set; }
        public ApplicationStatus Status { get; set; }
        public double Premium { get; set; }
        public DateTime Submitted { get; set; }
        public DateTime Issued { get; set; }
        public PolicyType Type { get; set; }
        public int NumberOfPeopleInsured { get; set; }
        public double SumAssured { get; set; }
        public DocumentRepository DocumentRepository { get; set; }
    }

    public enum PolicyType
    {
        Term,
        Type1
    }

    public enum ApplicationStatus
    {
        Pending,
        Isssued,
        Expired
    }

    public class DocumentRepository
    {
        public int RepoId { get; set; }
        public GZipStream Stream { get; set; }
    }

    public class Signature
    {
    }
}
