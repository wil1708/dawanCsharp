using FiltreMCVdemo.Filters;
using FiltreMCVdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltreMCVdemo.Controllers
{

    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            if (ModelState.IsValid)
            {
                using (var context = new MyContext())
                {
                    User userDB = context.Users.Where(user => user.UserName == u.UserName && user.Password == u.Password).FirstOrDefault();
                    if (userDB != null)
                    {
                        Session["username"] = userDB.UserName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "UserName ou Password invalide");
                        return View(u);
                    }
                }
            }
            else
            {
                return View(u);
            }

        }

        public ActionResult LogOut()
        {
            Session["username"] = String.Empty;
            return RedirectToAction("Login", "Account");
        }

        
    }
}