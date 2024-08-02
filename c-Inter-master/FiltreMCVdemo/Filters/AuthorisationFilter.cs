using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FiltreMCVdemo.Filters
{
    public class AuthorisationFilter : AuthorizeAttribute
    {
        private string[] allowedroles;

        public AuthorisationFilter(params string[] allowedroles)
        {
            this.allowedroles = allowedroles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            string username = Convert.ToString(httpContext.Session["username"]);
            if (!string.IsNullOrEmpty(username))
            {
                //Récupérer le role du User connecté
                using (var context = new MyContext())
                {
                    var userRole = (from u in context.Users
                                    join r in context.Roles on u.RoleId equals r.Id
                                    where u.UserName == username
                                    select new { r.Name }).FirstOrDefault();

                    //Vérifier si le rôle est contenu dans le string[] allowedroles
                    foreach (var role in allowedroles)
                    {
                        if (role == userRole.Name)
                        {
                            authorize = true;
                        }
                    }
                }
               
            }


            return authorize;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Home" },
                    {"action", "NonAuthorise" }

                });
        }
    }
}