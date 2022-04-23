using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }

        public ICollection<Teacher_Class> Teacher_Classes { get; set; }
        public ICollection<Teacher_Course> Teacher_Courses { get; set; }

        public ICollection<Student_Teacher> Student_Teachers { get; set; }
    }
}
