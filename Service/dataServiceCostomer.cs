using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceCostomer
    {
        public interface IcostomerService
        {
            IList<costumer> GetAll();
            costumer GetById(int id);
            void Create(costumer costomer);
            void Update(costumer costomer);
            void Delete(costumer costomer);
        }

        public class costomerService : IcostomerService
        {
            private Repository<costumer> _costomerRepository;

            public costomerService(Repository<costumer> costomerRepository)
            {
                _costomerRepository = costomerRepository;
            }

            public IList<costumer> GetAll()
            {
                return _costomerRepository
                    .GetList();
                   
            }

            public costumer GetById(int id)
            {
                return _costomerRepository.GetById(id);
            }

            public void Create(costumer costomer)
            {
                _costomerRepository.Add(costomer);
            }

            public void Update(costumer costomer)
            {
                _costomerRepository.Update(costomer);
            }

            public void Delete(costumer costomer)
            {
                _costomerRepository.Delete(costomer);
            }


           /* public int  stored()

            {


                try
                {
                    var result = _costomerRepository.getMySession()
                            .CreateSQLQuery("CALL InsertCostumer(:fname, :phone)").AddEntity
                                (typeof(costumer)).
                                SetParameter("fname", "hdhd").
                                SetParameter("phone", 334444)
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