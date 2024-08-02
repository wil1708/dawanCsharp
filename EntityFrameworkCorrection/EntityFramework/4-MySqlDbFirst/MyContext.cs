using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace _4_MySqlDbFirst
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))] //cette annotation permet de charger le driver ADO.NET de MySql
    public class MyContext : DbContext
    {
     
        public MyContext()
            : base("name=MyContext")
        {
        }
      
        public DbSet<Produit> Produits { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }


}