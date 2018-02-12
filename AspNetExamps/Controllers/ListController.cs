using AspNetExamps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            List<Lil> list = new List<Lil>
            {
                new Lil{ID = 1, Name = "One"},
                new Lil{ID = 2, Name = "Two"},
                new Lil{ID = 3, Name = "Three"}
            };

            ViewBag.List = new SelectList(list, "ID", "Name", 2);

            return View();
        }

        [HttpPost]
        public ActionResult Index(string str)
        {
            return View("Selected", (object)str);
        }
    }
}