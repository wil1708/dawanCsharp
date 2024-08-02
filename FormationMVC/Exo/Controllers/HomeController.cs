using Exo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Exo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(MailForm form)
        {
            //Envoyer le Mail
            if (ModelState.IsValid)
            {
                MailMessage msg = new MailMessage(form.Mail, "william.wpires@gmail.com", form.Sujet, form.Contenu);
                msg.CC.Add("william.wpires@gmail.com");

                //Instanciation du client : on se connecte au server SMTP gmail
                //Provider GMAIL
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                //On indique au client d'utiliser les informations qu'on va lui fournir
                client.UseDefaultCredentials = true;

                //Ajoute des informations de connexions :
                //On initialise une nouvelle instance NetworkCredential avec le nom de l'utilisateur et le mot de passe
                client.Credentials = new NetworkCredential("jehannblabla@gmail.com", "jehanndawan150");

                //On active le protocole SSL
                client.EnableSsl = true;
                client.Send(msg);

                ViewBag.Message = "Votre message a bien été envoyé";

                ModelState.Clear();

            }

            return View(new MailForm());
        }



    }
}