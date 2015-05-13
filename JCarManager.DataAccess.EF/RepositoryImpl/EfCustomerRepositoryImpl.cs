using System.Linq;
using JCarManager.Entity.Entities.Customers;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfCustomerRepositoryImpl : EfBaseRepository<Customer>
    {
        public EfCustomerRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<Customer> GetQueryable()
        {
            return _context.Customers.AsQueryable();
        }
    }
}