using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class AdvancedBinderController : Controller
    {
        // GET: AdvancedBinder
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string data)
        {
            ViewBag.Data = data;
            return View(); 
        }
    }
}