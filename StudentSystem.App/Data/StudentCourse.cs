using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class StudentCourse
    {
        public StudentCourse(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }

        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
