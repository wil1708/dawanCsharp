using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
/*Mise en place de la couche DAO (Repository) - Approche Code First
 * 
 * getAll() - findById - Insert - Delete
 * 
 * Projet de Tests pour tester la couche DAO (Repository)
 */