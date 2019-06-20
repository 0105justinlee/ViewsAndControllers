using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class HowOldController : Controller
    {
        // GET: HowOld
        public ActionResult Index()
        {
            
            return View(viewName: "Index", model: 0);
        }

        [HttpPost]
        public ActionResult Index(DateTime inputDate)
        {
            TimeSpan distance = DateTime.Now - inputDate;
            int year = (int) distance.TotalDays / 365;
            return View(viewName: "Index", model: year);
        }
    }
}