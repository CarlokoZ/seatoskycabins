using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeaToSkyCabinsApplication.Controllers
{
    public class OwnerController : Controller
    {
        // GET: Owner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Properties()
        {
            return View();
        }
        public ActionResult PropertyDetails()
        {
            return View();
        }
    }
}
