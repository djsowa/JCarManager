using System.Data;
using System.Data.Entity;
using JCarManager.DataAccess.Common;
using JCarManager.DataAccess.EF.RepositoryImpl;
using JCarManager.Entity.Entities.Cars;
using JCarManager.Entity.Entities.Customers;
using JCarManager.Entity.Entities.Rents;

namespace JCarManager.DataAccess.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private DbContextTransaction _transaction;
        private JCarDbContext _context;

        public EfUnitOfWork()
        {
            _context = new JCarDbContext();
            _context.Configuration.AutoDetectChangesEnabled = false;
        }


        public void BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = _context.Database.BeginTransaction();
            }
        }

        public void Commit()
        {
            if (_transaction != null)
            {
                _context.SaveChanges();
                _transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }

        public IDbConnection DbConnection
        {
            get { return _context.Database.Connection; }
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof (T);

            if (type == typeof(Car))
            {
                return (IRepository<T>) new EfCarsRepositoryImpl(_context);
            }

            if (type == typeof(CarEquipment))
            {
                return (IRepository<T>)new EfCarEquipmentRepositoryImpl(_context);
            }

            if (type == typeof(EngineDetails))
            {
                return (IRepository<T>)new EfEngineDetailsRepositoryImpl(_context);
            }

            if (type == typeof(Rent))
            {
                return (IRepository<T>)new EfRentRepositoryImpl(_context);
            }

            if (type == typeof(RentType))
            {
                return (IRepository<T>)new EfRenTypestRepositoryImpl(_context);
            }

            if (type == typeof(Customer))
            {
                return (IRepository<T>)new EfCustomerRepositoryImpl(_context);
            }

            return null;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
