using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1_DemoApi.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}