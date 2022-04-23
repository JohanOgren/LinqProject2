using Lab2LinQ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab2LinQ.Funktionalitet
{
    public class GetTeacherForProgramming1
    {
        DatabaseRegister db = new DatabaseRegister();

        public void GetProgramming()
        {
            var teacherCourse = (from s in db.Teachers
                                 join ts in db.Teacher_Courses
                                 on s.TeacherId equals ts.TeacherId

                                 join c in db.Courses
                                 on ts.CourseId equals c.CourseId
                                 where c.CourseName == "Programmering 1"
                                 select new
                                 {
                                     teacherName = s.TeacherName,
                                     CourseName = c.CourseName
                                 }).ToList();

            foreach (var item in teacherCourse)
            {
                Console.WriteLine($"Teacher: {item.teacherName}   teaches: {item.CourseName}");
            }
        }
        

    }
}
