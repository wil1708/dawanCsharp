using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonnel p = new PersonnelImpl();
            p.AjouterEmploye(new Vendeur("Pierre", "Business", 45, "1995", 30000));
            p.AjouterEmploye(new Representant("Léon", "Vendtout", 25, "2001", 20000));
            p.AjouterEmploye(new Technicien("Yves", "Bosseur", 28, "1998", 1000));
            p.AjouterEmploye(new Manutentionnaire("Jeanne", "Stocketout", 32, "1998", 45));
            p.AjouterEmploye(new TechnicienARisque("Jean", "Flippe", 28, "2000", 1000));
            p.AjouterEmploye(new ManutentionnaireARisque("Al", "Abordage", 30, "2001", 45));
            p.AfficherSalaires();
            Console.WriteLine("Le salaire moyen dans l'entreprise est de " + p.SalaireMoyen() + " Euros.");
            //garder la console ouverte (en attendant d'appuyer sur une touche)
            Console.ReadKey();
        }
    }
}
