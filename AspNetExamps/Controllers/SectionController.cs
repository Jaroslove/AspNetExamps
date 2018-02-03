using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class SectionController : Controller
    {
        // GET: Section
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly] // start only as partial view
        public string CurrentDate()
        {
            return DateTime.Now.ToLongDateString();
        }

        public ActionResult ShowTable(int number = 5)
        {
            IEnumerable<Models.ForView.Product> products = Models.ForView.Products.GetProducts().Take(number);

            return View("_ShowTable", products);
        }
    }
}