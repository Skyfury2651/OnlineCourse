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
              new Models.Category
              {
                  id = 1,
                  name = @"Front-End",
                  image = @"qqqq"
              },
              new Models.Category
              {
                  id = 2,
                  name = @"Back-End",
                  image = @"string"
              },
              new Models.Category
              {
                  id = 3,
                  name = @"Dev-Ops",
                  image = @"string"
              },
              new Models.Category
              {
                  id = 4,
                  name = @"Bussiness-Analystic",
                  image = @"string"
              },
              new Models.Category
              {
                  id = 5,
                  name = @"Project Manage",
                  image = @"string"
              }
              );


            context.Courses.AddOrUpdate(x => x.id,
                new Models.Course
                {
                    id = 1,
                    category_id = 1,
                    description = "We've looked at a lot of text so far in this and how to embed video, audio, and even entire webpages.",
                    name = "HTML Basic",
                    status = 1,
                    price = 20,
                    image = "https://1.bp.blogspot.com/-bRc_6ua8YhA/XMWuToHKzkI/AAAAAAAAN3k/ZasbNr9q2FEmgSt957ypx9SnGbjgjX92QCLcBGAs/w1200-h630-p-k-no-nu/Build%2BResponsive%2BReal%2BWorld%2BWebsites%2Bwith%2BHTML5%2Band%2BCSS3%2BUdemy%2Bcourse.png"
                },
                new Models.Course
                {
                    id = 2,
                    name = "Introduction C#,C++",
                    category_id = 2,
                    description = "C#,C++ is the code that is used to learn.",
                    status = 1,
                    price = 10,
                    image = "https://repository-images.githubusercontent.com/134285701/635de980-586d-11ea-9220-1a3211239c30"
                },
                new Models.Course
                {
                    id = 3,
                    category_id = 3,
                    description = "A very common task in HTML , or statistics about your favorite dinosaurs or football team. This module takes you through all you need to know about structuring tabular data using HTML.",
                    name = "Introduction Dev-Ops",
                    status = 1,
                    price = 30,
                    image = "https://repository-images.githubusercontent.com/134285701/635de980-586d-11ea-9220-1a3211239c30"
                },
                new Models.Course
                {
                    id = 4,
                    category_id = 3,
                    description = "Node JS BeginCourse",
                    name = "NodeJS beginner",
                    status = 1,
                    price = 30,
                    image = "https://cdn.thenewstack.io/media/2016/04/nodejs.jpg"
                },
                new Models.Course
                {
                    id = 5,
                    category_id = 3,
                    description = "A very common task in HTML , or statistics about your favorite dinosaurs or football team. This module takes you through all you need to know about structuring tabular data using HTML.",
                    name = "Python Course",
                    status = 1,
                    price = 30,
                    image = "https://devu.in/wp-content/uploads/2020/01/Python-Training-in-bangalore.jpg"
                },
                new Models.Course
                {
                    id = 6,
                    category_id = 3,
                    description = "A very common task in HTML , or statistics about your favorite dinosaurs or football team. This module takes you through all you need to know about structuring tabular data using HTML.",
                    name = "Marketing",
                    status = 1,
                    price = 30,
                    image = "http://skillsdiver.com/wp-content/uploads/2018/11/192_-300x195.png"
                }
                );

            context.Sections.AddOrUpdate(x => x.id,
                new Models.Section
                {
                    id = 1,
                    name = "Introduction to HTML",
                    course_id = 1
                },
                new Models.Section
                {
                    id = 2,
                    name = "Multimedia and embedding",
                    course_id = 1
                },
                new Models.Section
                {
                    id = 3,
                    name = "HTML tables",
                    course_id = 1
                }
                );
            context.Lectures.AddOrUpdate(x => x.id,
                new Models.Lecture
                {
                    id = 1,
                    source = "https://youtu.be/bWPMSSsVdPk",
                    type = (int?)Models.Lecture.LectureType.MP4,
                    section_id = 1,
                },
                new Models.Lecture
                {
                    id = 2,
                    source = "https://youtu.be/wyx0kXKdqU8",
                    type = (int?)Models.Lecture.LectureType.MP4,
                    section_id = 2,
                },
                new Models.Lecture
                {
                    id = 3,
                    source = "https://youtu.be/ZWp1s1DhwDc",
                    type = (int?)Models.Lecture.LectureType.MP4,
                    section_id = 2,
                },
                new Models.Lecture
                {
                    id = 4,
                    source = "https://youtu.be/9F49XgzlZgA",
                    type = (int?)Models.Lecture.LectureType.MP4,
                    section_id = 3,
                },
                new Models.Lecture
                {
                    id = 5,
                    source = "https://youtu.be/XAowXcmQ-kA",
                    type = (int?)Models.Lecture.LectureType.MP4,
                    section_id = 3,
                }
                );
            context.Rates.AddOrUpdate(x => x.id,

                new Models.Rate
                {
                    id = 1,
                    course_id = 1,
                    content = "good",
                    star = 4,
                },
                new Models.Rate
                {
                    id = 2,
                    course_id = 1,
                    content = "greatest course i ever joined",
                    star = 5,
                },
                new Models.Rate
                {
                    id = 3,
                    course_id = 1,
                    content = "Would recommend this course",
                    star = 5,
                },
                new Models.Rate
                {
                    id = 4,
                    course_id = 1,
                    content = "Worth to buy this course",
                    star = 5,
                }
                );

            context.Tests.AddOrUpdate(
                new Models.Test
                {
                    id = 1,
                    course_id = 1,
                    content = "google doc link for course 1"
                },
                new Models.Test
                {
                    id = 2,
                    course_id = 2,
                    content = "google doc link for course 2"
                },
                new Models.Test
                {
                    id = 3,
                    course_id = 3,
                    content = "google doc link for course 3"
                }
                );

            context.Results.AddOrUpdate(x => x.id,
                new Models.Result
                {
                    id = 1,
                    test_id = 1,
                    user_id = "0f2c7802-9a9c-4a5c-97d5-71b3d2a0c0a1",
                    link = "Student test",
                    status = (int?)Models.Result.ResultStatus.PENDING,
                },
                new Models.Result
                {
                    id = 2,
                    test_id = 1,
                    user_id = "ac6caef2-8877-4e81-8d54-aa18b3cde28e",
                    link = "Student test",
                    status = (int?)Models.Result.ResultStatus.PASS,
                },
                new Models.Result
                {
                    id = 3,
                    test_id = 2,
                    user_id = "ac6caef2-8877-4e81-8d54-aa18b3cde28e",
                    link = "Student test",
                    status = (int?)Models.Result.ResultStatus.FAILED,
                }
                );
            context.UserCourses.AddOrUpdate(x => x.user_id,
                new Models.UserCourse
                {
                    user_id = "0f2c7802-9a9c-4a5c-97d5-71b3d2a0c0a1",
                    course_id = 1,
                    status = (int?)Models.UserCourse.UserCourseStatus.ACTIVE,
                    type = (int?)Models.UserCourse.UserCourseType.BUYER,
                },
                new Models.UserCourse
                {
                    user_id = "ac6caef2-8877-4e81-8d54-aa18b3cde28e",
                    course_id = 1,
                    status = (int?)Models.UserCourse.UserCourseStatus.ACTIVE,
                    type = (int?)Models.UserCourse.UserCourseType.BUYER,
                },
                new Models.UserCourse
                {
                    user_id = "87da706d-67cf-419b-836f-2c372e106174",
                    course_id = 1,
                    status = (int?)Models.UserCourse.UserCourseStatus.ACTIVE,
                    type = (int?)Models.UserCourse.UserCourseType.OWNER,
                },
                new Models.UserCourse
                {
                    user_id = "87da706d-67cf-419b-836f-2c372e106174",
                    course_id = 2,
                    status = (int?)Models.UserCourse.UserCourseStatus.ACTIVE,
                    type = (int?)Models.UserCourse.UserCourseType.OWNER,
                }
            );

            context.Organizations.AddOrUpdate(x => x.id, new Models.Organization
            {
                id = 1,
                description = "This is our private schools",
                email = "privateschool@gmail.com",
                name = "Private School",
                thumbnail = "url image"
            });

            context.AspNetRoles.AddOrUpdate(x => x.Id, new Models.AspNetRole
            {
                Id = "f5abdf0d-7377-4954-8c67-b3110a35c7c9",
                Name = "Instructor"
            });
            context.Transactions.AddOrUpdate(x => x.id, new Models.Transaction
            {
                id = 1,
                status = 1,
                price = 20,
                course_id = 1,
                user_id = "ac6caef2-8877-4e81-8d54-aa18b3cde28e",
                created_at = DateTime.Now.AddDays(-30),
                updated_at = DateTime.Now.AddDays(-30),
            }, new Models.Transaction
            {
                id = 2,
                status = 1,
                price = 30,
                course_id = 2,
                user_id = "82838b2f-4a15-4b1b-b77e-8726c1f0e6e6",
                created_at = DateTime.Now.AddDays(-10),
                updated_at = DateTime.Now.AddDays(-10),
            }, new Models.Transaction
            {
                id = 3,
                status = 1,
                price = 40,
                course_id = 3,
                user_id = "ed2d675a-d574-4cb6-9e6d-708f89515a69",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            }, new Models.Transaction
            {
                id = 4,
                status = 1,
                price = 2,
                course_id = 4,
                user_id = "46ec4551-4cb2-4918-82ca-24294be2f3fa",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            });

        }
    }
}

