using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Interfaces
{
    public interface ICourseRepository
    {
        void CreateCourse(Course corse);
        void updateCourse(Course corse);
        IEnumerable<Course> SearchCourse(Func<Course, bool> func);
        IEnumerable<Course> GetAllCourse();
        IEnumerable<Course> GetAllcourses();
        void updateCorse(Course course);
    }
}
