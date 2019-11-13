﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoSite.Controllers
{
    public class LogoutController : BaseController
    {
        // GET: Logout
        public ActionResult Index()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}