using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework1.Model
{
    public class Corse
    {
        public int CorseId { get; set; }
        public string CorseName { get; set; }

        public List<Class> Class { get; set; }


    }
}
