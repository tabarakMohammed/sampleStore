using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceOrderlistprimery
    {
        public interface iOrderlistprimery
        {
            IList<orderlistprimery> GetAll();
            orderlistprimery GetById(int id);
            void Create(orderlistprimery item);
            void Update(orderlistprimery item);
            void Delete(orderlistprimery item);
        }

        public class orderlistprimeryService : iOrderlistprimery
        {
            private Repository<orderlistprimery> _orderlistprimeryRepository;

            public orderlistprimeryService(Repository<orderlistprimery> pOrderlistprimeryRepository)
            {
                _orderlistprimeryRepository = pOrderlistprimeryRepository;
            }

      
            IList<orderlistprimery> iOrderlistprimery.GetAll()
            {
                return _orderlistprimeryRepository.GetList();
            }

            orderlistprimery iOrderlistprimery.GetById(int id)
            {
                return _orderlistprimeryRepository.GetById(id);
            }

            void iOrderlistprimery.Create(orderlistprimery item)
            {
                 _orderlistprimeryRepository.Add(item);
            }

            void iOrderlistprimery.Update(orderlistprimery item)
            {
                _orderlistprimeryRepository.Update(item);
            }

            void iOrderlistprimery.Delete(orderlistprimery item)
            {
                _orderlistprimeryRepository.Delete(item);
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