using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class Produit
    {
        public int? Id { get; set; }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (value != null && value.Trim().Length > 0)
                    _description = value;
                else
                    throw new Exception("Erreur : description obligatoire !");
            }
        }
        private double _prix;

        public double Prix
        {
            get { return _prix; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Erreur : la valeur est négative");
                }
                else
                    _prix = value;
                    
            }
        }

        public Produit()
        {
        }

        public Produit(int? id, string description, double prix)
        {
            Id = id;
            Description = description;
            Prix = prix;
        }

        public override string ToString()
        {
            return "Description : " + Description + " Price : " + Prix;
        }

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   Id == produit.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
