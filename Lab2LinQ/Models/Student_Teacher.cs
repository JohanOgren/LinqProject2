using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Models
{
   public class Student_Teacher
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }


    }
}
