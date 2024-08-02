namespace _9_FluentApi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_9_FluentApi.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_9_FluentApi.MyContext context)
        {

            #region "Tags"
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag{Id=1, Name="c#"} },
                {"angular", new Tag{ Id=2, Name="Angular"} },
                {"javascript", new Tag{Id=3, Name="JavaScripti"} }
            };

            foreach (var tag in tags.Values)
            {
                context.Tags.AddOrUpdate(t => t.Id, tag);
            }

            #endregion

            #region "Authors"
            var authors = new List<Author>
            {
                new Author{ Id=1, Name="Dawan"},
                new Author{ Id=2, Name = "Jehann"},
                new Author{Id = 3, Name = "James"}
            };

            foreach (var auth in authors)
            {
                context.Authors.AddOrUpdate(a => a.Id, auth);
            }

            #endregion

            #region "Courses"

            var courses = new List<Course>
            {
                new Course
                {
                    Id=1,
                    AuthorId=1,
                    Title = "c# Basic",
                    Description = "Initiation à c#",
                    Price = 20,
                    Tags = new List<Tag>
                    {
                        tags["c#"]
                    }
                },
                 new Course
                {
                    Id=2,
                    AuthorId =2,
                    Title = "JavaScript",
                    Description = "Cours JavaScript",
                    Price = 20,
                    Tags = new List<Tag>
                    {
                        tags["javascript"]
                    }
                },
                  new Course
                {
                    Id=3,
                    AuthorId=3,
                    Title = "Angular",
                    Description = "Initiation à Angular",
                    Price = 30,
                    Tags = new List<Tag>
                    {
                        tags["angular"]
                    }
                },

            };

            foreach (var cr in courses)
            {
                context.Courses.AddOrUpdate(c => c.Id, cr);
            }
            #endregion
        }
    }
}
