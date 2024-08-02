using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class TechnicienARisque : Technicien
    {
        public const double PRIME = 200;

        public TechnicienARisque(string nom, string prenom, int age, string dateEntree, int Unites) : base(nom, prenom, age, dateEntree, Unites)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }

        public override string GetTitle()
        {
            return "Le technicien à risque ";
        }
    }
      


}
