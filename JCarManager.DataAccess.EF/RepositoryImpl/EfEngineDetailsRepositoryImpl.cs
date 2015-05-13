using System.Linq;
using JCarManager.Entity.Entities.Cars;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfEngineDetailsRepositoryImpl : EfBaseRepository<EngineDetails>
    {
        public EfEngineDetailsRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<EngineDetails> GetQueryable()
        {
            return _context.EngineDetails.AsQueryable();
        }
    }
}