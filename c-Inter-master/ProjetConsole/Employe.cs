using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Employe()
        {
            Nom = "TOTO";
            Prenom = "TATA";
        }

        public Employe(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public void Afficher(string nom, string prenom)
        {
            Console.WriteLine("Méthode Afficher - Nom : " + nom + " Prenom : " + prenom);
        }


        public override string ToString()
        {
            return "Méthode ToString - Nom: " + Nom + " Prenom: " + Prenom;
        }
    }
}
