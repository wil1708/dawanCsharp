using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraining.Entites;

namespace WPFTraining.DAO
{
    public class QcmDao
    {
        public static Qcm GenererExemple()
        {
            Qcm qcm = new Qcm() {Id=1, Intitule = "C#" };

            Question qst1 = new Question()
            {
                Id=1,
                ChoixMultiple = false,
                Enonce = "Comment appeler une méthode de classe (static) ?"
            };
            qst1.Reponses.Add(new Reponse(1, "NomObjet.NomMethode(..)", false));
            qst1.Reponses.Add(new Reponse(2, "NomClasse.NomMethode(..)", true));
            qcm.Questions.Add(qst1);

            Question qst2 = new Question()
            {
                Id = 2,
                ChoixMultiple = true,
                Enonce = "Comment créer une collection dynamique d'objets ?"
            };
            qst2.Reponses.Add(new Reponse(3, "en utilisant un tableau", false));
            qst2.Reponses.Add(new Reponse(4, "en utilisant une liste", true));
            qst2.Reponses.Add(new Reponse(5, "en utilisant une file", true));
            qcm.Questions.Add(qst2);

            return qcm;
        }
    }
}
