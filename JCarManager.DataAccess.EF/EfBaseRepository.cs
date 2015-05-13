using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using JCarManager.DataAccess.Common;

namespace JCarManager.DataAccess.EF
{
    public abstract class EfBaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly JCarDbContext _context;

        protected EfBaseRepository(JCarDbContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            if (_context.Database.CurrentTransaction == null)
            {
                _context.SaveChanges(); 
            }
            return true;
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            if (_context.Database.CurrentTransaction == null)
            {
                _context.SaveChanges(); 
            }
            return true;
        }

        public bool Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            if (_context.Database.CurrentTransaction == null)
            {
                _context.SaveChanges(); 
            }
            return true;
        }

        public abstract IQueryable<T> GetQueryable();
    }
}
