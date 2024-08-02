using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class ManutentionnaireARisque : Manutentionnaire
    {
        public const double PRIME = 200;

        public ManutentionnaireARisque(string nom, string prenom, int age, string dateEntree, int heures) : base(nom, prenom, age, dateEntree, heures)
        {

        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }

        public override string GetTitle()
        {
            return "Le Manutentionnaire à riques";
        }
    }
}
