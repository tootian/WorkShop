using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework1.DataAccess;
using homework1.Interfaces;
using homework1.Model;

namespace Workshop2.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly ClassContext Database;

        public StudentRepository(ClassContext context)
        {
            this.Database = context;
        }

        public void CreateStudent(Student student)
        {
            Database.Students.Add(student);
            Database.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return Database.Students;
        }

        public IEnumerable<Student> SearchStudent(Func<Student , bool> func)
        {
            return Database.Students.Where(func);
        }

        public void updateStudent(Student student)
        {
            Database.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Database.SaveChanges();
        }
    }
}
