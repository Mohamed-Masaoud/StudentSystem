using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int id, string name, string? phoneNumber, DateTime registeredOn, DateTime? birthDate)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            RegisteredOn = registeredOn;
            BirthDate = birthDate;
        }

        [Required]
        public int Id { get; set; }
        public String Name { get; set; } = null!;
        public String? PhoneNumber { get; set; }
        public DateTime RegisteredOn  { get; set; }
        public DateTime? BirthDate { get;  set; }

        public List<StudentCourse> StudentCourses { get; set; }
        public List <Homework> homeworks { get; set; }


    }
}
