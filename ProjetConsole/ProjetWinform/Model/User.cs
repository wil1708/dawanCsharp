using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Model
{
    public enum Profile
    {
        ADMIN, MANAGER, STAGIAIRE, RH
    }
    public class User
    {

        public string Login { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public Profile Profile { get; set; }

        public static string[] Profiles = {"ADMIN", "MANAGER","STAGIAIRE", "RH" };

        public User()
        {
        }

        public User(string login, string password, string photo, Profile profile)
        {
            Login = login;
            Password = password;
            Photo = photo;
            Profile = profile;
        }

        public override string ToString()
        {
            return "Login: " + Login + "Profile: " + Profile;
        }
    }
}
