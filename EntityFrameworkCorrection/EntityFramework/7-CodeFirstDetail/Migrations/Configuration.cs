namespace _7_CodeFirstDetail.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_7_CodeFirstDetail.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_7_CodeFirstDetail.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Pratique sur une base de données de test - A ne pas faire en PROD
            

            context.Authors.AddOrUpdate(new Authors
            {
                Name="Dawan2",
                Courses = { new Courses() { Name="Java 8", Description="Java EE", Level=1, FullPrice = 100, LevelString="beginner"} }
            });

        }
    }
}
