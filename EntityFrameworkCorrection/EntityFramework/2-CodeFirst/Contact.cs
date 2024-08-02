using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //Approche Code First
        //1- Installer Entity Framework
        //2- Définir la chaine de connexion
        //3- Générer le context
    }
}
