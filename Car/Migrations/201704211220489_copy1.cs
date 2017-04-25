namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class copy1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntranceDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrances", "UserId", "dbo.Users");
            DropIndex("dbo.Entrances", new[] { "UserId" });
            DropTable("dbo.Entrances");
        }
    }
}
