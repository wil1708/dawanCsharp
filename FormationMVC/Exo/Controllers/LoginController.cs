using Exo.Filters;
using Exo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo.Controllers
{
    
    public class LoginController : Controller
    {
        private MyContext context = new MyContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(Utilisateur user)
        {
            string msrErreur = "Echec authentification";
            if (ModelState.IsValid)
            {
                Utilisateur userDB = context.Utilisateurs.SingleOrDefault(u => u.Email.Equals(user.Email));

                if (userDB != null)
                {
                    if (userDB.Password.Equals(user.Password))
                    {
                        //Session est un objet(dictionnaire crée côté serveur, accessible pa l'ensemble des contrôles et disponible tant que l'application est en cours d'execution
                        //Une session possède une durée par défaut limitée à 20 minutes
                        if (userDB.Admin)
                        {
                            Session["Admin"] = userDB.Admin; //Enregistrement de userDB.Admin dans la session
                        }

                        Session["user_id"] = userDB.Id;

                        //Session.Timeout = 1; //permet de limiter la durée de la session à 1 min
                        return RedirectToAction("Index", "Products");

                    }
                    else
                    {
                        ViewBag.Error = msrErreur;
                    }
                }
                else
                {
                    ViewBag.Error = msrErreur;
                }

            }
            else
            {
                ViewBag.Error = msrErreur;
            }
            return View("Index", user);
        }

        public ActionResult Logout()
        {
            //Vider le contenu de la clé user_id définie dans la session
            Session.Remove("user_id");
            Session.Remove("admin");

            //Pour vider tout le contenu de la session
            /*Session.RemoveAll();*/

            //Session.Abandon(); --le serveur crée une nouvelle session en mémoire
            return View("Index", new Utilisateur());
        }

        public ActionResult Authorization()
        {
            return View();
        }
    }
}