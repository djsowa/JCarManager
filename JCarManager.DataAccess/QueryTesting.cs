using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess;
using JCarManager.DataAccess.Common;
using NHibernate.Linq;
using JCarManager.Entity.Entities.Cars;

namespace JCarManager
{
    public class QueryTesting : IDisposable
    {
        private IUnitOfWork _unitOfWork = null;

        public QueryTesting(bool useNh = false)
        {
            _unitOfWork = UnitOfWorkFactory.CreateUnitOfWork(useNh);
        }

        public IQueryable<CarEquipment> Test()
        {
            var carEquipmentRepo = _unitOfWork.GetRepository<CarEquipment>();

            return carEquipmentRepo.GetQueryable().Take(20);
        }

        public IQueryable<Car> Test2()
        {
            var repo = _unitOfWork.GetRepository<Car>();

            return repo.GetQueryable().Where(x => x.BodyType == BodyTypeEnum.Kombi).Skip(90).Take(50);
        }

        public IQueryable<EngineDetails> Test3()
        {
            var repo = _unitOfWork.GetRepository<EngineDetails>();

            return repo.GetQueryable().Where(x => x.DeclaredAverageFuelConsumptionHighway > 130 && x.DeclaredAverageFuelConsumptionHighway < 150);
        }

        public IQueryable<EngineDetails> Test4()
        {
            var repo = _unitOfWork.GetRepository<EngineDetails>();

            return
                repo.GetQueryable()
                    .Where(
                        x =>
                            x.DeclaredAverageFuelConsumptionHighway > 130 &&
                            x.DeclaredAverageFuelConsumptionHighway < 150);
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
        }
    }
}
