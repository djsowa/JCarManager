using System;
using System.Data;

namespace JCarManager.DataAccess.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        IDbConnection DbConnection { get; }

        IRepository<T> GetRepository<T>() where T : class;

    }
}