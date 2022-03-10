namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminType_ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AdminTypes", t => t.AdminType_ID, cascadeDelete: true)
                .Index(t => t.AdminType_ID);
            
            CreateTable(
                "dbo.AdminTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "AdminType_ID", "dbo.AdminTypes");
            DropIndex("dbo.Admins", new[] { "AdminType_ID" });
            DropTable("dbo.AdminTypes");
            DropTable("dbo.Admins");
        }
    }
}
