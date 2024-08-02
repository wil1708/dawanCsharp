using System;
using System.Data.Entity;
using System.Linq;

namespace MVC.Models
{
    public class MyContext : DbContext
    {
        
        public MyContext()
            : base("name=MyContext")
        {
        }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

    }

   
}