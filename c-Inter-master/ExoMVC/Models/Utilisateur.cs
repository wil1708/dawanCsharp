﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMVC.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}