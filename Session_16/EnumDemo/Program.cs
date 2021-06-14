using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            s.Name = "Foad";
            s.Family = "Alavi";
            s.Grad = EducationGrad.University;

            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
