using ProjetDLL.Association;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public class ClientImplFichier : IClient
    {
        public void AjouterClient(Client c)
        {
            

            //Ajouter dans un fichier;;
        }

        public List<Client> GetAll()
        {
            //Lister un élément dans le fichier;
            return null;
        }

        public void SupprimerClient(Client c)
        {
            //Suppression un élément dans un fichier
        }

        public void UpdateClient(Client c)
        {
           //Mettre à jour d'un élément dans un fichier;
        }
    }
}
