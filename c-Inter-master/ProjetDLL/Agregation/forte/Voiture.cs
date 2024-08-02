using ProjetDLL.Agregation.association;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Agregation.forte
{
    public class Voiture
    {
        //Agrégation forte
        public Moteur Moteur { get; set; }

        //Un objet de type voiture possède forcément un objet de type moteur
        public Voiture(Moteur moteur)
        {
            Moteur = moteur;
        }

        //Association: un objet voiture utilise de manière temporaire un objet de type parking
        public void Garer(Parking parc)
        {
            parc.Garer();
        }
    }
}
