using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.App.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    StratDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TypeOfResource = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "homeworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentType = table.Column<int>(type: "INTEGER", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_homeworks_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_homeworks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 1, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "+1234567890", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 2, null, "Jane Smith", null, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 3, new DateTime(1999, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Johnson", "+9876543210", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 4, null, "Sarah Williams", "+5555555555", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 5, new DateTime(2001, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Davis", null, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 6, new DateTime(2002, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Johnson", null, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 7, new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Brown", "+7777777777", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 8, null, "Olivia Taylor", null, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 9, new DateTime(2004, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan Davis", "+8888888888", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 10, new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia Wilson", "+9999999999", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 1, "Learn the basics of programming in C#", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Programming", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 2, "Explore the fundamentals of web development", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Development Fundamentals", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 3, "Learn about database design and SQL queries", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Design and SQL", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 4, "Master OOP concepts with Java", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Object-Oriented Programming", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 130 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 5, "Study advanced data structures and algorithms", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Structures and Algorithms", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 180 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 6, "Introduction to machine learning concepts", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Machine Learning Fundamentals", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 7, "Build cross-platform mobile apps with Flutter", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile App Development with Flutter", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 160 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 8, "Learn about ethical hacking and cybersecurity", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethical Hacking and Cybersecurity", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 190 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 9, "Explore AI and deep learning techniques", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Artificial Intelligence and Deep Learning", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 220 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StratDate", "price" },
                values: new object[] { 10, "Master digital marketing techniques and strategies", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital Marketing Strategies", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 170 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 1, 1, "Introduction to Programming Video", 0, "https://example.com/video1" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 2, 2, "Web Development Basics Presentation", 1, "https://example.com/presentation1" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 3, 3, "Database Design Document", 2, "https://example.com/document1" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 4, 4, "Object-Oriented Programming Video", 0, "https://example.com/video2" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 5, 5, "Data Structures and Algorithms Presentation", 1, "https://example.com/presentation2" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 6, 6, "Machine Learning Fundamentals Document", 2, "https://example.com/document2" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 7, 7, "Mobile App Development with Flutter Video", 0, "https://example.com/video3" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 8, 8, "Ethical Hacking Presentation", 1, "https://example.com/presentation3" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 9, 9, "Artificial Intelligence and Deep Learning Document", 2, "https://example.com/document3" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CourseId", "Name", "TypeOfResource", "URL" },
                values: new object[] { 10, 10, "Digital Marketing Strategies Video", 0, "https://example.com/video4" });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 3 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 4 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 5 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 5 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 6 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 7 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 8 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 8 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 9 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 9 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 10 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 10 });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 1, 0, 4, 3, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 2, 1, 8, 3, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 3, 2, 1, 7, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 4, 0, 4, 10, new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 5, 1, 1, 2, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 6, 2, 9, 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 7, 0, 7, 7, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 8, 1, 9, 1, new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 9, 2, 9, 4, new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 10, 0, 8, 6, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 11, 1, 10, 3, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 12, 2, 2, 2, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 13, 0, 7, 8, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 14, 1, 9, 2, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "homeworks",
                columns: new[] { "Id", "ContentType", "CourseId", "StudentId", "SubmissionDate" },
                values: new object[] { 15, 2, 5, 10, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_homeworks_CourseId",
                table: "homeworks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_homeworks_StudentId",
                table: "homeworks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homeworks");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
