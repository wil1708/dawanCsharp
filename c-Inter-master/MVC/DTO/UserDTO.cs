using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "User name obligatoire")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password obligatoire")]
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public string Email { get; set; }
    }
}