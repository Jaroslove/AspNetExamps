using AspNetExamps.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Controllers
{
    public class ReductFormController : Controller
    {
        // GET: ReductForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            TaskModel task = new TaskModel
            {
                Name = "Unknown",
                StartDate = DateTime.Now.ToLongDateString(),
                Complete = false
            };

            return View(task);
        }

        [HttpPost]
        public ActionResult Create(TaskModel incoming)
        {
            Debug.WriteLine($"name is {incoming.Name}");
            Debug.WriteLine($"startDate is {incoming.StartDate}");
            Debug.WriteLine($"complete is {incoming.Complete}");

            return View("Success");
        }
    }
}