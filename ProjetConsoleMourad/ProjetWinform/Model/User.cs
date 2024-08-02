using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Model
{
   public enum Profile
    {
        ADMIN, MANAGER,STAGIAIRE,RH
  }
    public class User
    {
       
        public string Login { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public Profile Profil { get; set; }

        //SFD: spéficifications fonctionnelles détaillées:
        //Créer une classe USer dans le dossier Model - un User possède login, password....
        //Contraintes: Le profil du User doit être égale au contenu de l'enum

        public static string[] Profiles = {"ADMIN","MANAGER","STAGIAIRE","RH" };

        public User(string login, string password, string photo, Profile profil)
        {
            Login = login;
            Password = password;
            Photo = photo;
            Profil = profil;
        }

        public User()
        {
        }

        public override string ToString()
        {
            return "Login: "+Login+" Profile: "+Profil;
        }
    }
}
