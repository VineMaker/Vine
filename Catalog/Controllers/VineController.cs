using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class VineController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Vine controller";

            return View();
        }

        public ActionResult GetAll()
        {
            return View();
        }
    }
}
