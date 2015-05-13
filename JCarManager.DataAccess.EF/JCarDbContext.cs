using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.Entity.Entities.Cars;
using JCarManager.Entity.Entities.Customers;
using JCarManager.Entity.Entities.Rents;


namespace JCarManager.DataAccess.EF
{
    public class JCarDbContext : DbContext
    {
        public JCarDbContext()
            : base("JCarDbEntityFM")
        {
            Database.SetInitializer<JCarDbContext>(new System.Data.Entity.DropCreateDatabaseIfModelChanges<JCarDbContext>());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarEquipment> CarsEquipment { get; set; }
        public DbSet<EngineDetails> EngineDetails { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<RentType> RentTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
