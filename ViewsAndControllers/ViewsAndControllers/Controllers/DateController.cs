using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index()
        {
            return View(viewName: "Index", model: DateTime.Now.ToString("MM/dd/yyyy"));
        }

        [HttpPost]
        public ActionResult Date(DateTime inputDate)
        {
            return View(viewName: "Index", model: inputDate.ToString("MM/dd/yyyy"));
        }
    }
}