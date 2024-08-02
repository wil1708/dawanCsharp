using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Abstraction
{
    /*
     * Une classe abstraite a pour role principal de factoriser les attributs et méthodes communs aux classes filles
     *     - peut contenir des attributs
     *     - peut contenir des méthodes définies (implementées)
     *     - peut contenir des methodes abstraites que les classes filles doivent obligatoirement implement
     *     =========>>>>>>>>Il y a une notion de contrat
     *     Contient forcement des constructeurs 
     *     NE PEUT PAS ETRE INSTANCIEE
     */
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne()
        {
        }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public abstract void Identite();


        public void afficher()
        {
            Console.WriteLine("Je suis une personne");
        }

    }
}
