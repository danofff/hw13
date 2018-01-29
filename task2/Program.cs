using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static void propHandler()
        {
            Console.WriteLine("Propery is changed");
        }
        static void Main(string[] args)
        {
            someClass sCl = new someClass();
            sCl.someproperty = 10;
        }
    }
}
