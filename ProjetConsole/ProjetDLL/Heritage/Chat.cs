using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Heritage
{
    public class Chat : Animal
    {
        public string Couleur { get; set; }
        public Chat()
        {

        }

        public Chat(string nom, int age, string couleur) : base(nom,age)
        {
            Couleur = couleur;
        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un chat");
        }


    }
}
