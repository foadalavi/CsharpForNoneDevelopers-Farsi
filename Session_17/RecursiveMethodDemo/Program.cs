using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // f   s   c
            //     f   s  c
            //         f   s   c
            // 0 , 1 , 1 , 2 , 3 , 5 , 8
            //var firstNumber = 0;
            //var SecondNumber = 1;
            //var currentNumber = 0;

            //Console.WriteLine(firstNumber);
            //Console.WriteLine(SecondNumber);
            //for (int i = 3; i <= 10; i++)
            //{

            //    currentNumber = firstNumber + SecondNumber;
            //    Console.WriteLine(currentNumber);
            //    firstNumber = SecondNumber;
            //    SecondNumber = currentNumber;
            //}
            //Console.WriteLine("Done!");
            //Console.ReadKey();



            Console.WriteLine(Fib(5));
            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        static int Fib(int itemIndex)
        {
            if (itemIndex==1)
            {
                return 0;
            }
            if (itemIndex==2)
            {
                return 1;
            }

            return Fib(itemIndex - 1) + Fib(itemIndex - 2);
        }
    }
}
