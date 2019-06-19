using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class SquareANumberController : Controller
    {
        // GET: SquareANumber
        public ActionResult Index()
        {
            return View(viewName: "index", model: 0.0);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: Math.Sqrt(inputNumber));
        }
    }
}