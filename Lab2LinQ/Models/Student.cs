using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        public virtual Class Class { get; set; }
        public ICollection<Student_Teacher> Student_Teachers { get; set; }
        public ICollection<Student_Course> Student_Courses { get;set; }
    }
}
