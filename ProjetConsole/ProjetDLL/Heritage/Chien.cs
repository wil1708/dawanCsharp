using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Heritage
{
    public class Chien : Animal
    {
        public string Couleur { get; set; }

        //Fait appel implicitement au constructeur supérieur donc pas la peine de mettre base() ici
        public Chien()
        {

        }

        public Chien(string nom, int age, string couleur) : base(nom, age)
        {
            Couleur = couleur;
            //Permet d'appeler le constructeur de la classe supérieure (Animal)
        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un chien");
        }


    }
}
