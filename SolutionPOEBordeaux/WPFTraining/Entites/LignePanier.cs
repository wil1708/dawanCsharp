using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class LignePanier
    {
        public Produit Produit { get; set; }
        public int Qte { get; set; }

        public LignePanier()
        {
        }

        public LignePanier(Produit produit, int qte)
        {
            Produit = produit;
            Qte = qte;
        }

        public string ProduitDescription
        {
            get
            {
                return Produit.Description;
            }
        }

        public double PrixUnitaire
        {
            get
            {
                return Produit.Prix;
            }
        }
        public double PrixTotal
        {
            get
            {
                return Produit.Prix * Qte;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is LignePanier ligne &&
                   EqualityComparer<Produit>.Default.Equals(Produit, ligne.Produit);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


}

