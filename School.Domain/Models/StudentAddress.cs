using System;
using System.Collections.Generic;
namespace School.Domain.Models
{
    public class StudentAddress
    {
        public int StudentID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    
        public virtual Student Student { get; set; }
    }
}