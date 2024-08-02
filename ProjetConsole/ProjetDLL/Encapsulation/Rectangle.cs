using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Encapsulation
{
    /*
     * 1- L'encapsulation est le fait de regrouper dans une seule entité les données et les traitements qui sont propres à l'entité
     * 
     * La partie interne, doit être non visible par les utilisateurs - les attributs (les propriétés) font parti du niveau interne ========> ILF FAUT DONC LES METTRE EN PRIVATE
     * 
     * 2- Possibilité d'offrir aux utilisateurs l'accès aux attributs via des getters, et setters avec du contrôle, des restrictions
     * 
     * Interface : Contient que des methodes public (dont getter et setter)
     */
    public class Rectangle
    {
        //Propriété simple : une propriété sans contrainte
        //get : envoie une valeur du même type que la propriété
        //set : permet de mettre à jour nos valeurs
        /*public double Longueur { get; set; }

        public double Largeur { get; set; }
        */

        //La propriété full peut faire un peu plus de chose que simplement renvoyer une valeur
        //Elle peut être utile dans le cas où l'on veut mettre en place des restrictions, des contraintes sur l'accès ou la mise à jour des données, des attributs

        //Champs sont privés : permet de cacher l'état interne de nos objets
        private double longueur;  
        
        //La propriété : permettre de sécuriser les changements d'états
        //Une paire de méthode permettant l'accès à un attribut/champs grâce au mot clé get et set
        //Avec le mot clé get, nous donnons la possibilité de lire le champs privé
        //Avec le mot clé set, nous lui donnons la possibilité d'affecter une valeur au champs privé
        //"value" est un mot clé qui permet de dire : la valeur que nous avons affectée
        public double Longueur
        {
            get {
                Console.WriteLine("Merci de fournir le mot de passe : ");
                string pass = Console.ReadLine();
                if(pass.Equals("a"))
                {
                    return longueur;
                }
                else
                {
                    Console.WriteLine("Echec d'authentification !!!");
                    return 0;
                }
                 }
            set { 
                if(value > 0)
                {
                    longueur = value;
                }
                else
                {
                    Console.WriteLine("La longueur doit être positive");
                }
                 
            }
        }

        private double largeur;

        public double Largeur
        {
            get {
                Console.WriteLine("Merci de fournir le mot de passe : ");
                string pass = Console.ReadLine();
                if (pass.Equals("a"))
                {
                    return largeur;
                }
                else
                {
                    Console.WriteLine("Echec d'authentification !!!");
                }
                return largeur; }
            set
            {
                if (value > 0)
                {
                    longueur = value;
                }
                else
                {
                    Console.WriteLine("La longueur doit être positive");
                }
            }
        }
        public double Surface()
        {
            return Longueur * Largeur;
        }
    }
}
