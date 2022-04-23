using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2LinQ.Models
{
    public class DatabaseRegister:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }

        //Relationer
        public DbSet<Student_Teacher> Student_Teachers { get; set; }

        public DbSet<Teacher_Class> Teacher_Classes { get; set; }

        public DbSet<Teacher_Course> Teacher_Courses { get; set; }

        public DbSet<Student_Course> Student_Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Skolan; Integrated Security=SSPI;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Teacher>()
                .HasKey(st => new { st.TeacherId, st.StudentId }); // Många till många

            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.CourseId, sc.StudentId }); // Många till många.

            modelBuilder.Entity<Student>() // student har 1 klass, 1 klass har många studenter
                .HasOne(c => c.Class)
                .WithMany(s => s.Students); // en till många



            modelBuilder.Entity<Teacher_Class>()
                .HasKey(tcl => new { tcl.ClassId, tcl.TeacherId }); // många till många 
            modelBuilder.Entity<Teacher_Course>()
                .HasKey(tc => new { tc.CourseId, tc.TeacherId }); // Många till många.


            modelBuilder.Entity<Student>()
                .HasData(
                new { StudentId = 1, StudentName = "Tony", ClassId = 1 },
                new { StudentId = 2, StudentName = "Wanda", ClassId = 2 },
                new { StudentId = 3, StudentName = "Banner", ClassId = 3 },
                new { StudentId = 4, StudentName = "Rogers", ClassId = 1 },
                new { StudentId = 5, StudentName = "Strange", ClassId = 2 },
                new { StudentId = 6, StudentName = "Thor", ClassId = 3 },
                new { StudentId = 7, StudentName = "Thanos", ClassId = 1 }
                );
            modelBuilder.Entity<Teacher>()
                .HasData(
                new {TeacherId = 1, TeacherName ="Tobias"},
                new {TeacherId = 2, TeacherName ="Anas"},
                new {TeacherId = 3, TeacherName ="Reidar"}
                );

            modelBuilder.Entity<Course>()
                .HasData(
                new { CourseId = 1, CourseName = "Programmering 1" },
                new { CourseId = 2, CourseName = "Programmering 2" },
                new { CourseId = 3, CourseName = "JavaScript" },
                new { CourseId = 4, CourseName = "AgilaMetoder" }
                
                );

            modelBuilder.Entity<Class>()
                .HasData(
                new { ClassId = 1, ClassName = "3A" },
                new { ClassId = 2, ClassName = "3B" },
                new { ClassId = 3, ClassName = "3C" } 
                );


            modelBuilder.Entity<Student_Course>()
                .HasData(
                new { StudentId = 1, CourseId = 1 },
                new { StudentId = 1, CourseId = 2 },
                new { StudentId = 2, CourseId = 3 },
                new { StudentId = 2, CourseId = 4 },
                new { StudentId = 3, CourseId = 1 },
                new { StudentId = 4, CourseId = 3 },
                new { StudentId = 4, CourseId = 1 },
                new { StudentId = 5, CourseId = 1 },
                new { StudentId = 6, CourseId = 3 },
                new { StudentId = 7, CourseId = 1 }
                );
            modelBuilder.Entity<Student_Teacher>()
                .HasData(
                new {StudentId = 1, TeacherId = 1},
                new {StudentId = 1, TeacherId = 2},
                new {StudentId = 2, TeacherId = 1},
                new {StudentId = 2, TeacherId = 2},
                new {StudentId = 3, TeacherId = 1},
                new {StudentId = 4, TeacherId = 2},
                new {StudentId = 5, TeacherId = 3},
                new {StudentId = 6, TeacherId = 2},
                new {StudentId = 7, TeacherId = 1}
                );

            modelBuilder.Entity<Teacher_Course>()
                .HasData(
                new { TeacherId = 1, CourseId = 1},
                new { TeacherId = 1, CourseId = 2},
                new { TeacherId = 2, CourseId = 3},
                new { TeacherId = 2, CourseId = 4},
                new { TeacherId = 3, CourseId = 1},
                new { TeacherId = 3, CourseId = 4}
                );
            modelBuilder.Entity<Teacher_Class>()
                .HasData(
                new {TeacherId = 1, ClassId = 1},
                new {TeacherId = 1, ClassId = 2},
                new {TeacherId = 2, ClassId = 1},
                new {TeacherId = 2, ClassId = 2},
                new {TeacherId = 3, ClassId = 1},
                new {TeacherId = 3, ClassId = 2},
                new {TeacherId = 3, ClassId = 3}
                );

        }

    }


}
