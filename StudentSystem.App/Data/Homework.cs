using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class Homework
    {
        public int Id { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public Student Student { get; set; } = null!;
        public Course Course { get; set;} = null!;
    }
}
