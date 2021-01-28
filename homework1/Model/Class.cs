using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework1.Model
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public Teacher Teacher { get; set; }

        public Corse Corse { get; set; }

        public List<Student> Students { get; set; } = new List<Student>() ;
    

    }

}
