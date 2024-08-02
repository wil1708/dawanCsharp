﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ExoQuiz
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Utilisateur(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
