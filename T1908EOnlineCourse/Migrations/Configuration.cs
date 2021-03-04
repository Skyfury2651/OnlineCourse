namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<T1908EOnlineCourse.Models.Model2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "T1908EOnlineCourse.MyContext";
        }

        protected override void Seed(T1908EOnlineCourse.Models.Model2 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(c => c.id,
              new Models.Category { id = 1, name = @"Front-End" , image = @"qqqq"},
              new Models.Category { id = 2, name = @"Back-End", image = @"string" },
              new Models.Category { id = 3, name = @"Dev-Ops", image = @"string" },
              new Models.Category { id = 4, name = @"Bussiness-Analystic", image = @"string" },
              new Models.Category { id = 5, name = @"Project Manage", image = @"string" }
              );
            //context.Courses.AddOrUpdate(c => c.id,
            //new Models.Course
            //{
            //    id = 1,
            //    category_id = 1,
            //    name = @"HTML",
            //    description = @"So what is HTML? HTML is a markup language that defines the structure of your content. HTML consists of a series of elements, which you use to enclose, or wrap, different parts of the content to make it appear a certain way, or act a certain way. The enclosing tags can make a word or image hyperlink to somewhere else, can italicize words, can make the font bigger or smaller, and so on.  For example, take the following line of content:

            //My cat is very grumpy
            //If we wanted the line to stand by itself, we could specify that it is a paragraph by enclosing it in paragraph tags:

            //<p>My cat is very grumpy</p>",
            //    price = 28,
            //    status = 1,
            //    image = "string"
            //}
            //);
            context.Courses.AddOrUpdate(x => x.id,
                new Models.Course
                {
                    id = 1,
                    category_id = 1,
                    description = "text",
                    name = "test",
                    status = 1,
                    price = 1000,
                    image = "https://www.duomly.com/course/courseimg/courses/courseID12/course-12-html---css-basics.jpg"
                },
            new Models.Course
            {
                id = 2,
                category_id = 1,
                description = "text",
                name = "test",
                status = 1,
                price = 1000,
                image = "222"
            },
            new Models.Course
            {
                id = 3,
                category_id = 1,
                description = "text",
                name = "test",
                status = 1,
                price = 1000,
                image = "222"
            }
            );
        }
    }
}
