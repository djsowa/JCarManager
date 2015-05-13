using System.Linq;
using JCarManager.Entity.Entities.Rents;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfRenTypestRepositoryImpl : EfBaseRepository<RentType>
    {
        public EfRenTypestRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<RentType> GetQueryable()
        {
            return _context.RentTypes.AsQueryable();
        }
    }
}