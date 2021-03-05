using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Controllers
{
    public class CourseController : Controller
    {
        Model2 _db = new Model2();
        public ActionResult Index(string search_input)
        {
            var data = _db.Courses.ToList();
            if (!string.IsNullOrEmpty(search_input))
            {
                data = data.Where(x => x.name.ToLower().Contains(search_input.Trim().ToLower())).ToList();
            }
            return View(data);
        }
        public ActionResult DetailCourse(int id)
        {
            return View();
        }
    }

}