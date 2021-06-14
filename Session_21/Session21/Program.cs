using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session21
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = new Person();
            DoSomething(ref y);
        }

        private static void DoSomething(ref Person x)
        {
            x = new Person();
        }
    }
}
