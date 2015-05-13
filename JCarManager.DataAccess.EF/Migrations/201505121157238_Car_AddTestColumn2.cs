namespace JCarManager.DataAccess.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Car_AddTestColumn2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Car SET TEst2 = 'funky test';");
        }
        
        public override void Down()
        {
            Sql("UPDATE dbo.Car SET TEst2 = NULL;");
        }
    }
}
