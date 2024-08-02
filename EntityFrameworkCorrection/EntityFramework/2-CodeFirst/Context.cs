using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst
{

    public class Context : DbContext
    {
        public Context() : base("name=cnx")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
//Utilisation de Entity Framework Approche Code First : utiliser la console gestionnaire du package
//1- Enable-Migrations (vérifier que le projet est selectionné dans la solution - la console du package)
//La commande Enable-migrations ne s'execute qu'une seule fois (permet de vérifier que le projet n'est lié à aucune BD)
//Chaque mise à jours des classes objets implique une nouvelle migration et une mise à jours de la BD