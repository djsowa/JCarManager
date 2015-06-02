using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.Entity.Entities.Cars;
using JCarManager.Entity.Entities.Rents;

namespace JCarManager.Business
{
    public interface IJCarManagerService
    {
        IList<Car> GetCarsInUse();

        IList<Car> GetAvailableCars();

        IList<Car> GetCarsByEquipment(CarEquipment carEquipment);

        IList<Car> GetCarsByEngine(EngineDetails engineDetails);

        IList<Car> GetCarsByPopularity(int top);

        decimal GetAverageMonthlyCo2Consumption();

        void RecalculateCarCoveredDistance(Car car);

        IList<Rent> GetRentsByType(RentType rentType);

    }


    public class ServicePager
    {
        public ServicePager()
        {

        }

        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
