using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Student.sytem.db");
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Homework> homeworks { get; set; } = null!;
        public DbSet<Course> courses { get; set; } = null!;
        public DbSet<StudentCourse> StudentCourses { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!;
        public String DbPath { get; set; } = String.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"data source= {DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentCourses)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudentCourses)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Resources)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.homeworks)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.homeworks)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Student>().HasData
                (
                    new Student(1, "John Doe", "+1234567890", DateTime.Parse("2022-01-15"), DateTime.Parse("2000-05-20")),
                    new Student(2, "Jane Smith", null, DateTime.Parse("2022-02-20"), null),
                    new Student(3, "Bob Johnson", "+9876543210", DateTime.Parse("2021-12-10"), DateTime.Parse("1999-09-05")),
                    new Student(4, "Sarah Williams", "+5555555555", DateTime.Parse("2022-03-25"), null),
                    new Student(5, "Michael Davis", null, DateTime.Parse("2022-04-30"), DateTime.Parse("2001-07-12")),
                    new Student(6, "Emily Johnson", null, DateTime.Parse("2022-05-05"), DateTime.Parse("2002-10-15")),
                    new Student(7, "David Brown", "+7777777777", DateTime.Parse("2022-06-10"), DateTime.Parse("2003-01-25")),
                    new Student(8, "Olivia Taylor", null, DateTime.Parse("2022-07-15"), null),
                    new Student(9, "Ethan Davis", "+8888888888", DateTime.Parse("2022-08-20"), DateTime.Parse("2004-03-02")),
                    new Student(10, "Sophia Wilson", "+9999999999", DateTime.Parse("2022-09-25"), DateTime.Parse("2005-06-18"))
                    );
            modelBuilder.Entity<Course>().HasData
                (
                    new Course(1, "Introduction to Programming", "Learn the basics of programming in C#", DateTime.Parse("2022-09-01"), DateTime.Parse("2022-12-01"), 100),
                    new Course(2, "Web Development Fundamentals", "Explore the fundamentals of web development", DateTime.Parse("2022-10-01"), DateTime.Parse("2022-12-15"), 150),
                    new Course(3, "Database Design and SQL", "Learn about database design and SQL queries", DateTime.Parse("2022-09-15"), DateTime.Parse("2022-12-15"), 120),
                    new Course(4, "Object-Oriented Programming", "Master OOP concepts with Java", DateTime.Parse("2022-09-10"), DateTime.Parse("2022-11-30"), 130),
                    new Course(5, "Data Structures and Algorithms", "Study advanced data structures and algorithms", DateTime.Parse("2022-10-15"), DateTime.Parse("2022-12-30"), 180),
                    new Course(6, "Machine Learning Fundamentals", "Introduction to machine learning concepts", DateTime.Parse("2022-10-05"), DateTime.Parse("2022-12-20"), 200),
                    new Course(7, "Mobile App Development with Flutter", "Build cross-platform mobile apps with Flutter", DateTime.Parse("2022-09-20"), DateTime.Parse("2022-12-10"), 160),
                    new Course(8, "Ethical Hacking and Cybersecurity", "Learn about ethical hacking and cybersecurity", DateTime.Parse("2022-10-10"), DateTime.Parse("2022-12-25"), 190),
                    new Course(9, "Artificial Intelligence and Deep Learning", "Explore AI and deep learning techniques", DateTime.Parse("2022-09-25"), DateTime.Parse("2022-12-30"), 220),
                    new Course(10, "Digital Marketing Strategies", "Master digital marketing techniques and strategies", DateTime.Parse("2022-10-15"), DateTime.Parse("2022-12-20"), 170)
                    );

            modelBuilder.Entity<StudentCourse>().HasData
                (
                    new StudentCourse(1, 1),
                    new StudentCourse(1, 2),
                    new StudentCourse(2, 3),
                    new StudentCourse(3, 4),
                    new StudentCourse(4, 5),
                    new StudentCourse(5, 6),
                    new StudentCourse(2, 7),
                    new StudentCourse(3, 8),
                    new StudentCourse(4, 9),
                    new StudentCourse(5, 10),
                    new StudentCourse(6, 1),
                    new StudentCourse(7, 2),
                    new StudentCourse(8, 3),
                    new StudentCourse(9, 4),
                    new StudentCourse(10, 5),
                    new StudentCourse(6, 6),
                    new StudentCourse(7, 7),
                    new StudentCourse(8, 8),
                    new StudentCourse(9, 9),
                    new StudentCourse(10, 10)
                    );

            modelBuilder.Entity<Resource>().HasData
                (
                    new Resource(1, "Introduction to Programming Video", ResourceType.VIDEO, "https://example.com/video1", 1),
                    new Resource(2, "Web Development Basics Presentation", ResourceType.PRESENTATION, "https://example.com/presentation1", 2),
                    new Resource(3, "Database Design Document", ResourceType.DOCUMENT, "https://example.com/document1", 3),
                    new Resource(4, "Object-Oriented Programming Video", ResourceType.VIDEO, "https://example.com/video2", 4),
                    new Resource(5, "Data Structures and Algorithms Presentation", ResourceType.PRESENTATION, "https://example.com/presentation2", 5),
                    new Resource(6, "Machine Learning Fundamentals Document", ResourceType.DOCUMENT, "https://example.com/document2", 6),
                    new Resource(7, "Mobile App Development with Flutter Video", ResourceType.VIDEO, "https://example.com/video3", 7),
                    new Resource(8, "Ethical Hacking Presentation", ResourceType.PRESENTATION, "https://example.com/presentation3", 8),
                    new Resource(9, "Artificial Intelligence and Deep Learning Document", ResourceType.DOCUMENT, "https://example.com/document3", 9),
                    new Resource(10, "Digital Marketing Strategies Video", ResourceType.VIDEO, "https://example.com/video4", 10)
                    );

            modelBuilder.Entity<Homework>().HasData
                (
                    new Homework(1, ContentType.APPLICATION, DateTime.Parse("2022-10-10"), 4, 3),
                    new Homework(2, ContentType.PDF, DateTime.Parse("2022-10-12"), 8, 3),
                    new Homework(3, ContentType.ZIP, DateTime.Parse("2022-10-14"), 1, 7),
                    new Homework(4, ContentType.APPLICATION, DateTime.Parse("2022-10-16"), 4, 10),
                    new Homework(5, ContentType.PDF, DateTime.Parse("2022-10-18"), 1, 2),
                    new Homework(6, ContentType.ZIP, DateTime.Parse("2022-10-20"), 9, 3),
                    new Homework(7, ContentType.APPLICATION, DateTime.Parse("2022-10-22"), 7, 7),
                    new Homework(8, ContentType.PDF, DateTime.Parse("2022-10-24"), 9, 1),
                    new Homework(9, ContentType.ZIP, DateTime.Parse("2022-10-26"), 9, 4),
                    new Homework(10, ContentType.APPLICATION, DateTime.Parse("2022-10-28"), 8, 6),
                    new Homework(11, ContentType.PDF, DateTime.Parse("2022-10-30"), 10, 3),
                    new Homework(12, ContentType.ZIP, DateTime.Parse("2022-11-01"), 2, 2),
                    new Homework(13, ContentType.APPLICATION, DateTime.Parse("2022-11-03"), 7, 8),
                    new Homework(14, ContentType.PDF, DateTime.Parse("2022-11-05"), 9, 2),
                    new Homework(15, ContentType.ZIP, DateTime.Parse("2022-11-07"), 5, 10)
                     );

        }
    }
}
