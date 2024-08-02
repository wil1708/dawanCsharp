using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Heritage
{
    public class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal() { 
        }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        //Virtual permet  aux classes filles de redefinir la methode
        public virtual void Identite()
        {
            Console.WriteLine("Je suis un animal");
        }

        public override string ToString()
        {
            return "Nom : " + Nom + " Age: " + Age; 
        }

        private void methodeAnimal()
        {

        }
    }
}
