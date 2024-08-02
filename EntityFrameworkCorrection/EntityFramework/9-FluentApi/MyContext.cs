using System;
using System.Data.Entity;
using System.Linq;

namespace _9_FluentApi
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
            //Afficher les logs et les commandes SQL
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cover> Covers { get; set; }

        //Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Table course
            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            modelBuilder.Entity<Course>()
               .Property(c => c.Title)
               .IsRequired()
               .HasMaxLength(255);

            //Clé etrangère AuthorId dans la classe Course + one-To-many
            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false); //la suppression d'un Course n'implique pas la suppression d'un Author

            //many-To-many : Course et Tag
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Tags)
                .WithMany(t => t.Courses)
                .Map(m =>
                {
                    m.ToTable("CourseTag")
                    .MapLeftKey("CourseId")
                    .MapRightKey("TagId");

                });

            //one-To-one: Course + Cover
            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Cover)
                .WithRequiredPrincipal(cv => cv.Course)
                .WillCascadeOnDelete(true);


            base.OnModelCreating(modelBuilder);
        }
    }
}