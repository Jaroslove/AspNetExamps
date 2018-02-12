using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class HelperMethodsController : Controller
    {
        // GET: HelperMethods
        public ActionResult Index()
        {
            ViewBag.Days = new string[] { "Monday", "Thusday", "Wensday" };
            ViewBag.Months = new string[] { "January", "February" };
            return View();
        }
    }
}