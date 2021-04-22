namespace Code_First_manual_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryTbl",
                c => new
                    {
                        CategorySl = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.CategorySl);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.CategoryTbl", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.CategoryTbl");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.CategoryTbl");
        }
    }
}
