namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entrances : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntranceDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrances", "User_Id", "dbo.Users");
            DropIndex("dbo.Entrances", new[] { "User_Id" });
            DropTable("dbo.Entrances");
        }
    }
}
