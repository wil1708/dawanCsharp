using ExoMVC.DTO;
using ExoMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMVC.Controllers
{
    public class AccountController : Controller
    {
        private UtilisateurService service = new UtilisateurService();
        // GET: Account
        public ActionResult Index()
        {
            return View(new UserDTO());
        }

        [HttpPost]
        public ActionResult Index(UserDTO userDTO)
        {
            if (ModelState.IsValid)
            {
                service.Add(userDTO);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(userDTO);
            }
            
        }
    }
}