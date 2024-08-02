using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Representant : Commercial
    {
        public const double BONUS_REPRESENTANT = 800;

        public const double POURCENTAGE_REPRESENTANT = 0.2;

        
        public Representant(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree, chiffreAffaire)
        {
        }
        public override double CalculerSalaire()
        {
            return ChiffreAffaire * POURCENTAGE_REPRESENTANT + BONUS_REPRESENTANT ;
        }

        public string GetTitle()
        {
            return "Le représentant ";
        }
    }
}
