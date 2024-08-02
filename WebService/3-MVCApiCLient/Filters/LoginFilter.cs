using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_MVCApiCLient.Filters
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);

            if(filterContext.HttpContext.Session["user"] == null)
            {
                filterContext.HttpContext.Response.Redirect("~/Login/Connexion");
            }
        }
    }
}