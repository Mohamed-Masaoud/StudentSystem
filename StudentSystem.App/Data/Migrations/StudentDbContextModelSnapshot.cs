﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.App.Data;

#nullable disable

namespace StudentSystem.App.Data.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("StudentSystem.App.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StratDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Learn the basics of programming in C#",
                            EndDate = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Introduction to Programming",
                            StratDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 100
                        },
                        new
                        {
                            Id = 2,
                            Description = "Explore the fundamentals of web development",
                            EndDate = new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Web Development Fundamentals",
                            StratDate = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 150
                        },
                        new
                        {
                            Id = 3,
                            Description = "Learn about database design and SQL queries",
                            EndDate = new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Database Design and SQL",
                            StratDate = new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 120
                        },
                        new
                        {
                            Id = 4,
                            Description = "Master OOP concepts with Java",
                            EndDate = new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Object-Oriented Programming",
                            StratDate = new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 130
                        },
                        new
                        {
                            Id = 5,
                            Description = "Study advanced data structures and algorithms",
                            EndDate = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Data Structures and Algorithms",
                            StratDate = new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 180
                        },
                        new
                        {
                            Id = 6,
                            Description = "Introduction to machine learning concepts",
                            EndDate = new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Machine Learning Fundamentals",
                            StratDate = new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 200
                        },
                        new
                        {
                            Id = 7,
                            Description = "Build cross-platform mobile apps with Flutter",
                            EndDate = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mobile App Development with Flutter",
                            StratDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 160
                        },
                        new
                        {
                            Id = 8,
                            Description = "Learn about ethical hacking and cybersecurity",
                            EndDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ethical Hacking and Cybersecurity",
                            StratDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 190
                        },
                        new
                        {
                            Id = 9,
                            Description = "Explore AI and deep learning techniques",
                            EndDate = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Artificial Intelligence and Deep Learning",
                            StratDate = new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 220
                        },
                        new
                        {
                            Id = 10,
                            Description = "Master digital marketing techniques and strategies",
                            EndDate = new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Digital Marketing Strategies",
                            StratDate = new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            price = 170
                        });
                });

            modelBuilder.Entity("StudentSystem.App.Data.Homework", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContentType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("homeworks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContentType = 0,
                            CourseId = 4,
                            StudentId = 3,
                            SubmissionDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ContentType = 1,
                            CourseId = 8,
                            StudentId = 3,
                            SubmissionDate = new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ContentType = 2,
                            CourseId = 1,
                            StudentId = 7,
                            SubmissionDate = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ContentType = 0,
                            CourseId = 4,
                            StudentId = 10,
                            SubmissionDate = new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ContentType = 1,
                            CourseId = 1,
                            StudentId = 2,
                            SubmissionDate = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            ContentType = 2,
                            CourseId = 9,
                            StudentId = 3,
                            SubmissionDate = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            ContentType = 0,
                            CourseId = 7,
                            StudentId = 7,
                            SubmissionDate = new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            ContentType = 1,
                            CourseId = 9,
                            StudentId = 1,
                            SubmissionDate = new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            ContentType = 2,
                            CourseId = 9,
                            StudentId = 4,
                            SubmissionDate = new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            ContentType = 0,
                            CourseId = 8,
                            StudentId = 6,
                            SubmissionDate = new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            ContentType = 1,
                            CourseId = 10,
                            StudentId = 3,
                            SubmissionDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            ContentType = 2,
                            CourseId = 2,
                            StudentId = 2,
                            SubmissionDate = new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            ContentType = 0,
                            CourseId = 7,
                            StudentId = 8,
                            SubmissionDate = new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            ContentType = 1,
                            CourseId = 9,
                            StudentId = 2,
                            SubmissionDate = new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            ContentType = 2,
                            CourseId = 5,
                            StudentId = 10,
                            SubmissionDate = new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentSystem.App.Data.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeOfResource")
                        .HasColumnType("INTEGER");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Name = "Introduction to Programming Video",
                            TypeOfResource = 0,
                            URL = "https://example.com/video1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Name = "Web Development Basics Presentation",
                            TypeOfResource = 1,
                            URL = "https://example.com/presentation1"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Name = "Database Design Document",
                            TypeOfResource = 2,
                            URL = "https://example.com/document1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            Name = "Object-Oriented Programming Video",
                            TypeOfResource = 0,
                            URL = "https://example.com/video2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            Name = "Data Structures and Algorithms Presentation",
                            TypeOfResource = 1,
                            URL = "https://example.com/presentation2"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 6,
                            Name = "Machine Learning Fundamentals Document",
                            TypeOfResource = 2,
                            URL = "https://example.com/document2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 7,
                            Name = "Mobile App Development with Flutter Video",
                            TypeOfResource = 0,
                            URL = "https://example.com/video3"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 8,
                            Name = "Ethical Hacking Presentation",
                            TypeOfResource = 1,
                            URL = "https://example.com/presentation3"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 9,
                            Name = "Artificial Intelligence and Deep Learning Document",
                            TypeOfResource = 2,
                            URL = "https://example.com/document3"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 10,
                            Name = "Digital Marketing Strategies Video",
                            TypeOfResource = 0,
                            URL = "https://example.com/video4"
                        });
                });

            modelBuilder.Entity("StudentSystem.App.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe",
                            PhoneNumber = "+1234567890",
                            RegisteredOn = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jane Smith",
                            RegisteredOn = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1999, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bob Johnson",
                            PhoneNumber = "+9876543210",
                            RegisteredOn = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sarah Williams",
                            PhoneNumber = "+5555555555",
                            RegisteredOn = new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2001, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Michael Davis",
                            RegisteredOn = new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2002, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Emily Johnson",
                            RegisteredOn = new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "David Brown",
                            PhoneNumber = "+7777777777",
                            RegisteredOn = new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Name = "Olivia Taylor",
                            RegisteredOn = new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(2004, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ethan Davis",
                            PhoneNumber = "+8888888888",
                            RegisteredOn = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sophia Wilson",
                            PhoneNumber = "+9999999999",
                            RegisteredOn = new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentSystem.App.Data.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 1,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 5
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 6
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 7
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 8
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 9
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 10
                        },
                        new
                        {
                            StudentId = 6,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 8,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 9,
                            CourseId = 4
                        },
                        new
                        {
                            StudentId = 10,
                            CourseId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            CourseId = 6
                        },
                        new
                        {
                            StudentId = 7,
                            CourseId = 7
                        },
                        new
                        {
                            StudentId = 8,
                            CourseId = 8
                        },
                        new
                        {
                            StudentId = 9,
                            CourseId = 9
                        },
                        new
                        {
                            StudentId = 10,
                            CourseId = 10
                        });
                });

            modelBuilder.Entity("StudentSystem.App.Data.Homework", b =>
                {
                    b.HasOne("StudentSystem.App.Data.Course", "Course")
                        .WithMany("homeworks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentSystem.App.Data.Student", "Student")
                        .WithMany("homeworks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.App.Data.Resource", b =>
                {
                    b.HasOne("StudentSystem.App.Data.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.App.Data.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.App.Data.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentSystem.App.Data.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.App.Data.Course", b =>
                {
                    b.Navigation("Resources");

                    b.Navigation("StudentCourses");

                    b.Navigation("homeworks");
                });

            modelBuilder.Entity("StudentSystem.App.Data.Student", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("homeworks");
                });
#pragma warning restore 612, 618
        }
    }
}
