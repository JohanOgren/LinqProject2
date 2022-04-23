using Lab2LinQ.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Funktionalitet
{
    public class UpdateTeacherCourse
    {
        DatabaseRegister db = new DatabaseRegister();

        public void UpdateTeachersCourse()
        {

                var studentteachers = (from s in db.Teachers
                                       join ts in db.Teacher_Courses
                                       on s.TeacherId equals ts.TeacherId

                                       join c in db.Courses
                                       on ts.CourseId equals c.CourseId
                                       where ts.TeacherId == 1 && ts.CourseId == 1
                                       select ts
                                   ).ToList();

                foreach (var item in studentteachers)
                {
                    db.Remove(item);
                    db.Add(new Teacher_Course { TeacherId = 2, CourseId = 1 });
                    db.SaveChanges();

                }
                Console.WriteLine("Table is now updated.");

            
        }
    }
}
