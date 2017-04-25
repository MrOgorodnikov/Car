namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrances", "UserId", "dbo.Users");
            DropIndex("dbo.Entrances", new[] { "UserId" });
            DropTable("dbo.Entrances");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Entrances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntranceDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Entrances", "UserId");
            AddForeignKey("dbo.Entrances", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
