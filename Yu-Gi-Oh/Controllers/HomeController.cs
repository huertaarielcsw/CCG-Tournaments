using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yu_Gi_Oh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Información:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Team #2";

            return View();
        }
    }
}