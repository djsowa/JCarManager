using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using JCarManager.Entity.Entities.Cars;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;

namespace JCarManager.DataAccess.nHibernate
{
    internal class NhProvider
    {
        private static readonly ISessionFactory _sessionFactory;
        private static readonly Configuration _configuration;
        private const string _connectionString = "Data Source=.;Initial Catalog=jcar_NH;Integrated Security = true;";

        static NhProvider()
        {
            _configuration = CreateConfiguration();
            _sessionFactory = _configuration.BuildSessionFactory();

            ExportSchema();
        }

        private static Configuration CreateConfiguration()
        {
            var configuration = Fluently.Configure()
                                        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(_connectionString)
                                                  .DefaultSchema("dbo")
                                                  .IsolationLevel(IsolationLevel.Serializable)
                                                  .AdoNetBatchSize(50)
                                                  .QuerySubstitutions("true 1, false 0")
                                                  //.UseReflectionOptimizer()
                                         )//.ShowSql())
                                        .Mappings(map => map.AutoMappings.Add(AutoMap.AssemblyOf<Car>()))
                                        .BuildConfiguration();

            return configuration;
        }

        private static void ExportSchema()
        {
            var export = new SchemaExport(_configuration);
            export.Execute(true, true, false);
        }

        internal static ISession CreateSession()
        {
            return _sessionFactory.OpenSession();
        }

    }
}
