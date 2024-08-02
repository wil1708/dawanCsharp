using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMVC.Filters
{
    public class LoginFilter : ActionFilterAttribute
    {
       

        //Vérifier si le user est connecté ou pas - son profil 
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
                //Pour un filtre global - seul la page login est accéssible

                //if (!filterContext.HttpContext.Request.AppRelativeCurrentExecutionFilePath.Equals("~/Login/Index"))
                //{
                //    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                //}

            //redirection vers la page de Login
            if (filterContext.HttpContext.Session["userAdmin"] == null)
            {
                filterContext.HttpContext.Response.Redirect("~/Login/Index");
            }


               
            
        }
    }
}