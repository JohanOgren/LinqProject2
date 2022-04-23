using Lab2LinQ.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Funktionalitet
{
    public class EditCourseFromTo
    {
        DatabaseRegister db = new DatabaseRegister();

        public void ChangeCourse()
        {
            var ändraKurs = from c in db.Courses
                            where c.CourseId == 2
                            select c;

            foreach (var item in ändraKurs)
            {
                item.CourseName = "Programmering 2";
                Console.WriteLine($"The Course Programming 2 is now {item.CourseName}");
            }
            db.SaveChanges();
        }
    }
}
