using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YZH.Dal;

namespace YZH.entity.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserS> list = Userdal.sel().ToList();
            return View(list);
        }

        public ActionResult insert()
        {
            return View();
        }
        
        public ActionResult insmodel(UserS use)
        {
            if (Userdal.ins(use) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("insert");
            }
        }

        public ActionResult select()
        {
            
            ViewBag.name = Userdal.sele().Select(role => new SelectListItem() { Text = role.UserMBWT, Value = role.UserID.ToString() }).ToList();
            return View();
        }

    }
}