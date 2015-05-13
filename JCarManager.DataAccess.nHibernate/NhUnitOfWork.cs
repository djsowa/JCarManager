using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess.Common;
using NHibernate;

namespace JCarManager.DataAccess.nHibernate
{
    public class NhUnitOfWork : IUnitOfWork
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public NhUnitOfWork()
        {
            _session = NhProvider.CreateSession();
            _session.FlushMode = FlushMode.Commit;
        }


        public void BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = _session.BeginTransaction(IsolationLevel.ReadCommitted);
            }
        }

        public void Commit()
        {
            if (_transaction != null && _transaction.IsActive && !_transaction.WasCommitted)
            {
                _transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (_transaction != null && _transaction.IsActive && !_transaction.WasRolledBack)
            {
                _transaction.Rollback();
            }
        }

        public IDbConnection DbConnection
        {
            get { return _session.Connection; }
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new NhBaseRepository<T>(_session);
        }

        public void Dispose()
        {
            _session.Dispose();
        }
    }
}
