using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Singleton
{
    public class Directeur
    {
        public  string Name { get; set; }

        //Ex: une société ne peut avoir qu'un seul et unique Directeur - Garantir l'existance d'1 instance de cette classe

        //interdir l'accès au constructeur
        private Directeur()
        {

        }

        //Une var static pour avoir l'instance unique
        private static Directeur instance;

        //Vérrouiller la ressource
        private static object _lock = new object();

        //Propriété en lecture seule
        public static Directeur Instance
        {
            get
            {
                if (instance == null)
                {
                    //un verrou de synchronisation pour les threads, seul un thread pourra accéder à cette instance
                    lock (_lock)
                    {
                        instance = new Directeur();
                    }                   
                }
                return instance;
            }
        }
    }
}
