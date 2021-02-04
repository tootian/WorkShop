using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class CourseRepository 
    {

        private readonly SchoolContext Database;

        public CourseRepository(SchoolContext context)
        {
            this.Database = context;
        }

        public void CreateCourse(Course course)
        {
            Database.Courses.Add(course);
            Database.SaveChanges();
        }

        public IEnumerable<Course> GetAllcourses()
        {
            return Database.Courses;
        }

        public IEnumerable<Course> SearchCourse(Func<Course, bool> func)
        {
            return Database.Courses.Where(func);
        }

        public void updateCorse(Student course)
        {
            Database.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Database.SaveChanges();
        }
    }
}
