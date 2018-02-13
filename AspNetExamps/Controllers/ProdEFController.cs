using AspNetExamps.Models.EF;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();

            base.Dispose(disposing);    
        }
    }
}