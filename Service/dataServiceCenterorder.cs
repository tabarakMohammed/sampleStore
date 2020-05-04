using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceCenterorder
    {
        public interface iCenterorderService
        {
            IList<centerorder> GetAll();
            centerorder GetById(int id);
            void Create(centerorder item);
            void Update(centerorder item);
            void Delete(centerorder item);
        }

        public class centerorderService : iCenterorderService
        {
            private Repository<centerorder> _centerorderRepository;

            public centerorderService(Repository<centerorder> PcenterorderRepository)
            {
                _centerorderRepository = PcenterorderRepository;
            }

          
            IList<centerorder> iCenterorderService.GetAll()
            {
                return _centerorderRepository
                    .GetList();
            }

            centerorder iCenterorderService.GetById(int id)
            {
                return _centerorderRepository.GetById(id);
            }

            public void Create(centerorder item)
            {
                _centerorderRepository.Add(item);
            }

            public void Update(centerorder item)
            {
                _centerorderRepository.Update(item);
            }

            public void Delete(centerorder item)
            {
                _centerorderRepository.Delete(item);
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