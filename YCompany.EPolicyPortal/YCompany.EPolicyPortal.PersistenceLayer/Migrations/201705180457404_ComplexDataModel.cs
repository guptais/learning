namespace YCompany.EPolicyPortal.PersistenceLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Line1 = c.String(),
                        Line2 = c.String(),
                        Line3 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AgentUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        PersonDetails_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfile", t => t.PersonDetails_ID)
                .Index(t => t.PersonDetails_ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BillingCycle = c.String(),
                        BillAmount = c.String(),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        BillingInfo_BillingDetailId = c.Int(),
                        DigitalSignature_ID = c.Int(),
                        PersonDetails_ID = c.Int(),
                        Policy_ID = c.Int(),
                        ProofDocument_ID = c.Int(),
                        AgentUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BillingDetail", t => t.BillingInfo_BillingDetailId)
                .ForeignKey("dbo.DigitalSignature", t => t.DigitalSignature_ID)
                .ForeignKey("dbo.UserProfile", t => t.PersonDetails_ID)
                .ForeignKey("dbo.LifeInsurancePolicy", t => t.Policy_ID)
                .ForeignKey("dbo.DocumentRepository", t => t.ProofDocument_ID)
                .ForeignKey("dbo.AgentUser", t => t.AgentUser_ID)
                .Index(t => t.BillingInfo_BillingDetailId)
                .Index(t => t.DigitalSignature_ID)
                .Index(t => t.PersonDetails_ID)
                .Index(t => t.Policy_ID)
                .Index(t => t.ProofDocument_ID)
                .Index(t => t.AgentUser_ID);
            
            CreateTable(
                "dbo.BillingDetail",
                c => new
                    {
                        BillingDetailId = c.Int(nullable: false, identity: true),
                        Owner = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.BillingDetailId);
            
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        Amount = c.Long(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.DigitalSignature",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        signature = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        PaidOnTime = c.Boolean(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        ContactNummber = c.Int(nullable: false),
                        MaritalStatus = c.Int(nullable: false),
                        Occupation = c.String(),
                        CorrespondenceAddress_ID = c.Int(),
                        PermanentAddress_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.CorrespondenceAddress_ID)
                .ForeignKey("dbo.Address", t => t.PermanentAddress_ID)
                .Index(t => t.CorrespondenceAddress_ID)
                .Index(t => t.PermanentAddress_ID);
            
            CreateTable(
                "dbo.LifeInsurancePolicy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PolicyEffectiveDate = c.DateTime(nullable: false),
                        PolicyExpiryDate = c.DateTime(nullable: false),
                        PolicyNumber = c.String(),
                        Name = c.String(maxLength: 100),
                        SumAssured = c.Long(nullable: false),
                        TimePeriod = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DocumentRepository",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RepositoryLink = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InternalUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        PersonDetails_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfile", t => t.PersonDetails_ID)
                .Index(t => t.PersonDetails_ID);
            
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        BillingDetailId = c.Int(nullable: false),
                        BankName = c.String(),
                        Swift = c.String(),
                    })
                .PrimaryKey(t => t.BillingDetailId)
                .ForeignKey("dbo.BillingDetail", t => t.BillingDetailId)
                .Index(t => t.BillingDetailId);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        BillingDetailId = c.Int(nullable: false),
                        CardType = c.Int(nullable: false),
                        ExpiryMonth = c.String(),
                        ExpiryYear = c.String(),
                    })
                .PrimaryKey(t => t.BillingDetailId)
                .ForeignKey("dbo.BillingDetail", t => t.BillingDetailId)
                .Index(t => t.BillingDetailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "BillingDetailId", "dbo.BillingDetail");
            DropForeignKey("dbo.BankAccounts", "BillingDetailId", "dbo.BillingDetail");
            DropForeignKey("dbo.InternalUser", "PersonDetails_ID", "dbo.UserProfile");
            DropForeignKey("dbo.AgentUser", "PersonDetails_ID", "dbo.UserProfile");
            DropForeignKey("dbo.Customer", "AgentUser_ID", "dbo.AgentUser");
            DropForeignKey("dbo.Customer", "ProofDocument_ID", "dbo.DocumentRepository");
            DropForeignKey("dbo.Customer", "Policy_ID", "dbo.LifeInsurancePolicy");
            DropForeignKey("dbo.Customer", "PersonDetails_ID", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfile", "PermanentAddress_ID", "dbo.Address");
            DropForeignKey("dbo.UserProfile", "CorrespondenceAddress_ID", "dbo.Address");
            DropForeignKey("dbo.Payments", "Customer_ID", "dbo.Customer");
            DropForeignKey("dbo.Customer", "DigitalSignature_ID", "dbo.DigitalSignature");
            DropForeignKey("dbo.Claims", "Customer_ID", "dbo.Customer");
            DropForeignKey("dbo.Customer", "BillingInfo_BillingDetailId", "dbo.BillingDetail");
            DropIndex("dbo.CreditCards", new[] { "BillingDetailId" });
            DropIndex("dbo.BankAccounts", new[] { "BillingDetailId" });
            DropIndex("dbo.InternalUser", new[] { "PersonDetails_ID" });
            DropIndex("dbo.UserProfile", new[] { "PermanentAddress_ID" });
            DropIndex("dbo.UserProfile", new[] { "CorrespondenceAddress_ID" });
            DropIndex("dbo.Payments", new[] { "Customer_ID" });
            DropIndex("dbo.Claims", new[] { "Customer_ID" });
            DropIndex("dbo.Customer", new[] { "AgentUser_ID" });
            DropIndex("dbo.Customer", new[] { "ProofDocument_ID" });
            DropIndex("dbo.Customer", new[] { "Policy_ID" });
            DropIndex("dbo.Customer", new[] { "PersonDetails_ID" });
            DropIndex("dbo.Customer", new[] { "DigitalSignature_ID" });
            DropIndex("dbo.Customer", new[] { "BillingInfo_BillingDetailId" });
            DropIndex("dbo.AgentUser", new[] { "PersonDetails_ID" });
            DropTable("dbo.CreditCards");
            DropTable("dbo.BankAccounts");
            DropTable("dbo.InternalUser");
            DropTable("dbo.DocumentRepository");
            DropTable("dbo.LifeInsurancePolicy");
            DropTable("dbo.UserProfile");
            DropTable("dbo.Payments");
            DropTable("dbo.DigitalSignature");
            DropTable("dbo.Claims");
            DropTable("dbo.BillingDetail");
            DropTable("dbo.Customer");
            DropTable("dbo.AgentUser");
            DropTable("dbo.Address");
        }
    }
}
