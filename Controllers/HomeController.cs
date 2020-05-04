using NHibernate;
using sellsTask.Entities;
using sellsTask.Repository;
using sellsTask.SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static sellsTask.Service.dataServiceCostomer;

namespace sellsTask.Controllers
{
    public class HomeController : Controller
    {
       static Repository<costumer> repo = new Repository<costumer>();
        costomerService cos = new costomerService(repo);
        public ActionResult Index()
        {
         

            try
            {

              IList<costumer> costomeres = cos.GetAll();

                return View(costomeres);

                }
                catch
                {

                    return View();

                }

        }
        public ActionResult Create()

        {

            return View();

        }

        // POST: Employee/Create

        [HttpPost]

        public ActionResult Create(costumer costomer)

        {

            try

            {
                cos.Create(costomer);

                return RedirectToAction("Index");

            }

            catch (Exception exception)

            {

                return View(exception.Message);

            }

        }


        public ActionResult Edit()

        {

            return View();

        }



        [HttpPost]
        public ActionResult Edit(int id, costumer costs)

        {

            try

            {
                costumer costomer = cos.GetById(id);
                costomer.name = costs.name;
                costomer.phoneNumber = costs.phoneNumber;
                cos.Update(costomer);
                return RedirectToAction("Index");

            }

            catch (Exception exception)

            {

                return View(exception.Message);

            }

        }
        [HttpGet]
     public ActionResult Details(int id)
        {
            
            return View(cos.GetById(id));
        }

        public ActionResult Delete(int id) {
            
            cos.Delete(cos.GetById(id));
            return RedirectToAction("Index");
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}