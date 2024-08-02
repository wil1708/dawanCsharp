using _1_DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1_DemoApi.Controllers
{
    [RoutePrefix("api/Students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id = 1, Name = "William"},
            new Student(){Id = 2, Name = "Sara"},
            new Student(){Id = 3, Name = "Lionel"}
        };

        //Web Api V1 propose le type HttpResponseMessage
        //Liste des Student : GET : api/Students

        /*public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, students);
        } 

        //Student by id : GET : api/Students/id

        public HttpResponseMessage Get(int id)
        {
            var student = students.FirstOrDefault(st => st.Id == id);
            if (student == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with id = " + id + " not found");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, student);
            }
        }*/

        //Web Api V2 propose le type IHttpActionResult
        //OK()
        //Created()
        //NotFound()
        //
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllStudents()
        {
            return Ok(students);
        }

        //Le nom d'une Route n'est pas utilisé pour appeler les actions d'un controller API
        //Peut être utilisépour générer l'URI de la Route dans le code
        [HttpGet]
        [Route("{id:int:range(1,10)}", Name = "GetStudentById")] //ajout de contraintes aux paramètres d'une action
        public IHttpActionResult FindById(int id)
        {
            var student = students.FirstOrDefault(st => st.Id == id);
            if (student == null)
            {
                return NotFound();
                /*
                 * Pour personaliser le message
                 * 
                 * return Content(HttpStatusCode.NotFound, "Student with id = " + id + " not found");
                 */

            }
            else
            {
                return Ok(student);
            }
        }
        [HttpGet]
        [Route("{id}/courses")] //override du routage par défaut
        public List<string> GetStudentCourses(int id)
        {
            if(id == 1)
            {
                return new List<string>() { "c#", "EntityFramework", "Ms Test" };
            }else if(id == 2)
            {
                return new List<string>() { "java", "Spring", "Web Api" };
            }
            else
            {
                return new List<string>() { "Angular", "JavaScript", "ADO.NET" };

            }
        }

        [HttpGet]
        [Route("~/api/teachers")]  //override du RoutePrefix : utilisation du ~
        public List<string> GetTeachers()
        {
            return new List<string>() { "Dawan", "Jehann" };
        }

        [HttpGet]
        [Route("{name:alpha}")] //case sensitive, alpha concerne les parametre string
        public Student FindByName(string name)
        {
            return students.FirstOrDefault(st => st.Name.ToLower() == name.ToLower());
        }

        //POST : api/Students : student à insérer est fourni dans le body
        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] Student student)
        {
            students.Add(student);
            //Post : Convention renvoie status Ok + URI de la ressource crée

            //Option1: 
            var reponse = Request.CreateResponse(HttpStatusCode.Created, student);
            reponse.Headers.Location = new Uri(Request.RequestUri + "/" + student.Id);// api/Students/{id}

            //Option2: utilisation de routes nommées
            var reponse2 = Request.CreateResponse(HttpStatusCode.Created, student);
            reponse2.Headers.Location = new Uri(Url.Link("GetStudentById", new { id = student.Id })); // api/Students/{id}

            return reponse2;
        }
    }
}
