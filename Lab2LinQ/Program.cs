using Lab2LinQ.Funktionalitet;
using Lab2LinQ.Models;
using System;
using System.Linq;

namespace Lab2LinQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetTeacherForProgramming1 GetTeacher = new GetTeacherForProgramming1();
            EditCourseFromTo editCourse = new EditCourseFromTo();
            StudentsReadingCourseAndTeacher studentsReading = new StudentsReadingCourseAndTeacher();
            StudentsTeachers studentsTeachers = new StudentsTeachers();
            UpdateTeacherCourse updateTeacher = new UpdateTeacherCourse();

            bool continues = true;
            while (continues)
            {
                Console.WriteLine("1 to show Teachers for Programming 1\n2 to get all Students and their Teachers\n3 To get all Students who read the course Programmering 1 and their Teachers" +
                    "\n4 to change the Course Programmering 2 to OOP\n5 to To update a Teachers course in Programmering 1" +
                    "\n6 to Exit");
                try
                {
                    int val = int.Parse(Console.ReadLine());
                    switch (val)
                    {
                        case 1:

                            GetTeacher.GetProgramming();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            studentsTeachers.GetStudentTeachers();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            studentsReading.GetStudentsCoursewithT();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            editCourse.ChangeCourse();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            updateTeacher.UpdateTeachersCourse();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 6:
                            continues = false;
                            Console.WriteLine("Goodbye");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error can not do that.");
                    return;
                }

            }
























            /////////////////////////////////////////////////////////////////////////////////////////hämta lärare som är kopplad till kursen Programmering 1

            //var teacherCourse = (from s in db.Teachers
            //                     join ts in db.Teacher_Courses
            //                     on s.TeacherId equals ts.TeacherId

            //                     join c in db.Courses
            //                     on ts.CourseId equals c.CourseId
            //                     where c.CourseName == "Programmering 1"
            //                     select new
            //                     {
            //                         teacherName = s.TeacherName,
            //                         CourseName = c.CourseName
            //                     }).ToList();

            //foreach (var item in teacherCourse)
            //{
            //    Console.WriteLine($"Teacher: {item.teacherName}   teaches: {item.CourseName}");
            //}






            /////////////////////////////////////////////////////////////////////////////////////////Hämta Student samt kopplade Lärare
            //var studentTeachers = (from s in db.Students
            //                     join ts in db.Student_Teachers
            //                     on s.StudentId equals ts.StudentId

            //                     join c in db.Teachers
            //                     on ts.TeacherId equals c.TeacherId
            //                     select new{ studentName = s.StudentName, teacherName = c.TeacherName}).ToList();

            //foreach (var item in studentTeachers)
            //{
            //    Console.WriteLine($"Student:{item.studentName} Has {item.teacherName} as Teacher!");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////Hämta elever som läser Programmering 1 och skriv ut deras lärare.

            //var courseStudent = (from s in db.Students

            //                     join st in db.Student_Teachers
            //                     on s.StudentId equals st.StudentId

            //                     join ts in db.Student_Courses
            //                     on s.StudentId equals ts.StudentId

            //                     join c in db.Courses
            //                     on ts.CourseId equals c.CourseId

            //                     join t in db.Teachers
            //                     on st.TeacherId equals t.TeacherId

            //                     where c.CourseName == "Programmering 1"
            //                     select new
            //                     {
            //                         Student = s.StudentName,
            //                         Teacher = t.TeacherName,
            //                         Course = c.CourseName
            //                     }).ToList();


            //foreach (var item in courseStudent)
            //{
            //    Console.WriteLine(item);
            //}



            /////////////////////////////////////////////////////////////////////////////////////////Uppdatera Programmering 1 i tabellen till OOP

            //var ändraKurs = from c in db.Courses
            //                where c.CourseId == 2
            //                select c;

            //foreach (var item in ändraKurs)
            //{
            //    item.CourseName = "OOP";

            //}
            //db.SaveChanges();

            //Console.ReadLine();



            // Klickar på Byt Tobias från programmering 1 till Anas istället







            //var studentteachers = (from s in db.Teachers
            //                       join ts in db.Teacher_Courses
            //                       on s.TeacherId equals ts.TeacherId

            //                       join c in db.Courses
            //                       on ts.CourseId equals c.CourseId
            //                       where ts.TeacherId == 1 && ts.CourseId == 1
            //                       select ts
            //                       ).ToList();

            //foreach (var item in studentteachers)
            //{
            //    db.Remove(item);
            //    db.Add(new Teacher_Course { TeacherId = 3, CourseId = 1 });
            //    db.SaveChanges();
            //}
        }
        
    }
}
