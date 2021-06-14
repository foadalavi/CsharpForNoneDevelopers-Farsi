using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 20; i++)
            {
                var random = new Random(i);
                Console.WriteLine(random.Next(0,1000));
            }
            Console.ReadLine();
        }
    }
}
