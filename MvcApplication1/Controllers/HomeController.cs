using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CssFile = "<link href=\"Styles/Site2.css\" rel=\"stylesheet\" type=\"text/css\" />";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
