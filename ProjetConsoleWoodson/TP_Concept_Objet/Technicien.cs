using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Technicien : Employe
    {
        public const double FACTEUR_UNITE = 5;
        public int Unites { get; set; }

        public Technicien(string nom, string prenom, int age, string dateEntree, int Unites) : base(nom, prenom, age, dateEntree)
        {
            this.Unites = Unites;
        }


        public override double CalculerSalaire()
        {
            return FACTEUR_UNITE * Unites;
        }

        public override string GetTitle()
        {
            return "Le techicien  ";
        }
    }
}
