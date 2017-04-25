namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEntrance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrances", "User_Id", "dbo.Users");
            DropIndex("dbo.Entrances", new[] { "User_Id" });
            RenameColumn(table: "dbo.Entrances", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Entrances", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Entrances", "UserId");
            AddForeignKey("dbo.Entrances", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrances", "UserId", "dbo.Users");
            DropIndex("dbo.Entrances", new[] { "UserId" });
            AlterColumn("dbo.Entrances", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Entrances", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Entrances", "User_Id");
            AddForeignKey("dbo.Entrances", "User_Id", "dbo.Users", "Id");
        }
    }
}
