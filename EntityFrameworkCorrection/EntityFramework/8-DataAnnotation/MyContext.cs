using System;
using System.Data.Entity;
using System.Linq;

namespace _8_DataAnnotation
{
    public class MyContext : DbContext
    {
    
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }


        //Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Nom de la table
            modelBuilder.Entity<Author>()
                .ToTable("t_author");

            //Attrinut Name
            modelBuilder.Entity<Author>()
                .Property(t => t.Name)
                .HasMaxLength(255)
                .IsRequired();


            base.OnModelCreating(modelBuilder);
        }

    }

  
}