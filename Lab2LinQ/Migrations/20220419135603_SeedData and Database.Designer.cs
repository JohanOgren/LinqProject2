﻿// <auto-generated />
using System;
using Lab2LinQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab2LinQ.Migrations
{
    [DbContext(typeof(DatabaseRegister))]
    [Migration("20220419135603_SeedData and Database")]
    partial class SeedDataandDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab2LinQ.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "3A"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "3B"
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "3C"
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Programmering 1"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Programmering 2"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "JavaScript"
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "AgilaMetoder"
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassId = 1,
                            StudentName = "Tony"
                        },
                        new
                        {
                            StudentId = 2,
                            ClassId = 2,
                            StudentName = "Wanda"
                        },
                        new
                        {
                            StudentId = 3,
                            ClassId = 3,
                            StudentName = "Banner"
                        },
                        new
                        {
                            StudentId = 4,
                            ClassId = 1,
                            StudentName = "Rogers"
                        },
                        new
                        {
                            StudentId = 5,
                            ClassId = 2,
                            StudentName = "Strange"
                        },
                        new
                        {
                            StudentId = 6,
                            ClassId = 3,
                            StudentName = "Thor"
                        },
                        new
                        {
                            StudentId = 7,
                            ClassId = 1,
                            StudentName = "Thanos"
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 4
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 4
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 6
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 7
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student_Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 4
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 5
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 6
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 7
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            TeacherName = "Tobias"
                        },
                        new
                        {
                            TeacherId = 2,
                            TeacherName = "Anas"
                        },
                        new
                        {
                            TeacherId = 3,
                            TeacherName = "Reidar"
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Teacher_Class", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teacher_Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            TeacherId = 1
                        },
                        new
                        {
                            ClassId = 2,
                            TeacherId = 1
                        },
                        new
                        {
                            ClassId = 1,
                            TeacherId = 2
                        },
                        new
                        {
                            ClassId = 2,
                            TeacherId = 2
                        },
                        new
                        {
                            ClassId = 1,
                            TeacherId = 3
                        },
                        new
                        {
                            ClassId = 2,
                            TeacherId = 3
                        },
                        new
                        {
                            ClassId = 3,
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Teacher_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teacher_Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 4,
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            TeacherId = 3
                        },
                        new
                        {
                            CourseId = 4,
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student", b =>
                {
                    b.HasOne("Lab2LinQ.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student_Course", b =>
                {
                    b.HasOne("Lab2LinQ.Models.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2LinQ.Models.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab2LinQ.Models.Student_Teacher", b =>
                {
                    b.HasOne("Lab2LinQ.Models.Student", "Student")
                        .WithMany("Student_Teachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2LinQ.Models.Teacher", "Teacher")
                        .WithMany("Student_Teachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab2LinQ.Models.Teacher_Class", b =>
                {
                    b.HasOne("Lab2LinQ.Models.Class", "Class")
                        .WithMany("Teacher_Classes")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2LinQ.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab2LinQ.Models.Teacher_Course", b =>
                {
                    b.HasOne("Lab2LinQ.Models.Course", "Course")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2LinQ.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
