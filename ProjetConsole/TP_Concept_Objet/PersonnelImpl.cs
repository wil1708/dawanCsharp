using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    class PersonnelImpl : IPersonnel
    {
        //Contient les employés
        public Employe[] Employes { get; set; }

        public const int MAXEMPLOYE = 250; //Le max employé que peut contenir l'entreprise

        //Qui représente le nombre actuel d'employés dans l'entreprise
        public static int NbreEmploye;

        public PersonnelImpl()
        {
            Employes = new Employe[MAXEMPLOYE];
            NbreEmploye = 0;
        }

        public void AjouterEmploye(Employe employe)
        {
            NbreEmploye++;
            if(NbreEmploye <= MAXEMPLOYE)
            {
                Employes[NbreEmploye - 1] = employe;
            }
            else
            {
                Console.WriteLine(" Pas plus de " + MAXEMPLOYE + " employés");
            }
                       
        }

        public void AfficherSalaires()
        {
            for (int i = 0; i < NbreEmploye; i++)
            {
                Console.WriteLine(Employes[i].GetNom() + " gagne " + Employes[i].CalculerSalaire() + " euros.");
            }
        }

        public double SalaireMoyen()
        {
            double somme = 0;
            for(int i = 0; i < NbreEmploye; i++)
            {
                somme += Employes[i].CalculerSalaire();
            }
            return somme / NbreEmploye;
        }
    }
}
