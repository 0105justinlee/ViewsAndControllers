using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class MagicNumberController : Controller
    {
        // GET: MagicNumber
        public ActionResult Index()
        {
            return View(viewName: "index", model: 0);
        }

        [HttpPost]
        public ActionResult MagicNumber(int inputNumber1, int inputNumber2)
        {
            Random random = new Random();
            int random1;
            int random2;
            if (inputNumber1 > inputNumber2)
            {
                random1 = inputNumber2;
                random2 = inputNumber1;
            }
            else
            {
                random1 = inputNumber1;
                random2 = inputNumber2;
            }
            return View(viewName: "Index", model: random.Next(random1, random2 + 1));
        }
    }
}