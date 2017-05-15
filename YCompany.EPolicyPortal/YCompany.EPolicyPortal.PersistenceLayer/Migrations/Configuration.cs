using System.Collections.Generic;
using YCompany.EPolicyPortal.PersistenceLayer.Entities;

namespace YCompany.EPolicyPortal.PersistenceLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.EPolicyPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.EPolicyPortalContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var courses = new List<Product>
            {
                new Product {ProductName = "Insurance Product 1", SumAssured = 1000000, TimePeriod = 10},
                new Product {ProductName = "Insurance Product 2", SumAssured = 5000000, TimePeriod = 20},
                new Product {ProductName = "Insurance Product 3", SumAssured = 100000, TimePeriod = 5},
            };
            courses.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
