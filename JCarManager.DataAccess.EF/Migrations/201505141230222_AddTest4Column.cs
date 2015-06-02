namespace JCarManager.DataAccess.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTest4Column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "Test4", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Test4");
        }
    }
}
