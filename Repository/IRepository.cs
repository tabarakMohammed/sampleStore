using NHibernate.Criterion;
using System.Collections.Generic;

namespace sellsTask.Repository
{
    public interface IRepository<T>
    {
        int Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IList<T> GetList();
        IEnumerable<T> FindAll(DetachedCriteria criteria);
   
    
    }

}