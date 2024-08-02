using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Manutentionnaire : Employe
    {
        public const double SALAIRE_HORAIRE = 65;
        public int Heures { get; set; }

        public Manutentionnaire(string nom, string prenom, int age, string dateEntre, int heures) : base(nom, prenom, age, dateEntre)
        {
            Heures = heures;
        }

        public override double CalculerSalaire()
        {
           return SALAIRE_HORAIRE * Heures;
        }

        public override string GetTitle()
        {
            return "Le Manutentionnaire ";
        }
    }
}
