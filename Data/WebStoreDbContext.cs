namespace Data
{
    using Data.Migrations;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WebStoreDbContext : DbContext
    {
      
        public WebStoreDbContext()
            : base("WebStore")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebStoreDbContext, Configuration>());
           
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesOrder> Sales { get; set; }
    }

}