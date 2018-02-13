using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class ProdEFController : Controller
    {
        AspNetExamps.Models.EF.ProductsContext db = new Models.EF.ProductsContext();
        

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();

            base.Dispose(disposing);    
        }
    }
}