using System;
using System.Collections.Generic;
namespace School.Domain.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourse = new HashSet<StudentCourse>();
        }
    
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        //public DbGeography Location { get; set; }
        public Nullable<int> TeacherId { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }   
}