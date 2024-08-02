using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public abstract class Employe
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }

        public string DateEntree { get; set; }

        public Employe()
        {

        }
        public Employe(string nom, string prenom, int age, string dateEntree)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            DateEntree = dateEntree;
        }

        public abstract double CalculerSalaire();
        

        
        public virtual string GetTitle()
        {
            return "L'Employé : ";
        }
        public string GetNom()
        {
            return  GetTitle() + Nom + " " + Prenom;
        }


        

        

        
    }
}
