using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraining.Entites;

namespace WPFTraining.AccessDonnees
{
    public class ProduitDao
    {
        //liste statique de produits
        private static List<Produit> produits;

        //constructeur statique => pour initialiser les variables statiques
        static ProduitDao()
        {
            produits = new List<Produit>();
            produits.Add(new Produit(1, "clavier", 45));
            produits.Add(new Produit(2, "ordinateur", 450));
            produits.Add(new Produit(3, "souris", 15));
        }


        //Lister() => Liste de produits
        public List<Produit> Lister()
        {
            return produits;
        }

        //Rechercher(int id) => Produit
        public Produit Rechercher(int id)
        {
            //Solution 1
            return produits.Where(p => p.Id == id).FirstOrDefault();

            //Solution 2
            //foreach(Produit p in produits)
            //{
            //    if (p.Id == id)
            //        return p;
            //}
            //return null;

            //Solution 3
            //int pos = produits.IndexOf(new Produit { Id = id });
            //return (pos == -1)? null:produits[pos];
        }

        //Inserer(Produit p)
        public void Inserer(Produit p)
        {
            produits.Add(p);
        }


        //Modifier(Produit p)
        public void Modifier(Produit p)
        {
            int pos = produits.IndexOf(p);
            if (pos != -1)
                produits[pos] = p;
        }

        //Supprimer(int id)
        public void Supprimer(int id)
        {
            produits.Remove(Rechercher(id));

            //Autre solution
            //int pos = produits.IndexOf(new Produit { Id = id });
            //if (pos != -1)
            //    produits.RemoveAt(pos);

        }
    }
}
