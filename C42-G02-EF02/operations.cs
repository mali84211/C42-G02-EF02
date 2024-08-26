using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02
{
    internal class operations
    {
        public class ITIContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Topic> Topics { get; set; }
            public DbSet<Stud_Course> StudCourses { get; set; }
            public DbSet<CourseInst> CourseInsts { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.Entity<Topic>()
                    .HasKey(t => t.ID);
                modelBuilder.Entity<Topic>()
                   .Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                modelBuilder.Entity<Stud_Course>()
                    .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

                modelBuilder.Entity<Stud_Course>()
                    .Property(sc => sc.Grade)
                    .IsRequired();
            }
        }
        public void AddStudent(Student student)
        {
            using (var context = new ITIContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void AddDepartment(Department department)
        {
            using (var context = new ITIContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void AddCourse(Course course)
        {
            using (var context = new ITIContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
        public Student GetStudent(int id)
        {
            using (var context = new ITIContext())
            {
                return context.Students.Find(id);
            }
        }

        public Department GetDepartment(int id)
        {
            using (var context = new ITIContext())
            {
                return context.Departments.Find(id);
            }
        }

        public Course GetCourse(int id)
        {
            using (var context = new ITIContext())
            {
                return context.Courses.Find(id);
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new ITIContext())
            {
                context.Entry(student).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (var context = new ITIContext())
            {
                context.Entry(department).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateCourse(Course course)
        {
            using (var context = new ITIContext())
            {
                context.Entry(course).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteStudent(int id)
        {
            using (var context = new ITIContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var context = new ITIContext())
            {
                var department = context.Departments.Find(id);
                if (department != null)
                {
                    context.Departments.Remove(department);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteCourse(int id)
        {
            using (var context = new ITIContext())
            {
                var course = context.Courses.Find(id);
                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }
            }
        }

        public void ExampleUsage()
        {
            
            AddStudent(new Student { FName = "John", LName = "Doe", Age = 25, Dep_Id = 1 });
            AddDepartment(new Department { Name = "IT", Ins_ID = 1, HiringDate = DateTime.Now });

            var student = GetStudent(1);
            var department = GetDepartment(1);

            student.Age = 26;
            UpdateStudent(student);

            department.Name = "HR";
            UpdateDepartment(department);

          
            DeleteStudent(1);
            DeleteDepartment(1);
        }
    }
}
