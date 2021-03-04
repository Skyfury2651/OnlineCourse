using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        Model2 _db = new Model2();
        public ActionResult Index()
        {
            var data = _db.Courses.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " Con vit con Your contact page.";

            return View();
        }
    }
}