using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2LinQ.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }

        public ICollection<Teacher_Class> Teacher_Classes { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
