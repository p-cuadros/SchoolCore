using System;
using System.Collections.Generic;
namespace School.Domain.Models
{
    public class StudentCourse
    {
        public int StudentID { get; set; }
        public int CourseId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}