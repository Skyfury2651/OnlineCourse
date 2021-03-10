using PagedList;
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
        public int pageSize = 3;

        public ActionResult Index(string search_input, int? page, string currentFilter)
        {
            var categories = _db.Categories.ToList();
            ViewBag.categories = categories;
            var data = _db.Courses.ToList();
            if (search_input != null)
            {
                page = 1;
            }
            else
            {
                search_input = currentFilter;
            }

            ViewBag.CurrentFilter = search_input;

            if (!string.IsNullOrEmpty(search_input))
            {
                data = data.Where(x => x.name.ToLower().Contains(search_input.Trim().ToLower())).ToList();
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(data.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult DetailCourse(int id)
        {
            var data = _db.Courses.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
        public ActionResult FilterCategories(int id, int? page, string currentFilter)
        {
           var dataFilter = _db.Courses.Where(x => x.category_id == id).ToList();
            page = 1;
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            if(id != null)
            {
                dataFilter = dataFilter;
            }
            else
            {
                dataFilter = _db.Courses.ToList();
            }
            var categories = _db.Categories.ToList();
            ViewBag.categories = categories;
            

            return View("Index", dataFilter.ToPagedList(pageNumber, pageSize));
        }
    }

}