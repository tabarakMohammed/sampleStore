using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class serviceOrderSaveL
    {
        public interface iOrderSaveL
        {
            IList<saveOrderL> GetAll();
            saveOrderL GetById(int id);
            void Create(saveOrderL item);
            void Update(saveOrderL item);
            void Delete(saveOrderL item);
        }
        public class OrderSaveLService : iOrderSaveL
        {

            private Repository<saveOrderL> _orderRepository;

            public OrderSaveLService(Repository<saveOrderL> pOrderRepository)
            {
                _orderRepository = pOrderRepository;
            }




            public void Create(saveOrderL item)
            {
                throw new NotImplementedException();
            }

            public void Delete(saveOrderL item)
            {
                throw new NotImplementedException();
            }

            public IList<saveOrderL> GetAll()
            {
                throw new NotImplementedException();
            }

            public saveOrderL GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void Update(saveOrderL item)
            {
                throw new NotImplementedException();
            }


            public int stored(saveOrderL obj)

            {
                

                try
                {
                    var result = _orderRepository.getMySession()
                            .CreateSQLQuery
                            ("CALL InsertOrderList(:pcostomerID, :pitemID, :pQuantity, :porderDate, :pstorgeID)")
                            .AddEntity(typeof(saveOrderL)).
                                SetInt32("pcostomerID", obj.costId).
                                SetInt32("pitemID", obj.itemId).
                                SetInt32("pQuantity", obj.quntity).
                                SetDateTime("porderDate", obj.orderdate).
                                SetInt32("pstorgeID", obj.storgeId)
                                
                       //  .List<saveOrderL>();
                        .ExecuteUpdate();
                    
                    System.Diagnostics.Debug.WriteLine("resulit Count its : " + result.ToString());
                    return result;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("error message : " + e.Message);
                    return 0;
                }

            }








        }
    }
}