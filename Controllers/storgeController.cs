using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static sellsTask.Service.dataServiceItems;
using static sellsTask.Service.dataServiceStorge;

namespace sellsTask.Controllers
{
    public class storgeController : Controller
    {

        static Repository<storge> storgeRepo = new Repository<storge>();
        storgeService cos = new storgeService(storgeRepo);

        static Repository<items> itemRepo = new Repository<items>();
        ItemsService itemObj = new ItemsService(itemRepo);
        // GET: storge
        public ActionResult Index()
        {
         
            IList<storge> storheList = cos.GetAll();
            
        
            
            return View(storheList);
        }

        // GET: storge/Details/5
        public ActionResult Details(int id)
        {
            storge mystore = cos.GetById(id);
            ViewBag.itemD = itemObj.GetById(mystore.itemID);         
            return View(mystore);
        }

        // GET: storge/Create
        public ActionResult Create(int id)
        {
            storge item = new storge();
            item.itemID = id;

            System.Diagnostics.Debug.WriteLine(item.itemID);

            return View(item);
        }

        // POST: storge/Create
        [HttpPost]
        public ActionResult Create(storge item)
        {

            try {
                // TODO: Add insert logic here
                System.Diagnostics.Debug.WriteLine(item.itemID);
                System.Diagnostics.Debug.WriteLine(item.Quantity);
                System.Diagnostics.Debug.WriteLine(item.storeName);
                cos.Create(item);


                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);

                return View();
            }
        }

        // GET: storge/Edit/5
        public ActionResult editStorge(int id)
        {
          //  storge ss = new storge();
            return View();
        }

        // POST: storge/Edit/5
        [HttpPost]
        public ActionResult editStorge(int id, storge storgeItem)
        {
            try
            {
                // TODO: Add update logic here
                storge item = cos.GetById(id);
                //item.itemID = storgeItem.itemID;
                item.Quantity = storgeItem.Quantity;
                item.storeName = storgeItem.storeName;

                System.Diagnostics.Debug.WriteLine(item.itemID);
           
              cos.Update(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: storge/Delete/5
        public ActionResult Delete(int id)
        {
            cos.Delete(cos.GetById(id));
            return RedirectToAction("Index");
        }

    
        }
    }

