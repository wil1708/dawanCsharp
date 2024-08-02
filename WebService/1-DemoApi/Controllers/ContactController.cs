using _1_DemoApi.Models;
using _1_DemoApi.Repositories;
using _1_DemoApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1_DemoApi.Controllers
{
    public class ContactController : ApiController
    {
        private IContactService service;

        public ContactController(IContactService service)
        {
            this.service = service;
        }

        public ContactController()
        {
            service = new ContactService(new ContactRepository(new MyContext()));
        }

        /// <summary>
        /// Méthode qui renvoie la liste des contacts
        /// </summary>
        /// <returns>Tous les contacts</returns>
        /*public List<Contact> GetContacts()
        {
            
            return service.GetAll();
        }*/

        //Les méthodes GET d'une API par convention renvoie le status 200 OK

        [HttpGet]
        public HttpResponseMessage GetContacts()
        {
            List<Contact> lst = service.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, lst);
        }

        /// <summary>
        /// Renvoie un contact par son id
        /// </summary>
        /// <param name="id">Id du contact de type int</param>
        /// <returns>Contact</returns>
        /*public Contact Get(int id)
        {
            Contact c = service.FindById(id);
            if(c != null)
            {
                return c;
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
        }*/

        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            Contact c = service.FindById(id);
            if(c != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, c);

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Contact avec ID = " + id + " introuvable");
            }
        }

        /*public void Post([FromBody] Contact c)
        {
            service.Insert(c);
        }*/
        
        //Post par convention renvoie le status 201 (ressource crée) - elle peut indiquer le chemin de la ressource
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Contact c)
        {
            try
            {
                service.Insert(c);
                var message = Request.CreateResponse(HttpStatusCode.Created, c);

                //Ajouter le chemin du contact crée
                message.Headers.Location = new Uri(Request.RequestUri + "/" + c.Id.ToString());

                return message;
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        /*public void Delete(int id)
        {
            service.Delete(id);
        }*/

        //Delete par convention renvoie le status Ok (200) - en cas d'échec renvoyer le status 404
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                Contact c = service.FindById(id);
                if(c != null)
                {
                    service.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Contact avec id = " + id + " introuvable");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /*public void Put(int id, [FromBody]Contact c)
        {
            Contact ctMAJ = service.FindById(id);
            if(ctMAJ != null)
            {
                service.Update(c);
            }
            else
            {
                throw new Exception("Contact inexistant");
            }
        }*/

        //PUT : convention doit renvoyer le status OK (200)

        public HttpResponseMessage Put(int id, [FromBody] Contact c)
        {
            try
            {
                Contact ctMAJ = service.FindById(id);
                if(ctMAJ != null)
                {
                    ctMAJ = c;
                    service.Update(ctMAJ);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Contact est introuvable"); 
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); 
            }
        }
    }
}
