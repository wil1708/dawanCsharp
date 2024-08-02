using _3_MVCApiCLient.ApiClients;
using _3_MVCApiCLient.DTO;
using _3_MVCApiCLient.Filters;
using _3_MVCApiCLient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _3_MVCApiCLient.Controllers
{
    
    public class LoginController : Controller
    {
        
        private ApiUser api = new ApiUser();
        // GET: Login
        public ActionResult Connexion()
        {
            return View(new UserDTO());
        }

        [HttpPost]
        public async Task<ActionResult> Connexion(UserDTO dto)
        {
            var reponse = await api.CheckLogin(dto);
            if (reponse.ToString().Equals("OK"))
            {
                Session["user"] = dto;
                return RedirectToAction("Index", "Users");
            }
            else
            {
                ViewBag.Error = "Echec Authentification";
                return View(dto);
            }
        }

        public ActionResult Deconnexion()
        {
            Session.Clear();
            return RedirectToAction("Connexion"); 
        }

        

       
    }
}