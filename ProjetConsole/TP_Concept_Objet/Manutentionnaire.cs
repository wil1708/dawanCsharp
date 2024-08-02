using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Manutentionnaire : Employe
    {
        public int Heures { get; set; }

        public const double SALAIRE_HORAIRE = 65;
        public Manutentionnaire(string nom, string prenom, int age, string dateEntree, int heures) : base(nom, prenom, age, dateEntree)
        {
            Heures = heures;
        }

        public override double CalculerSalaire()
        {
            return Heures * SALAIRE_HORAIRE;

        }

        public string GetNom()
        {
            return "Le manutentionnaire ";
        }

        
    }
}
