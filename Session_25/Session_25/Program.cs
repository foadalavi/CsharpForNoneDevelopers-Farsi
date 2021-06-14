using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Foad";
            //Console.WriteLine(str.AddDotToEnd());
            //Console.WriteLine(str.AddSomethingToEnd(" alavi"));

            var str = "5";
            var x = str.To<int>();

            int number=8;
            number.To<double>();
            Person p = new Person();
            p.To<string>();
            Console.WriteLine(x * 2);
            Console.ReadKey();

        }
    }
}
