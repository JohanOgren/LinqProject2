using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }

        public ICollection<Teacher_Course> Teacher_Courses { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; }
    }
}
