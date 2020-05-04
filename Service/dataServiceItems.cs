using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Service
{
    public class dataServiceItems
    {
        public interface itemsService
        {
            IList<items> GetAll();
            items GetById(int id);
            void Create(items item);
            void Update(items item);
            void Delete(items item);
        }

        public class ItemsService : itemsService
        {
            private Repository<items> _itemRepository;

            public ItemsService(Repository<items> itemRepository)
            {
                _itemRepository = itemRepository;
            }

            public IList<items> GetAll()
            {
                return _itemRepository
                    .GetList();
                   
            }

            public items GetById(int id)
            {
                return _itemRepository.GetById(id);
            }

            public void Create(items item)
            {
                _itemRepository.Add(item);
            }

            public void Update(items item)
            {
                _itemRepository.Update(item);
            }

            public void Delete(items item)
            {
                _itemRepository.Delete(item);
            }

            IList<items> itemsService.GetAll()
            {
                throw new NotImplementedException();
            }

          

            public int  stored(items it)

             {


                 try
                 {
                     var result = _itemRepository.getMySession()
                             .CreateSQLQuery("CALL insertItems(:vItemName, :vItemType)").AddEntity
                                 (typeof(items)).
                                 SetParameter("vItemName", it.itemName).
                                 SetParameter("vItemType", it.itemType)
                               //.ExecuteUpdate();
                                 .List<items>();

                     System.Diagnostics.Debug.WriteLine("resulit Count its : " + result);
                     return result.Count;
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