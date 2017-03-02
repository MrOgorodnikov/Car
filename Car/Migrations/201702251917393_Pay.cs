namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Sum", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Payments", "PayedPrice");
            DropColumn("dbo.Payments", "PayedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "PayedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "PayedPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Payments", "DateTime");
            DropColumn("dbo.Payments", "Sum");
        }
    }
}
