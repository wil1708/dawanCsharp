using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _7_CodeFirstDetail
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CourseSections> CourseSections { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.LevelString)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("CourseTags").MapLeftKey("CourseID").MapRightKey("TagID"));

            modelBuilder.Entity<CourseSections>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
