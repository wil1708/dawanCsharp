using _5_CRUD_Winform.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace _5_CRUD_Winform.DAO
{
    public class MyDbContext : DbContext
    {
  
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }

}