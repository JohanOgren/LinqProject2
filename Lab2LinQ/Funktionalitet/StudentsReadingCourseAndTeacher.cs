using Lab2LinQ.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Funktionalitet
{
    public  class StudentsReadingCourseAndTeacher
    {
        readonly DatabaseRegister db = new DatabaseRegister();

        public void GetStudentsCoursewithT()
        {
            var courseStudent = (from s in db.Students

                                 join st in db.Student_Teachers
                                 on s.StudentId equals st.StudentId

                                 join t in db.Teachers
                                 on st.TeacherId equals t.TeacherId

                                 join sc in db.Student_Courses
                                 on s.StudentId equals sc.StudentId

                                 join c in db.Courses
                                 on sc.CourseId equals c.CourseId

                                 where c.CourseName == "Programmering 1"
                                 select new
                                 {
                                     Student = s.StudentName,
                                     Teacher = t.TeacherName,
                                 }).ToList();


            foreach (var item in courseStudent)
            {
                Console.WriteLine($"Student {item.Student} has the Teacher {item.Teacher}");
            }
        }

    }
}
