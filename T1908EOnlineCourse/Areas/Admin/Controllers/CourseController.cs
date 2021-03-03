using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T1908EOnlineCourse.Areas.Admin.Controllers
{
    public class CourseController : AdminController
    {
        // GET: Admin/Course
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin/Course
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}