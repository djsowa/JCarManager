namespace JCarManager.DataAccess.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Test2 = c.String(),
                        Test3 = c.String(),
                        RegistrationNumber = c.String(),
                        VehicleNumber = c.String(),
                        Description = c.String(),
                        BodyType = c.Int(nullable: false),
                        CarStatus = c.Int(nullable: false),
                        GroupTypeEnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarEquipment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        WheelSize = c.Int(nullable: false),
                        AirbagsCount = c.Int(nullable: false),
                        HasBlackWindows = c.Boolean(nullable: false),
                        HasAlloyWheels = c.Boolean(nullable: false),
                        HasLeatherUpholstery = c.Boolean(nullable: false),
                        HasAutomaticAirConditioning = c.Boolean(nullable: false),
                        HasManualAirConditioning = c.Boolean(nullable: false),
                        HasBuildinNavigation = c.Boolean(nullable: false),
                        HasExternalNavigation = c.Boolean(nullable: false),
                        HasCruiseControl = c.Boolean(nullable: false),
                        HasTractionControl = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Car", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.EngineDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EngineNumber = c.String(),
                        FuelType = c.Int(nullable: false),
                        Capacity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeclaredAverageFuelConsumptionMixed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeclaredAverageFuelConsumptionUrban = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeclaredAverageFuelConsumptionHighway = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeclaredCO2Creation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EcologyClass = c.Int(nullable: false),
                        HorsePower = c.Int(nullable: false),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Car", t => t.Car_Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        CompanyName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        LastChange = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Customer_Id = c.Int(),
                        RentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .ForeignKey("dbo.RentType", t => t.RentType_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.RentType_Id);
            
            CreateTable(
                "dbo.RentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                        IsPernamentRent = c.Boolean(nullable: false),
                        IsOneTimeRent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent", "RentType_Id", "dbo.RentType");
            DropForeignKey("dbo.Rent", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.EngineDetails", "Car_Id", "dbo.Car");
            DropForeignKey("dbo.CarEquipment", "CarId", "dbo.Car");
            DropIndex("dbo.Rent", new[] { "RentType_Id" });
            DropIndex("dbo.Rent", new[] { "Customer_Id" });
            DropIndex("dbo.EngineDetails", new[] { "Car_Id" });
            DropIndex("dbo.CarEquipment", new[] { "CarId" });
            DropTable("dbo.RentType");
            DropTable("dbo.Rent");
            DropTable("dbo.Customer");
            DropTable("dbo.EngineDetails");
            DropTable("dbo.CarEquipment");
            DropTable("dbo.Car");
        }
    }
}
