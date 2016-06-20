using System.Data.Entity.Migrations;

namespace MyCompany.Portal.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Portal.EntityFramework.PortalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Portal";
        }

        protected override void Seed(Portal.EntityFramework.PortalDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

            context.People.AddOrUpdate(p => p.Name,
                new Person { Name = "Isaac Asimov" },
            new Person { Name = "Thomas More" },
            new Person { Name = "George Orwell" },
            new Person { Name = "Douglas Adams" });
        }
    }
}
