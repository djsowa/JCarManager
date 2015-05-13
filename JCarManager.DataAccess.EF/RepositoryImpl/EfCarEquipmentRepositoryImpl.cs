using System.Linq;
using JCarManager.Entity.Entities.Cars;

namespace JCarManager.DataAccess.EF.RepositoryImpl
{
    public class EfCarEquipmentRepositoryImpl : EfBaseRepository<CarEquipment>
    {
        public EfCarEquipmentRepositoryImpl(JCarDbContext context)
            : base(context)
        {
        }

        public override IQueryable<CarEquipment> GetQueryable()
        {
            return _context.CarsEquipment.AsQueryable();
        }
    }
}