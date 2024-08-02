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

        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom + "Prenom : " + Prenom);
        }


        public override string ToString()
        {
            return "Méthode ToString - Nom: " + Nom + " Prenom: " + Prenom;
        }
    }
}
