using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HPIT.FL;
namespace Flower.Controllers
{
    public class DefaultsController : Controller
    {
        // GET: Defaults
        public ActionResult Index()
        {
            FlowerDAL1 dal = new FlowerDAL1();
            List<xinxi> xin = dal.Select();
            return View(xin);
        }

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Createadd(xinxi xx)
        {
            
            FlowerDAL1 ff = new FlowerDAL1();
            if (ff.add(xx) > 0)
            {
                return RedirectToAction("Index");
            }
            else {
                return RedirectToAction("Create");
            }
        }

        public ActionResult update(int id)
        {
            return View();
        }

    }
}