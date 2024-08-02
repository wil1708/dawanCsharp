using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Model
{
    public class Produit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public Produit()
        {
        }

        public Produit(int id, string description, double prix, int quantite)
        {
            Id = id;
            Description = description;
            Prix = prix;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return "Description: " + Description + "Prix : " + Prix + "Quantite: " + Quantite; 
        }
    }
}
