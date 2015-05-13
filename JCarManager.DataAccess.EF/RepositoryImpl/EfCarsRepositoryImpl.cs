using System.Linq;
using JCarManager.Entity.Entities.Cars;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfCarsRepositoryImpl : EfBaseRepository<Car>
    {
        public EfCarsRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<Car> GetQueryable()
        {
            return _context.Cars.AsQueryable();
        }
    }
}