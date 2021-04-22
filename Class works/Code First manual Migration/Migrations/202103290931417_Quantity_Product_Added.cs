namespace Code_First_manual_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quantity_Product_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
