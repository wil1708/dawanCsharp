﻿using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFr
{
    public class MyContext : DbContext
    {
       
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

}