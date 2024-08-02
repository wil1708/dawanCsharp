using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Good
{
    public class UserService : IService
    {
        //Traiter les dépendences
        private IRepository repo;

        //Injection de dependence

        //Cas 1: injection par constructeur
        /*
         * Avantage:
         * un objet de type UserService est crée dans un état stable, la dépendence est injecté et initialisée
         * 
         * Inconvénient:
         * impossible de changer de dépendence
         */

        public UserService(IRepository repo)
        {
            this.repo = repo;
        }

        public object TraiterUser(int id)
        {

            User u = repo.getById(id);

            //Traiter l'objet User

            return null;
        }

        //Cas 2: injection par paramètres de la méthode
        /*
         *Avantage: à chaque appel de la méthode on a la possibilité de changer de dépendence 
         * Contrainte: dépendence à fournir à chaque appel de la méthode
         */

        public object TraiterUser(int id, IRepository repo)
        {
            
            User u = repo.getById(id);

            //Traiter l'objet User

            return null;
        }

        //Cas 3: injection par setteur
        /*
         * Approche très rare à utiliser uniquement si vous êtes contraits
         *Possibilité de changer de dépendence 
         * Contraite: s'assurer que la dépendence à été injectée.
         */

        public UserService()
        {
            
        }

        public IRepository Repo
        {
            get
            {
                return null;
            }
            set
            {
                repo = value;
            }

        }

        


    }
}
