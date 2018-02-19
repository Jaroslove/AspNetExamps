using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class MBinderController : Controller
    {
        // GET: MBinder
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetData()
        {
            AspNetExamps.Models.MBModel.Model model = new Models.MBModel.Model();

            UpdateModel(model);

            return View("Index");
        }
    }
}