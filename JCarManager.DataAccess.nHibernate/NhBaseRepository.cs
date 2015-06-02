using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess;
using JCarManager.DataAccess.Common;
using JCarManager.Entity.Entities.Cars;
using NHibernate;
using NHibernate.Linq;

namespace JCarManager.DataAccess.nHibernate
{
    public class NhBaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ISession _session;

        public NhBaseRepository(ISession session)
        {
            _session = session;
            _session.FlushMode = FlushMode.Commit;
        }

        public bool Add(T entity)
        {
            _session.Save(entity);
           // _session.Flush();
            return true;
        }

        public bool Update(T entity)
        {
            //_session.CreateSQLQuery("").AddEntity(typeof (Car)).List();


            _session.SaveOrUpdate(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            _session.Delete(entity);

            

            return true;
        }

        public IQueryable<T> GetQueryable()
        {
            return _session.Query<T>();
        }

        internal ISession Session
        {
            get
            {
                return _session;
            }
        }
    }
}
