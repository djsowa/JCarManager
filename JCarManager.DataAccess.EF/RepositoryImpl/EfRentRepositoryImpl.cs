using System.Linq;
using JCarManager.Entity.Entities.Rents;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfRentRepositoryImpl : EfBaseRepository<Rent>
    {
        public EfRentRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<Rent> GetQueryable()
        {
            return _context.Rents.AsQueryable();
        }
    }
}