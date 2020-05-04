using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.SolutionItems
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using System;


    public class SessionFactoryBuilder
    {

        public static ISession getConnection()
        {
            try
            {

                ISessionFactory sessionFactory = Fluently.Configure().
                   Database(MySQLConfiguration.Standard.ConnectionString(
            x => x.Server("localhost").
               Username("dataBaseUser").
               Password("yourPassword").
               Database("Schema")
            )).
                   Mappings(m => m.FluentMappings.AddFromAssemblyOf<sellsTask.Mappings.costomerMap>().
                   AddFromAssemblyOf<sellsTask.Mappings.itemsMap>().
                    AddFromAssemblyOf<sellsTask.Mappings.storgeMap>().
                    AddFromAssemblyOf<sellsTask.Mappings.centerorderMap>().
                     AddFromAssemblyOf<sellsTask.Mappings.orderlistMap>().
                    AddFromAssemblyOf<sellsTask.Mappings.orderlistprimeryMap>().
                    AddFromAssemblyOf<sellsTask.Mappings.saveOrderLmap>()
                    ).
                   //ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true)).
                   BuildSessionFactory();
                return sessionFactory.OpenSession();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                 throw;
                

            }
        }

       
    }
}
