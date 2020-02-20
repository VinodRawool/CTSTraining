namespace EFramework2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        CName = c.String(),
                        CAdd = c.String(),
                    })
                .PrimaryKey(t => t.CId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        CId = c.Int(nullable: false),
                        PId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.PId, cascadeDelete: true)
                .Index(t => t.CId)
                .Index(t => t.PId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        PId = c.Int(nullable: false, identity: true),
                        PName = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "PId", "dbo.Products");
            DropForeignKey("dbo.Purchases", "CId", "dbo.Customers");
            DropIndex("dbo.Purchases", new[] { "PId" });
            DropIndex("dbo.Purchases", new[] { "CId" });
            DropTable("dbo.Products");
            DropTable("dbo.Purchases");
            DropTable("dbo.Customers");
        }
    }
}
