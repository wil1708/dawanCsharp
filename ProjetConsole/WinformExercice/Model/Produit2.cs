using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformExercice.Model
{
    public class Produit2
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public Produit2()
        {

        }

        public Produit2(int id, string description, double prix, int quantite )
        {
            Id = id;
            Description = description;
            Prix = prix;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return "Description " + Description + "Prix " + Prix + "Quantite " + Quantite;
        }
    }
}
