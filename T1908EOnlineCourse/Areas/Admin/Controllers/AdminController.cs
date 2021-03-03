using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Areas.Admin.Controllers
{
   
    public class AdminController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; set; }
        private Model2 _dbContext;

        public AdminController()
        {
            _dbContext = new Model2();
        }
        [Authorize(Roles = "")]
        public async Task<ActionResult> Index()
        {
            string userId = User.Identity.GetUserId();
            ////var roles = UserManager.GetRoles(userId);
            ////var roles = Roles.GetRolesForUser();
            //var claims = ClaimsPrincipal.Current.Identities.First().Claims.ToList();
            ////Filter specific claim    
            //var AdminRole = claims?.FirstOrDefault(x => x.Value.Equals("User", StringComparison.OrdinalIgnoreCase))?.Value;
            //var getuser = _dbContext.AspNetUsers.FindAsync(userId);
            var currentUser = _dbContext.AspNetUsers.Where(i => i.Id == userId).FirstOrDefault();
            var data = (from s in _dbContext.AspNetUsers select s).ToList();
            ViewBag.UserList = data;

            return View("AdminIndex",data);
        }



        [Authorize(Roles = "User")]
        public ActionResult User1()
        {
            return View("UserIndex");
        }
    }
}