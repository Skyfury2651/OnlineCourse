namespace T1908EOnlineCourse.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=OnlineCourseDbContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.UserCourses)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<Course>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.price)
                .HasPrecision(9, 3);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Rates)
                .WithOptional(e => e.Course)
                .HasForeignKey(e => e.course_id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Sections)
                .WithOptional(e => e.Course)
                .HasForeignKey(e => e.course_id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.course_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Course)
                .HasForeignKey(e => e.course_id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.UserCourses)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.course_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.star)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Result>()
                .Property(e => e.link)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Lectures)
                .WithOptional(e => e.Section)
                .HasForeignKey(e => e.section_id);

            modelBuilder.Entity<Test>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.Test)
                .HasForeignKey(e => e.test_id);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.price)
                .HasPrecision(18, 0);
        }
    }
}
