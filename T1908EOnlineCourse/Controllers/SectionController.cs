using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Controllers
{
    public class SectionController : Controller
    {
        Model2 _db = new Model2();
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lecture
        public ActionResult Index()
        {
            return null;
        }

        public ActionResult Lecture(int id)
        {
            var data = _db.Sections.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
    }
}