using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class STBindingController : Controller
    {
        // GET: STBinding
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionOne(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult ActionTwo(int id = 1)
        {
            return View("ActionOne");
        }

        public ActionResult ActionTree(int? id)
        {
            return View("ActionOne");
        }
    }
}