using ProjetDLL.Association;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public class ClientBddImpl : IClient
    {
        public void AjouterClient(Client c)
        {
            //SQL - Requête d'Insertion
        }

        public List<Client> GetAll()
        {
            //SQL - Requête de selection
            return null;
        }

        public void SupprimerClient(Client c)
        {
            //SQL - Requête de suppression;
        }

        public void UpdateClient(Client c)
        {
            //SQL - Requête de mise à jour ;
        }
    }
}
