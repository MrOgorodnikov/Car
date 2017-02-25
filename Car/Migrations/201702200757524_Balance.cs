namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Balance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Balance", c => c.Double(nullable: false));
            AddColumn("dbo.Users", "InGarage", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "InGarage");
            DropColumn("dbo.Users", "Balance");
        }
    }
}
