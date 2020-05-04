using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static sellsTask.Service.dataServiceCostomer;
using static sellsTask.Service.dataServiceItems;
using static sellsTask.Service.dataServiceOrderlist;
using static sellsTask.Service.dataServiceStorge;
using static sellsTask.Service.serviceOrderSaveL;

namespace sellsTask.Controllers
{
    public class orderListController : Controller
    {
        static Repository<storge> storgeRepo = new Repository<storge>();
        storgeService storgeServeces = new storgeService(storgeRepo);
        static Repository<costumer> costomerRepo = new Repository<costumer>();
        costomerService cosServeces = new costomerService(costomerRepo);
        static Repository<items> itemRepo = new Repository<items>();
        ItemsService itemServeces = new ItemsService(itemRepo);

        static Repository<saveOrderL> orderRepo = new Repository<saveOrderL>();
        OrderSaveLService orderService = new OrderSaveLService(orderRepo);



        // GET: orderList

        public ActionResult approveOrdersList()
        {

            IList<storge> storheList = storgeServeces.GetAll();
            IList<costumer> cosList = cosServeces.GetAll();

            generalModels gm = new generalModels();
            gm.allStorge = storheList;
            gm.allCostomer = cosList;

            return View(gm);




        }

      
        [HttpPost]
        public JsonResult cosPartial(string Prefix)
        {
            IList<costumer> cosList = cosServeces.GetAll();
           
            var costomerList = (from N in cosList
                            where N.name.StartsWith(Prefix)
                            select new
                            {
                                label = N.name,
                                id = N.costumerID,
                                numb = N.phoneNumber
                            });
            return Json(costomerList);
        
        }


        [HttpPost]
        public JsonResult itmPartial(string Prefix)
        {
            IList<items> itemsList = itemServeces.GetAll();
            IList<storge> storgeList = storgeServeces.GetAll();

            var itemList = (from N in itemsList              
                           join storge in storgeList on N.itemID equals storge.itemID
                           where N.itemName.StartsWith(Prefix)
                            select new
                            {
                                itemName = N.itemName,
                                itemQuantity = storge.Quantity,
                                storeName = storge.storeName,
                                itemId = N.itemID,
                                storgeId = storge.storgeID
                                
                            });
            return Json(itemList);
        }

     
        

        [HttpPost]
        public JsonResult saveOrder(List<saveOrderL> Job)
        {
            if(Job == null)
            {
                return Json("enter value");
            } 
            try
            {
                DateTime mytime = DateTime.Now;
                foreach (var item in Job)
                {
                    item.orderdate = mytime;
                    orderService.stored(item);
                  
                }
                return Json(Job);
            }
            catch ( Exception e)
            {
                return Json(e.Message);
            }
           
          
           
        }

        public JsonResult checkQuntity(int id)
        {
            System.Diagnostics.Debug.WriteLine("JSON " + id);
            storge itemQ = storgeServeces.GetById(id);
            
            return Json(itemQ.Quantity.ToString(),JsonRequestBehavior.AllowGet);
        }


    /*   
        [HttpPost]
        public JsonResult Create(string Prefix, string numbers, string itemname,
            string quntity,string storgeName)
        {
            System.Diagnostics.Debug.WriteLine("hellllo from button " + Prefix, numbers);

            var map = new Dictionary<string, string>();
            map["costomerName"] = Prefix;
            map["itemName"] = itemname;
            map["itemQuntity"] = quntity;
            map["storgeName"] = storgeName;
            List<Dictionary<string,string>> mylist = new List<Dictionary<string, string>>();
            mylist.Add(map);
            ViewBag.Emp_data = mylist;

            var List = mylist.Select(x => new
            {
                name = "vvv",

            }).ToList();
           
            ViewBag.Emp_data = mylist;

            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(mylist);

            System.Diagnostics.Debug.WriteLine("json from button " + jsonString);

            Console.WriteLine(jsonString);

            return Json(jsonString);

        }

        **/
    }
}