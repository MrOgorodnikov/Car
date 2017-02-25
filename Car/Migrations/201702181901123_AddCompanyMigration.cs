namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.RFIDCards", "Admin_Id", "dbo.Admins");
            DropIndex("dbo.RFIDCards", new[] { "Admin_Id" });
            DropIndex("dbo.Payments", new[] { "AdminId" });
            DropColumn("dbo.RFIDCards", "Admin_Id");
            DropColumn("dbo.Payments", "AdminId");
            DropTable("dbo.Admins");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.Payments", "AdminId", c => c.Int(nullable: false));
            AddColumn("dbo.RFIDCards", "Admin_Id", c => c.Int());
            CreateIndex("dbo.Payments", "AdminId");
            CreateIndex("dbo.RFIDCards", "Admin_Id");
            AddForeignKey("dbo.RFIDCards", "Admin_Id", "dbo.Admins", "Id");
            AddForeignKey("dbo.Payments", "AdminId", "dbo.Admins", "Id", cascadeDelete: true);
        }
    }
}
