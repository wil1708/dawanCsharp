using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Bad
{
    public class UserService
    {
        //Méthode qui applique un traitement sur objet User
        public object TraiterUser(int id)
        {
            UserRepository repo = new UserRepository();
            User u = repo.finById(id);

            //Traiter l'objet User

            return null;
        }

        //Code sans injection de dépendence - Méthode complétement dépendente du repo
    }
}
