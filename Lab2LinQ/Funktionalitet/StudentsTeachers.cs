using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab2LinQ.Models;

namespace Lab2LinQ.Funktionalitet
{
    public class StudentsTeachers
    {
        DatabaseRegister db = new DatabaseRegister();

        public void GetStudentTeachers()
        {
            var studentTeachers = (from s in db.Students
                                   join ts in db.Student_Teachers
                                   on s.StudentId equals ts.StudentId

                                   join c in db.Teachers
                                   on ts.TeacherId equals c.TeacherId
                                   select new { studentName = s.StudentName, teacherName = c.TeacherName }).ToList();

            foreach (var item in studentTeachers)
            {
                Console.WriteLine($"Student:{item.studentName} Has {item.teacherName} as Teacher!");
            }
        }
    }
}
