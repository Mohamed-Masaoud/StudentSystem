using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.App.Data
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ResourceType TypeOfResource { get; set; }
        public String URL { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set;} = null!;
    }
}
