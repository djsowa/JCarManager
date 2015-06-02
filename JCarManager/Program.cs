﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess;

namespace JCarManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDataGenerator.GenerateCustomerData();
            //TestDataGenerator.GenerateCarData();
            //TestDataGenerator.GenerateEquipmentData();



            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();


            using (var queryInterface = new QueryTesting(false))
            {
                var test1 = queryInterface.Test();
                test1.Include(x => x.Car);

                var result = test1.ToList();

                var test3 = queryInterface.Test3();
                var result3 = test3.Count();


                var test4res = queryInterface.Test3().GroupBy(x => x.FuelType).Select(x => new { Fuel = x.Key, CapaSum = x.Sum(y => y.Capacity) }).ToList();
            }

        }
    }
}
