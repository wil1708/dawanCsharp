using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Agregation.faible
{
    public class Salarie
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }

        public Salarie(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }

        public Salarie()
        {
        }
    }
}
