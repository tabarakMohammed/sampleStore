using sellsTask.Entities;
using sellsTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static sellsTask.Service.dataServiceItems;

namespace sellsTask.Views
{
   
    public class itemsController : Controller
    {
        // GET: items
        static Repository<items> itemsRepo = new Repository<items>();
        ItemsService cos = new ItemsService(itemsRepo);
        public ActionResult Index()
        {
            IList<items> itemss = cos.GetAll();

            return View(itemss);
        }

        // GET: items/Details/5
        public ActionResult Details(int id)
        {
            return View(cos.GetById(id));

        }

        // GET: items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: items/Create
        [HttpPost]
        public ActionResult Create(items itemss)
        {
            try
            {
                // TODO: Add insert logic here
                cos.Create(itemss);
               //cos.stored(itemss);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: items/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: items/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, items itemform)
        {
            try
            {
                // TODO: Add update logic here
                items item = cos.GetById(id);
                item.itemName = itemform.itemName;
                item.itemType = itemform.itemType;

                cos.Update(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: items/Delete/5
        public ActionResult Delete(int id)
        {
            cos.Delete(cos.GetById(id));
            return RedirectToAction("Index");
        }


        public ActionResult addToStorge( int id)
        {

            return RedirectToAction("../storgeController/storge/create",id);

        }



    }
}
