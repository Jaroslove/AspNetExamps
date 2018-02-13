using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            AspNetExamps.Models.Pro.Product product = new Models.Pro.Product
            {
                ID = 1,
                Name = "One",
                IsTan = true
            };

            return View(product);
        }
    }
}