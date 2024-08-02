using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class Candidat
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Email { get; set; }

        public Candidat()
        {
        }

        public Candidat(int id, string nom, string email)
        {
            Id = id;
            Nom = nom;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Candidat candidat &&
                   Id == candidat.Id;
        }
    }
}
