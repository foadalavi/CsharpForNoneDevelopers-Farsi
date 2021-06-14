using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Session14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert two numbers");

            Console.WriteLine(Mul());

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        static int Mul()
        {
            var result = 0;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                result = (a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You cannot enter 0 as one of your numbers.");
            }
            catch (AccessViolationException ex)
            {
                Console.WriteLine("sfdgsfdg");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong."); ;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("finally");
            }
            return result;
        }
    }
}
