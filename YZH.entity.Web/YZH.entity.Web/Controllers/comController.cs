using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YZH.Dal;

namespace YZH.entity.Web.Controllers
{
    public class comController : Controller
    {
        // GET: com
        //查询
        public ActionResult Index()
        {
            List<CG_Commodity> list = Commdal.sel();
            return View(list);
        }
        //添加
        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insmodel(CG_Commodity com)
        {

            if (Commdal.ins(com) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("insert");
            }
        }

        //更新 根据id先查出来
        public ActionResult update(int id)
        {
            CG_Commodity com = Commdal.selid(id);
            return View(com);
        }
        //实现更新
        public ActionResult upmodel(CG_Commodity com)
        {
            if (Commdal.up(com) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("update");
            }
        }

        //json数据
        public JsonResult listjson()
        {
            List<CG_Commodity> list = Commdal.sel();
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            result.Data = list;
            return result;
        }
    }
}