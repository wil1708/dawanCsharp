using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public interface IPersonnel
    {
        void AjouterEmploye(Employe employe);

        void AfficherSalaires();

        double SalaireMoyen();
    }
}
