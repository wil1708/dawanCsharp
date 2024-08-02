using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo.Filters
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(filterContext.HttpContext.Session["user_id"] == null)
            {
                filterContext.HttpContext.Response.Redirect("~/Login/Index"); // /Controller/Action
            }
        }
    }
}