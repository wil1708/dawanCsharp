using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Abstraction
{
    //Une classe abstraite a pour rôle principal de factoriser les attributs et méthodes communs aux classes filles
    // - peut contenir des attributs
    // - peut contenir des méthodes définies (implémentées)
    // - peut contenir des méthodes abstraites que les classes filles doivent obligatoirement implémenter
    // =========================>>>>>>>Il y a une notion de contrat
    // Contient forcément des constructeurs
    // NE PEUT PAS ETRE INSTANCIEE
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne()
        {
        }

        protected Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public abstract void Identite();
    }
}
