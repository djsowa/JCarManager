using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager;
using JCarManager.DataAccess;
using NHibernate.Linq;

namespace JCarManager_NH
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDataGenerator.GenerateCustomerData();
            //TestDataGenerator.GenerateCarData();
            //TestDataGenerator.GenerateEquipmentData();

            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();

            using (var queryInterface = new QueryTesting(true))
            {
                var test1 = queryInterface.Test();
                test1 = test1.Fetch(x => x.Car);

                var result = test1.ToList();


                var test3 = queryInterface.Test3();
                var result3 = test3.Count();

                var test4res = queryInterface.Test3().GroupBy(x => x.FuelType).Select(x => new { Fuel = x.Key, CapaSum = x.Sum(y => y.Capacity) }).ToList();


            }
        }
    }
}
