namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.WebStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.WebStoreDbContext context)
        {
            //context.People.Add(new Models.Person() { CreatedAt = DateTime.Now, Email = "dasd@da.bg", FirstName = "test", LastName = "dasdas", IsDeleted = false, Password = "dasdas" });
        }
    }
}
