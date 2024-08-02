using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Model
{
    public class Utilisateur
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(string login, string password, bool admin)
        {
            Login = login;
            Password = password;
            Admin = admin;
        }

        public override string ToString()
        {
            return "Login: " + Login;
        }






    }
}
