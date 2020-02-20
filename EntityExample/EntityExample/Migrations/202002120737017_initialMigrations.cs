namespace EntityExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        EName = c.String(),
                        EDesignation = c.String(),
                        ESalary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
