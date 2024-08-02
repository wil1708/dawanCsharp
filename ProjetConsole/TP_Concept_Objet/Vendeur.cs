using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Vendeur : Commercial
    {
        public const double BONUS_VENDEUR = 400;

        public const double POURCENTAGE_VENDEUR = 0.2;

       
        public Vendeur(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree, chiffreAffaire)
        {
        }

        public override double CalculerSalaire()
        {
            return ChiffreAffaire * POURCENTAGE_VENDEUR + BONUS_VENDEUR;

        }

        public override string GetTitle()
        {
            return "Le vendeur : ";
        }




    }
}
