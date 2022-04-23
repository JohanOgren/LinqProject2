using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Student_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
