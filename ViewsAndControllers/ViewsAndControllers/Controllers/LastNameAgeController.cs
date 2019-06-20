using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class LastNameAgeController : Controller
    {
        // GET: LastNameAge
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        
        [HttpPost]
        public ActionResult Index(string lastName, int age)
        {
            return View(viewName: "Index", model: Math.Abs(lastName.Length - age));
        }
    }
}