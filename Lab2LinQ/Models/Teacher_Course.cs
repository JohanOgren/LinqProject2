using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Teacher_Course
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }

        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
    }
}
