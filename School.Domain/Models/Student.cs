using System;
using System.Collections.Generic;
namespace School.Domain.Models
{
    public class Student
    {
        public Student()
        {
            this.StudentCourse = new HashSet<StudentCourse>();
        }
    
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StandardId { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Standard Standard { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}