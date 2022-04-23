using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Models
{
       public class Teacher_Class
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }

        public Teacher Teacher { get; set; }
        public Class Class { get; set; }
    }
}
