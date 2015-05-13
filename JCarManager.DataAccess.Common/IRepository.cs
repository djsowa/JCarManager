using System.Linq;

namespace JCarManager.DataAccess.Common
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        IQueryable<T> GetQueryable();
    }
}
