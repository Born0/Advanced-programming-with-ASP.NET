namespace Code_First_manual_Migration.Migrations
{
    using Code_First_manual_Migration.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code_First_manual_Migration.Models.InventoryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Code_First_manual_Migration.Models.InventoryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<Category> list = new List<Category>()
            {
                new Category(){ CategoryName="cloth"},
                new Category() { CategoryName = "Electric" }
            };
            if(!context.Categories.Any())
            {
                foreach(var item in list)
                {
                    context.Categories.Add(item);
                    context.SaveChanges();
                }
            }

        }
    }
}
