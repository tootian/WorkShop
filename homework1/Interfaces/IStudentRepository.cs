using homework1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace homework1.Interfaces
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
        void updateStudent(Student student);
        IEnumerable<Student> SearchStudent(Func<Student , bool> func);
        IEnumerable<Student> GetAllStudents();

    }
}
