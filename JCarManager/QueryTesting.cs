using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess;
using JCarManager.Entity.Entities.Cars;

namespace JCarManager
{
    internal class QueryTesting
    {
        public static void Start()
        {
            Test(false);
            Test(true);
        }

        private static void Test(bool useNH = false)
        {
            //LINK TO RELATED ENTITY
            using (var nhUnit = UnitOfWorkFactory.CreateUnitOfWork(useNH))
            {
                var carEquipmentRepo = nhUnit.GetRepository<CarEquipment>();

                foreach (var carEquipment in carEquipmentRepo.GetQueryable().Take(20).Include(x => x.Car).ToList())
                {
                    var carId = carEquipment.CarId;
                    carId = carEquipment.Car.Id;
                }
            }
        }

    }
}
