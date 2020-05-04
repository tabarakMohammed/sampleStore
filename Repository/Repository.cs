using NHibernate;
using NHibernate.Criterion;
using sellsTask.Entities;
using sellsTask.SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Repository
{

        public class Repository<T> : IRepository<T> where T : class
    {

        ISession sessionGlobel = SessionFactoryBuilder.getConnection();

        public ISession getMySession() {
            return this.sessionGlobel;
        }
        public int Add(T entity)
        {
            using (ISession Session = SessionFactoryBuilder.getConnection())
            {
                using (ITransaction transaction = Session.BeginTransaction())
                {
                    try
                    {
                       int result = (int)Session.Save(entity);
                        transaction.Commit();
                        Session.Flush();
                         return result;
                    }
                    catch (Exception e)
                    {
                        if (transaction.WasCommitted)
                            transaction.Rollback();
                        throw new SystemException("insert error: " + e.Message);
                    }
                }
            }
        }

        public void Delete(T entity)
        {
            using (ISession Session = SessionFactoryBuilder.getConnection())
            {
                using (ITransaction transaction = Session.BeginTransaction())
                {
                    try
                    {
                        Session.Delete(entity);
                        transaction.Commit();
                        Session.Flush();
                      //  return Session;
                    }
                    catch (Exception e)
                    {
                        if (transaction.WasCommitted)
                            transaction.Rollback();
                        throw new SystemException("insert error: "+e.Message);
                    }
                }
            }
        }


        public void Update(T entity)
        {
            using (ISession Session = SessionFactoryBuilder.getConnection())
            {
                using (ITransaction transaction = Session.BeginTransaction())
                {
                    try
                    {
                        Session.Update(entity);
                        transaction.Commit();
                        Session.Flush();
                        //  return Session;
                    }
                    catch (Exception e)
                    {
                        if (transaction.WasCommitted)
                            transaction.Rollback();
                        throw new SystemException("insert error: " + e.Message);
                    }
                }
            }
        }

        public T GetById(int id)
        {
            using (ISession Session = SessionFactoryBuilder.getConnection())
            {
                return Session.Get<T>(id);
            }
        }

        /*
        public void storedpro()
        {

            using (ISession Session = SessionFactoryBuilder.getConnection())
            {

                var result = Session.CreateSQLQuery("CALL InsertCostumer(:fname, :phone)").AddEntity
                    (typeof(costumer)).
                    SetParameter("fname", "hello").
                    SetParameter("phone", 55555)
                    .List<costumer>();       

            }

        }

    */
        public IEnumerable<T> FindAll(DetachedCriteria criteria)
        {
           
            throw new NotImplementedException();
        }

        public IList<T> GetList()
        {
            using (ISession Session = SessionFactoryBuilder.getConnection())
            {
                return Session.Query<T>().ToList();
            }
        }
    }
}

