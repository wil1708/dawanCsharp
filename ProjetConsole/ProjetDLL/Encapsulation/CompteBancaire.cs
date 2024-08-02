using ProjetDLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Encapsulation
{
    [Serializable]
    [DataContract] //Annotation pour la sérialisation JSON
    public class CompteBancaire
    {
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public double Solde { get; set; }

        public static string Banque = "Credit Lyonnais";

        //Variable de classe : variable globale qui est partagée entre toutes les instances de la classe
        //N'a qu'une copie dans la totalité de l'éxecution
        //Peu importe le nombre de fois où l'instance de la classe a été créée
        public static int NbCompte { get; set; }

        //A chaque nouvel objet de la classe cette variable sera incrémenté
        //Afin de connaitre le nombre de compte crée
        //Constructeur par défaut
        public CompteBancaire()
        {
            NbCompte++;
        }

        //Le mot clé this représente l'objet dans lequel nous nous trouvons
        //Il est généralement, il y en a qui le mette et d'autres non
        //Constructeur avec paramètre
        public CompteBancaire(string Numero, double Solde) : this(Numero)  //this() : permet d'appeler un constructeur dans la même classe
        {
            //this.Numero = Numero;
            this.Solde = Solde;
            NbCompte++;
        }

        //Initialise seulement le numéro
        public CompteBancaire(string Numero)
        {
            this.Numero = Numero;
            //NbCompte++;
        }

        public void Depot(double montant)
        {
            Solde += montant;
        }

        public void Retrait(double montant)
        {
            if (Solde > montant)
            {
                Solde -= montant;
            }
            else
            {
                //Console.WriteLine("Solde insuffisant !!!");
                //Le mot clé throw permet de lever une exception manuellement en instanciant un objet de type exception ou un objet hérité
                throw new SoldeException("Solde insuffisant pour cette opération");
            }
        }

        public static void NomBanque()
        {
            Console.WriteLine(Banque);
        }

        //La redéfinition permet à une classe fille (exemple ici, Classe CompteBancaire) de fournir une implémentation spécifique d'une méthode déjà fournie à sa classe parente
        //En cas de redéfinition de méthode, les paramètres doivent être identique



        //Redéfinition de la méthode ToString
        //La méthode ToString : Personaliser l'affichage des objets
        public override string ToString()
        {
            return "Numero: " + Numero + " - " + " Solde: " + Solde;
        }

        //Pour comparer sémantiquement deux instances, on redéfinit la méthode Equals de la classe Object
        public override bool Equals(object obj)
        {
            CompteBancaire cb = obj as CompteBancaire;

            //On vérifie si l'objet passé en paramètre est null

            if (cb == null)
            {
                return false;
            }

            //Comparer les propriétés de l'instance courante et de l'objet passé en paramètre
            return this.Numero == cb.Numero && this.Solde == cb.Solde;
        }

        //Nous nous servons du fait que chaque variable de la classe possède déjà un identifiant obtenu avec la méthode
        //GetHashCode(). En combinant chaque identifiant de chaque propriété, nous pouvons en créer un nouveau
        public override int GetHashCode()
        {
            return Numero.GetHashCode() * Solde.GetHashCode();
        }

    } 
}
