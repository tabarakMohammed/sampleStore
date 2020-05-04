using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceOrderlist
    {
        public interface iOrderlist
        {
            IList<orderlist> GetAll();
            orderlist GetById(int id);
            void Create(orderlist item);
            void Update(orderlist item);
            void Delete(orderlist item);
        }

        public class orderlistService : iOrderlist
        {
            private Repository<orderlist> _orderlistRepository;

            public orderlistService(Repository<orderlist> pOrderlistRepository)
            {
                _orderlistRepository = pOrderlistRepository;
            }

          
            IList<orderlist> iOrderlist.GetAll()
            {
                return _orderlistRepository.GetList();
            }

            orderlist iOrderlist.GetById(int id)
            {
                return _orderlistRepository.GetById(id);
            }

            public void Create(orderlist item)
            {
                 _orderlistRepository.Add(item);
            }

            public void Update(orderlist item)
            {
                _orderlistRepository.Update(item);
            }

            public void Delete(orderlist item)
            {
                _orderlistRepository.Delete(item);
            }




             public int  stored(int vCostomerID, int vItemId, int vQuantity, DateTime vPorderDate, int vStorgeID)

              {


                  try
                  {
                      var result = _orderlistRepository.getMySession()
                              .CreateSQLQuery("CALL InsertOrderList(:pcostomerID, :pitemID, :pQuantity, :porderDate, :pstorgeID)").AddEntity
                                  (typeof(saveOrderL)).
                                  SetParameter("pcostomerID", vCostomerID).
                                  SetParameter("pitemID", vItemId).
                                  SetParameter("pQuantity", vQuantity).
                                  SetParameter("porderDate", vPorderDate).
                                  SetParameter("pstorgeID", vStorgeID)
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
     



        }
    }
}