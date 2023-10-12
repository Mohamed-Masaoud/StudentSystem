using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class Course
    {
        public Course()
        {
        }

        public Course(int id, string name, string? description, DateTime stratDate, DateTime endDate, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            StratDate = stratDate;
            EndDate = endDate;
            this.price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public int price { get; set; }

        public List<Resource> Resources { get; set; } = null!;
        public List<StudentCourse> StudentCourses { get; set; } = null!;
        public List<Homework> homeworks { get; set; } = null!;

    }
}
