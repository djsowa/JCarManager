using System;
using System.Collections.Generic;
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



            //HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
            

            QueryTesting.Start();
            
        }
    }
}
