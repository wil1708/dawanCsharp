using ExoMVC.DTO;
using ExoMVC.Filters;
using ExoMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ExoMVC.Controllers
{
   
    public class LoginController : Controller
    {
        private UtilisateurService service = new UtilisateurService();

        // GET: Login

        public ActionResult Accueil()
        {
            return View();
        }
       
        public ActionResult Index()
        {
            UserDTO dto = new UserDTO();
            return View(dto);
        }

        
        [HttpPost]
        public ActionResult Index(UserDTO dto)
        {
            //UserDTO user = new UserDTO();

            if (ModelState.IsValidField("UserName") && ModelState.IsValidField("Password"))
            {
                UserDTO user = service.findUserByUserNameAndPassword(dto);
                if (user != null && user.Id != 0)
                {
                    if (user.isAdmin)
                    {
                        Session["userAdmin"] = user;
                        
                        return RedirectToAction("Accueil");
                    }
                    else
                    {
                        return RedirectToAction("Accueil");
                    }
                    
                }
                else
                {
                    ViewBag.Erreur = "Echec connexion.....";
                    return View(dto);
                }
            }
            else
            {
                return View(dto);
            }
                      
        }

        public ActionResult Logout()
        {
            //Session["userAdmin"] = null;
            //Session.Abandon();
            Session.Clear();
            
            
            return RedirectToAction("Index");
        }

        public ActionResult HomePage()
        {
            return View();
        }
    }
}