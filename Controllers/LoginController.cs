using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoSite.Models;

namespace ContosoSite.Controllers
{
    public class LoginController : Controller
    {
        private ATP2Entities context = new ATP2Entities();
        public bool Validate(Admin admin)
        {
            Admin valid = this.context.Admins.SingleOrDefault(u => u.UserName == admin.UserName && u.Password == admin.Password);
            return valid != null;
        }

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            bool valid = Validate(admin);
            if (valid)
            {
                Session["Username"] = admin.UserName;
                return RedirectToAction("Index", "Home");

;            }
            else
            {
                return View();
            }
        }
    }
}