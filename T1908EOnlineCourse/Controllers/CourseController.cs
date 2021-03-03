using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T1908EOnlineCourse.Controllers
{
    public class CourseController : Controller
    {
        [Authorize(Roles ="CourseManager")]
        public ActionResult Index()
        {
            return View();
        }
    }
}