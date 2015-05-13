namespace JCarManager.DataAccess.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Car_AddTestColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "Test2", c => c.String());

            Sql("UPDATE dbo.Car SET TEst2 = 'funky test';");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Test2");
        }
    }
}
