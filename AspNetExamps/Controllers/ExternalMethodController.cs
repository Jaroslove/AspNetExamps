using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class ExternalMethodController : Controller
    {
        // GET: ExternalMethod
        public ActionResult Index()
        {
            ViewBag.Days = new string[] { "One", "Two"};

            return View();
        }
    }
}