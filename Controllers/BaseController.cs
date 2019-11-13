using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoSite.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(Session["Username"]==null)
            {
                Response.Redirect("http://localhost:60977/Login");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}