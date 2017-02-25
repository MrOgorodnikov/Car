namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        HomeAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RFIDCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardId = c.String(),
                        UserId = c.Int(nullable: false),
                        Admin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .Index(t => t.UserId)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GarageNumber = c.Int(nullable: false),
                        CarNumber = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        HomeAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PayedPrice = c.Double(nullable: false),
                        Debt = c.Double(nullable: false),
                        PayedDateTime = c.DateTime(nullable: false),
                        PayUserId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.PayUserId, cascadeDelete: true)
                .Index(t => t.PayUserId)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RFIDCards", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Payments", "PayUserId", "dbo.Users");
            DropForeignKey("dbo.Payments", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.RFIDCards", "UserId", "dbo.Users");
            DropIndex("dbo.Payments", new[] { "AdminId" });
            DropIndex("dbo.Payments", new[] { "PayUserId" });
            DropIndex("dbo.RFIDCards", new[] { "Admin_Id" });
            DropIndex("dbo.RFIDCards", new[] { "UserId" });
            DropTable("dbo.Payments");
            DropTable("dbo.Users");
            DropTable("dbo.RFIDCards");
            DropTable("dbo.Admins");
        }
    }
}
