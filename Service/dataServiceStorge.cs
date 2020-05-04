using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceStorge
    {
        public interface istorgeService
        {
            IList<storge> GetAll();
            storge GetById(int id);
            void Create(storge item);
            void Update(storge item);
            void Delete(storge item);
        }

        public class storgeService : istorgeService
        {
            private Repository<storge> _storgeRepository;

            public storgeService(Repository<storge> itemStorgeRepository)
            {
                _storgeRepository = itemStorgeRepository;
            }

            public IList<storge> GetAll()
            {
                return _storgeRepository
                    .GetList();
                   
            }

            public storge GetById(int id)
            {
                return _storgeRepository.GetById(id);
            }

            public void Create(storge item)
            {
                _storgeRepository.Add(item);
            }

            public void Update(storge item)
            {
                _storgeRepository.Update(item);
            }

            public void Delete(storge item)
            {
                _storgeRepository.Delete(item);
            }

            
          

           /*  public int  stored(int vItemId, string vStoreName, Int64 vQuantity)

             {


                 try
                 {
                     var result = _storgeRepository.getMySession()
                             .CreateSQLQuery("CALL insertStorge(:vQuantity, :vStoreName, :vItemId)").AddEntity
                                 (typeof(costumer)).
                                 SetParameter("vItemId", vItemId).
                                 SetParameter("vStoreName", vStoreName).
                                 SetParameter("vQuantity", vQuantity)
                               .ExecuteUpdate();
                                 //.List<costumer>();

                     System.Diagnostics.Debug.WriteLine("resulit Count its : " + result);
                     return result;
                 }
                 catch (Exception e)
                 {
                     System.Diagnostics.Debug.WriteLine("resulit Count its : " + e.Message);
                     return 0;
                 }

             }
    */



        }
    }
}