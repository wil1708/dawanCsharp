using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMVC.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name obligatoire")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mot de passe obligatoire")]
        public string Password { get; set; }

       
        public bool isAdmin { get; set; }

        [Required(ErrorMessage = "Email obligatoire")]
        public string Email { get; set; }

        public string Photo { get; set; }
    }
}