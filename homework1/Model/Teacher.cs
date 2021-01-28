using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework1.Model
{
    public class Teacher {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherFamily{ get; set; }

        public Class Class { get; set; }


    }

    //public interface IRepository
    //{
    //    IEnumerable<User> People { get; }
    //    User GetPerson(int id);
    //}


    //public class MemoryRepository : IRepository
    //{

    //    private List<User> people = new list<User>
    //    {
    //        new User
    //        {
    //            PersonId = 1,
    //            FirstName = "Alireza",
    //            LastName = "Darabi",
    //            Birthdate = new DateTime(1399,03,01),
    //            Role = Role.User,
    //        },
    //                new User
    //        {
    //            PersonId = 2,
    //            FirstName = "Behroz",
    //            LastName = "Nami",
    //            Birthdate = new DateTime(1399,03,01),
    //            Role = Role.User,
    //        },

    //    };
    //    public IEnumerable<User> People => people;

    //    public User GetPerson(int id)
    //    {
    //        return people.FirstOrDefault(c => c.PersonId == id)
    //    }

   // } 
}

