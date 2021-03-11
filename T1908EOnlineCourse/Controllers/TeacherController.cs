using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Controllers
{
    public class TeacherController : Controller
    {
        Model2 _db = new Model2();
        
        // GET: Teacher
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            var totalPrice = _db.AspNetUsers.Where(x => x.Id == userId).Single();
            ViewBag.countPrice = totalPrice.balance;
            var data = _db.UserCourses.Where(x => x.type == 1 && x.user_id == userId).ToList();
            var listCouser = new List<Transaction>();
            foreach (var item in data)
            {
                var user = _db.Transactions.Where(x => x.course_id == item.course_id).ToList();
                listCouser.AddRange(user);
            }
            ViewBag.list = listCouser.ToArray();

            StringBuilder sb = new StringBuilder();
            sb.Append("var ArrayPrice = new Array;");
            sb.Append("ArrayPrice.push(0);");
            foreach (var str in listCouser)
            {
                
                var priceformat = str.price;
                sb.Append("ArrayPrice.push(" + str.price.ToString() + ");");
                
            }
            ViewBag.arrayListPrice = sb.ToString();
            var arrayListPrice = listCouser.ToArray();

            return View(listCouser);
        }
        public ActionResult InformationTable()
        {
            string userId = User.Identity.GetUserId();
            var data = _db.UserCourses.Where(x => x.type == 1 && x.user_id == userId).ToList();
            var listCouser = new List<Transaction>();
            foreach (var item in data)
            {
                var user = _db.Transactions.Where(x => x.course_id == item.course_id).ToList();
                listCouser.AddRange(user);
            }

            return View(listCouser);
        }
    }
}