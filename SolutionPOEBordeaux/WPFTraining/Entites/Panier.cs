using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class Panier
    {
        public List<LignePanier> Lignes { get; set; }

        public Panier()
        {
            Lignes = new List<LignePanier>();
        }

        public double Total
        {
            get
                {
                double s = 0;
                foreach(LignePanier ligne in Lignes)
                {
                    s += ligne.PrixTotal;
                }
                return s;
            }
        }

        public int NbArticles
        {
            get
            {
                int nb = 0;
                foreach(LignePanier ligne in Lignes)
                {
                    nb += ligne.Qte;
                }
                return nb;
            }
        }

        public void Ajouter(LignePanier ligne)
        {
            int position = Lignes.IndexOf(ligne);
            if (position == -1)
                Lignes.Add(ligne);
            else
                Lignes[position].Qte += ligne.Qte;

        }

        public void Supprimer(LignePanier ligne)
        {
            Lignes.Remove(ligne);
        }

        public void ChangerQte(LignePanier ligne, int changement)
        {
            if (ligne.Qte == 1 && changement == -1)
                Supprimer(ligne);
            else
                ligne.Qte += changement;
        }
    }
}
