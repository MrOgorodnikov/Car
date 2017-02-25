namespace Car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDebtColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "Debt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "Debt", c => c.Double(nullable: false));
        }
    }
}
