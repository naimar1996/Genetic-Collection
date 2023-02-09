using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
   public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN{ get; set; }

        public string GetDetails()
        {
            return $"{Name},{Surname},{PIN}";
        }
    }
}
