using HPIT.Data.Core;
using HPIT.Survey.Portal.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YZH.Dal;

namespace YZH.entity.Web.Controllers
{
    public class comfenController : Controller
    {
        // GET: comfen
        public ActionResult Index()
        {
            return View();
        }

        public DeluxeJsonResult QueryPageData(SearchModel<CG_Commodity> search)
        {
            int total = 0;
            var result = comfendal.Instance.GetPageData(search, out total);
            var totalPages = total % search.PageSize == 0 ? total / search.PageSize : total / search.PageSize + 1;
            return new DeluxeJsonResult(new { Data = result, Total = total, TotalPages = totalPages }, "yyy-MM-dd HH:mm");
        }
    }
}