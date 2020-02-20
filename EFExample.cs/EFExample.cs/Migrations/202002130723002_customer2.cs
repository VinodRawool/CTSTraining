namespace EFExample.cs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Customers", "PId");
            AddForeignKey("dbo.Customers", "PId", "dbo.Products", "PId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "PId", "dbo.Products");
            DropIndex("dbo.Customers", new[] { "PId" });
        }
    }
}
