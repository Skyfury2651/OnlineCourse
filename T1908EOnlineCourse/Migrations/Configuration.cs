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
              new Models.Category { id = 1, name = @"Front-End", image = @"qqqq" },
              new Models.Category { id = 2, name = @"Back-End", image = @"string" },
              new Models.Category { id = 3, name = @"Dev-Ops", image = @"string" },
              new Models.Category { id = 4, name = @"Bussiness-Analystic", image = @"string" },
              new Models.Category { id = 5, name = @"Project Manage", image = @"string" }
              );

            //context.Courses.AddOrUpdate(x => x.id,
            //new Models.Course
            //{
            //    id = 1,
            //    category_id = 1,
            //    description = "HTML (Hypertext Markup Language) is the code that is used to structure a web page and its content. For example, content could be structured within a set of paragraphs, a list of bulleted points, or using images and data tables. As the title suggests, this article will give you a basic understanding of HTML and its functions.",
            //    name = "Introduction to HTML",
            //    status = 1,
            //    price = 10,
            //    image = "https://www.duomly.com/course/courseimg/courses/courseID12/course-12-html---css-basics.jpg"
            //}
            //new Models.Course
            //{
            //    id = 2,
            //    category_id = 1,
            //    description = "We've looked at a lot of text so far in this course, but the web would be really boring only using text. Let's start looking at how to make the web come alive with more interesting content! This module explores how to use HTML to include multimedia in your web pages, including the different ways that images can be included, and how to embed video, audio, and even entire webpages.",
            //    name = "Multimedia and embedding",
            //    status = 1,
            //    price = 20,
            //    image = "https://1.bp.blogspot.com/-bRc_6ua8YhA/XMWuToHKzkI/AAAAAAAAN3k/ZasbNr9q2FEmgSt957ypx9SnGbjgjX92QCLcBGAs/w1200-h630-p-k-no-nu/Build%2BResponsive%2BReal%2BWorld%2BWebsites%2Bwith%2BHTML5%2Band%2BCSS3%2BUdemy%2Bcourse.png"
            //},
            //new Models.Course
            //{
            //    id = 3,
            //    category_id = 1,
            //    description = "A very common task in HTML is structuring tabular data, and it has a number of elements and attributes for just this purpose. Coupled with a little CSS for styling, HTML makes it easy to display tables of information on the web such as your school lesson plan, the timetable at your local swimming pool, or statistics about your favorite dinosaurs or football team. This module takes you through all you need to know about structuring tabular data using HTML.",
            //    name = "HTML tables",
            //    status = 1,
            //    price = 30,
            //    image = "https://repository-images.githubusercontent.com/134285701/635de980-586d-11ea-9220-1a3211239c30"
            //}
            //);
            context.Courses.AddOrUpdate(x => x.id,
                new Models.Course
                {
                    id = 1,
                    category_id = 1,
                    description = "We've looked at a lot of text so far in this and how to embed video, audio, and even entire webpages.",
                    name = "Multimedia and embedding",
                    status = 1,
                    price = 20,
                    image = "https://1.bp.blogspot.com/-bRc_6ua8YhA/XMWuToHKzkI/AAAAAAAAN3k/ZasbNr9q2FEmgSt957ypx9SnGbjgjX92QCLcBGAs/w1200-h630-p-k-no-nu/Build%2BResponsive%2BReal%2BWorld%2BWebsites%2Bwith%2BHTML5%2Band%2BCSS3%2BUdemy%2Bcourse.png"
                },
                new Models.Course
                {
                    id = 2,
                    name = "Introduction to HTML",
                    category_id = 1,
                    description = "HTML (Hypertext Markup Language) is the code that is used to learn.",
                    status = 1,
                    price = 10,
                    image = "https://www.duomly.com/course/courseimg/courses/courseID12/course-12-html---css-basics.jpg"
                },
                new Models.Course
                {
                    id = 3,
                    category_id = 1,
                    description = "A very common task in HTML , or statistics about your favorite dinosaurs or football team. This module takes you through all you need to know about structuring tabular data using HTML.",
                    name = "HTML tables",
                    status = 1,
                    price = 30,
                    image = "https://repository-images.githubusercontent.com/134285701/635de980-586d-11ea-9220-1a3211239c30"
                }
                );
        }
    }
}

