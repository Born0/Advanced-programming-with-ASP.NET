
using PCHut_API.Migrations;
using System;
using System.Data.Entity;
using System.Linq;

namespace PCHut_API.Models
{
    public class PcHutDbContext : DbContext
    {
        // Your context has been configured to use a 'PcHutDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PCHut_API.Models.PcHutDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PcHutDbContext' 
        // connection string in the application configuration file.
        public PcHutDbContext(): base("name=PcHutDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PcHutDbContext, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Branch_Manager> Branch_Managers { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sales_Record> Sales_Records { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}