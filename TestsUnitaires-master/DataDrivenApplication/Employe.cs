using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataDrivenApplication
{
    public class Employe
    {
        public string Nom { get; set; }
        private string _email;

        public string Email
        {
            get { return _email; }
            set {
                
                //test75@dawan.fr   \d{1,3} -tous les chiffres  \w - toutes les lettres

                Regex regEmail = new Regex(@"^[a-zA-Z0-9\-]{1,30}@[a-zA-Z0-9]{1,30}\.[a-z-A-Z]{2,3}$");
                Regex regEmail2 = new Regex(@"^[\w\.\-\d]{1,30}@[\w\-\d]{1,30}\.[\w]{2,3}$");

                if (regEmail.Match(value).Success)
                    _email = value;
                else
                    throw new Exception("Format adresse email invalide");
                }
        }

    }//Vérifier que l'adresse email est valide
     //On peut utiliser une expression régulière pour valider l'email
     //Expression régulière: permet de définir un pattern(format de chaine) à respecter
     //"^[0-9]{10,13} $"
     //Identificateur national:
    /*
     * doit contenir 9 caractères au maximum
     * les 2 premiers sont des lettres
     * les 6 caractères suivants sont des chiffres
     * le dernier caract est soit: A,B,C,D - a,b,c,d
     * le 1er carat doit être une maj et ne doit pas être: D,F,I,O,Q,U,V
     * le second caract doit être une maj et ne doit pas être: D,F,I,O,Q,U,V,Z
     */
   // Regex identificateur = new Regex("^[A-CEGHJ-NPR-TW-Z]{1}[A-CEGHJ-NPR-TW]{1}[0-9]{6}[a-dA-D]{1}$");
}
