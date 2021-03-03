namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using T1908EOnlineCourse.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<T1908EOnlineCourse.Models.Model2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(T1908EOnlineCourse.Models.Model2 context)
        {
            var students = new List<Category>
        {
            new Category { id = 2, name = "Hi" },
        };
            students.ForEach(s => context.Categories.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
