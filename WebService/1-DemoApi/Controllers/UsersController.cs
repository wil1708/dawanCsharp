using _1_DemoApi.DTO;
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
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        private UserService service;

        public UsersController(UserService service)
        {
            this.service = service;
        }

        public UsersController()
        {
            this.service = new UserService(new UserRepository(new MyContext()));
        }

        //URL BASE : api/Users

        //GET : api/Users
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, service.FindAll());
        }

        //POST : api/Users - user fournit dans le body
        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] User u)
        {
            service.Save(u);
            var reponse = Request.CreateResponse(HttpStatusCode.Created, u);

            //Fournir l'URI du user inséré
            reponse.Headers.Location = new Uri(Request.RequestUri + "/" + u.Id);
            return reponse;
        }

        //GET : api/Users/id
        [HttpGet]
        [Route("{id:int}")]
        public HttpResponseMessage Get(int id)
        {
            User u = service.FindById(id);
            if(u == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User introuvable");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, u);
            }
            
        }

        //PUT : api/Users - user fournit dans le body
        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] User u)
        {
            service.Update(u);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //DELETE : api/Users/id
        [HttpDelete]
        [Route("{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            service.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //POST : api/check-login
        [HttpPost]
        [Route("~/api/check-login")]
        public HttpResponseMessage CheckLogin([FromBody] UserDTO dto)
        {
            User u = service.CheckLogin(dto.Email, dto.Password);
            if(u == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User introuvable");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
        
    }
}
