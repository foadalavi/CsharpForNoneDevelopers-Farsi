using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Class1[50, 50];

            array[0, 0] = new Class1();
            array[49, 49] = new Class1();
            Console.WriteLine(array[49, 49]);

        }
    }
}