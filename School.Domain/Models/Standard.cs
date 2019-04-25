using System;
using System.Collections.Generic;
namespace School.Domain.Models
{
    public class Standard
    {
        public Standard()
        {
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }
    
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}