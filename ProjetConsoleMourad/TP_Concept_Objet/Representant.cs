using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Representant : Commercial
    {
        public const double POURCENT_REPRESENTANT = 0.2;
        public const double BONUS_REPRESENTANT = 800;

        public Representant(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree, chiffreAffaire)
        {

        }

        public override double CalculerSalaire()
        {
            return (ChiffreAffaire * POURCENT_REPRESENTANT + BONUS_REPRESENTANT);
        }

        public override string GetTitle()
        {
            return "Le Représentant";
        }
    }
}
