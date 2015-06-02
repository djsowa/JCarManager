using System;
using System.Globalization;
using System.Linq;
using JCarManager.Entity.Entities.Cars;
using JCarManager.Entity.Entities.Customers;

namespace JCarManager.DataAccess
{
    public class TestDataGenerator
    {
        public static void GenerateCustomerData()
        {
            using (var unit = UnitOfWorkFactory.CreateUnitOfWork(true))
            {
                unit.BeginTransaction();

                var customerRepository = unit.GetRepository<Customer>();

                for (int i = 0; i < 5000; i++)
                {
                    var customer = new Customer()
                    {
                        Address = string.Format("Funky street {0}", i),
                        City = "Warsaw",
                        CompanyName = string.Format("Funky Company {0} S.A.", i),
                        Country = "Poland",
                        Firstname = string.Format("Jan {0}", i),
                        Lastname = "Sobieski",
                        ZipCode = "01-500"
                    };
                    customerRepository.Add(customer);
                }

                unit.Commit();
            }
        }


        public static void GenerateCarData()
        {
            using (var unit = UnitOfWorkFactory.CreateUnitOfWork(true))
            {
                unit.BeginTransaction();

                var carRepository = unit.GetRepository<Car>();
                var engineRepository = unit.GetRepository<EngineDetails>();

                for (int i = 0; i < 5000; i++)
                {
                    var randomGenerator = new Random(i);

                    var car = new Car()
                    {
                        BodyType = (BodyTypeEnum)Enum.Parse(typeof(BodyTypeEnum), randomGenerator.Next(1, 5).ToString(CultureInfo.InvariantCulture)),
                        CarStatus = (CarStatusEnum)Enum.Parse(typeof(CarStatusEnum), randomGenerator.Next(1, 3).ToString(CultureInfo.InvariantCulture)),
                        RegistrationNumber = string.Format("SK {0}", i.ToString(CultureInfo.InvariantCulture).PadLeft(5, '0')),
                        VehicleNumber = string.Format("{0}", Guid.NewGuid().ToString("N")),
                        Description = "Opel is a great car !!!",
                        GroupTypeEnum = (CarGroupTypeEnum)Enum.Parse(typeof(CarGroupTypeEnum), randomGenerator.Next(1, 5).ToString(CultureInfo.InvariantCulture))
                    };

                    var engine = new EngineDetails()
                    {
                        Capacity = randomGenerator.Next(1, 3),
                        Car = car,
                        DeclaredAverageFuelConsumptionHighway = randomGenerator.Next(3, 15),
                        DeclaredAverageFuelConsumptionMixed = randomGenerator.Next(6, 20),
                        DeclaredAverageFuelConsumptionUrban = randomGenerator.Next(8, 25),
                        DeclaredCO2Creation = randomGenerator.Next(110, 200),
                        EcologyClass = EngineEcologyClassEnum.EURO3,
                        EngineNumber = string.Format("DD{0}", i.ToString(CultureInfo.InvariantCulture).PadLeft(5, '0')),
                        FuelType = FuelTypeEnum.Gasoline,
                        HorsePower = randomGenerator.Next(75, 250),

                    };

                    carRepository.Add(car);

                    engineRepository.Add(engine);

                    car.EngineDetails.Add(engine);
                   
                }

                unit.Commit();
            }
        }


        public static void GenerateEquipmentData()
        {
            using (var unit = UnitOfWorkFactory.CreateUnitOfWork(true))
            {
                unit.BeginTransaction();

                var carRepo = unit.GetRepository<Car>();
                var carEquipmentRepo = unit.GetRepository<CarEquipment>();

                foreach (var car in carRepo.GetQueryable().Where(x => true))
                {
                    var randomGenerator = new Random(car.Id);

                    var carEquipment = new CarEquipment()
                    {
                        Car = car,
                        AirbagsCount = randomGenerator.Next(2, 8),
                        HasAlloyWheels = car.Id % 2 != 0,
                        HasAutomaticAirConditioning = car.Id % 2 == 0,
                        HasBlackWindows = car.Id % 2 == 0,
                        HasBuildinNavigation = car.Id % 2 != 0,
                        HasLeatherUpholstery = car.Id % 2 != 0,
                        HasCruiseControl = car.Id % 2 == 0,
                        HasExternalNavigation = car.Id % 2 == 0,
                        HasManualAirConditioning = car.Id % 2 == 0,
                        HasTractionControl = car.Id % 2 == 0,

                        WheelSize = randomGenerator.Next(15, 19)
                    };

                    carEquipmentRepo.Add(carEquipment);

                    carRepo.Update(car);
                }

                unit.Commit();
            }
        }
    }
}
