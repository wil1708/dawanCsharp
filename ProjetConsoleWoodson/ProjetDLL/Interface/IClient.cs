using ProjetDLL.Association;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Interface
{
    public interface IClient
    {
        //Pseudo Classe Abstraite qui ne peut contenir que des signatures de méthodes
        void AjouterClient(Client c);
        void SupprimerClient(Client c);
        void UpdateClient(Client c);
        List<Client> GetAll();
    }
}
